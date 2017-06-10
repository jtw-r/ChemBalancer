using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Compound {

		public List<Element> Elements = new List<Element>();
		public int Multip { private set; get; }

		public string Full { private set; get; }

		public Compound(string _formula) {
			this.Full = _formula;
			string[] e = Regex.Split(_formula, "(?=[A-Z])");

			var _multip = Regex.Match(e[0], "([0-9]+)").Value;
			if (_multip == "") {
				Multip = 1;
			} else {
				Multip = Convert.ToInt32(_multip);
			}

			for (int i = 1; i < e.Length; i++) {
				var num = Regex.Match(e[i], "([0-9]+)").Value;
				if (num == "") {
					num = "1";
				}

				var atom = e[i].Replace("^" + num, "");

				Elements.Add(new Element(atom, Convert.ToInt32(num)));
				Console.WriteLine(Elements[i-1].Atom + ":" + Elements[i-1].Count);
			}
			Console.WriteLine(Multip);
		}

		public void ReUp(int _times) {
			Multip += Math.Abs(_times);

			for (int i = 0; i < Elements.Count; i++) {
				Elements[i].ReUp(Math.Abs(_times));
			}

		}

		public bool CheckFor(string _atom) {
			bool found = false;
			for (int e = 0; e < Elements.Count; e++) {
				if (Elements[e].Atom == _atom) {
					found = true;
				}
			}
			return found;
		}

	}
}
