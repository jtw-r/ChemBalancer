using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Compound {

		public List<Element> elements = new List<Element>();
		public int multip { private set; get; }

		public Compound(string _formula) {
			string[] e = Regex.Split(_formula, "(?=[A-Z])");

			var _multip = Regex.Match(e[0], "([0-9]+)").Value;
			if (_multip == "") {
				multip = 1;
			} else {
				multip = Convert.ToInt32(_multip);
			}

			for (int i = 1; i < e.Length; i++) {
				var num = Regex.Match(e[i], "([0-9]+)").Value;
				if (num == "") {
					num = "1";
				}

				var atom = e[i].Replace("^" + num, "");

				elements.Add(new Element(atom, Convert.ToInt32(num)));
				Console.WriteLine(elements[i-1].Atom + ":" + elements[i-1].Count);
			}
			Console.WriteLine(multip);
		}

		public void ReUp(int times) {
			this.multip += Math.Abs(times);

			for (int i = 0; i < elements.Count; i++) {
				elements[i].ReUp(times);
			}

		}

		public bool CheckFor(string _atom) {
			bool found = false;
			for (int e = 0; e < elements.Count; e++) {
				if (elements[e].Atom == _atom) {
					found = true;
				}
			}
			return found;
		}

	}
}
