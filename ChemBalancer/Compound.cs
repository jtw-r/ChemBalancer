using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChemBalancer {
	internal class Compound {
		// I'm not even going to bother documenting this file right now.

		public readonly List<Element> Elements = new List<Element>();
		public int Multiplier { private set; get; }

		public string FullEquation { get; }

		public Compound(string _formula) {
			FullEquation = _formula;

			var parenthesis = Regex.Split(_formula, "(?>[(])");

			if (parenthesis.Length > 1) {
				for (int p = 1; p < parenthesis.Length; p++) {
					var parenthesis_end = Regex.Split(parenthesis[p], "(?<=[)])");

					string parenthesis_num = Regex.Match(parenthesis_end[1], "([0-9]+)").Value;
					if (parenthesis_num == "") {
						parenthesis_num = "1";
					}

					string parenthesis_without = parenthesis[p].Remove(parenthesis[p].IndexOf(")", StringComparison.Ordinal));
					
					Elements.Add(new Element(parenthesis_without,Convert.ToInt32(parenthesis_num),true));
					_formula = parenthesis_num != "1"
						? _formula.Remove(_formula.IndexOf("(" + parenthesis_without + ")^" + parenthesis_num,
							StringComparison.Ordinal))
						: _formula.Remove(_formula.IndexOf("(" + parenthesis_without + ")", StringComparison.Ordinal));
				}
			}

			CreateElements(_formula);
		}

		private void CreateElements(string _formula, int _mult = 1) {
			var input = Regex.Split(_formula, "(?=[A-Z])");

			string check_multip = Regex.Match(input[0], "([0-9]+)").Value;
			Multiplier = check_multip == "" ? 1 : Convert.ToInt32(check_multip);

			for (int i = 1; i < input.Length; i++) {
				string num = Regex.Match(input[i], "([0-9]+)").Value;
				if (num == "") num = "1";

				string atom = input[i].Replace("^" + num, "");

				Elements.Add(new Element(atom, Convert.ToInt32(num)*_mult));
			}
		}

		/// <summary>
		/// Multiplies the base number and adds it to the element.
		/// NOT overiding the base number.
		/// </summary>
		/// <param name="_times"></param>
		public void ReUp(int _times) {
			Multiplier += Math.Abs(_times);

			for (int i = 0; i < Elements.Count; i++) {
				Elements[i].ReUp(Math.Abs(_times));
			}

		}

		/// <summary>
		/// Checks to see if an atom is in this compound.
		/// </summary>
		/// <param name="_atom"></param>
		/// <returns>[true/false] If said atom is in this compound</returns>
		public bool CheckFor(string _atom) {
			return Elements.Any(_t => _t.Atom.Symbol == _atom);
		}

		/// <summary>
		/// Returns the compounds multiplier.
		/// 2H^2O
		/// </summary>
		/// <returns></returns>
		public string GetMultiplier() {
			// I would have just had it return the raw multiplier in
			// string form but I wanted it to output nothing if the
			// multiplier was equal to 1.

			if (Multiplier == 1) return "";
			return Multiplier + "";
		}

	}
}
