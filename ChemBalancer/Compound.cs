using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChemBalancer {
	class Compound {

		public List<Element> Elements = new List<Element>();
		public int Multiplier { private set; get; }

		public string Full { get; }

		public Compound(string _formula) {
			Full = _formula;

			var parenthesis = Regex.Split(_formula, "(?>[(])");

			if (parenthesis.Length > 1) {
				for (int p = 1; p < parenthesis.Length; p++) {
					var parenthesis_end = Regex.Split(parenthesis[p], "(?<=[)])");

					string parenthesis_num = Regex.Match(parenthesis_end[1], "([0-9]+)").Value;
					string parenthesis_without = parenthesis[p].Remove(parenthesis[p].IndexOf(")", StringComparison.Ordinal));

					CreateElements(parenthesis_without, Convert.ToInt32(parenthesis_num));
					_formula = _formula.Remove(_formula.IndexOf("(" + parenthesis_without + ")^" + parenthesis_num,
						StringComparison.Ordinal));
				}
			}

			CreateElements(_formula);
		}

		public void CreateElements(string _formula, int _mult = 1) {
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

		public void DoTheOtherSplit(string _formula) {
			
		}

		public void ReUp(int _times) {
			Multiplier += Math.Abs(_times);

			for (int i = 0; i < Elements.Count; i++) {
				Elements[i].ReUp(Math.Abs(_times));
			}

		}

		public bool CheckFor(string _atom) {
			bool found = false;
			for (int e = 0; e < Elements.Count; e++) {
				if (Elements[e].Atom != _atom) continue;
				found = true;
			}
			return found;
		}

		public string GetMultiplier() {
			string returned = "";

			if (Multiplier == 1) return returned;
			returned = Multiplier + "";

			return returned;
		}

	}
}
