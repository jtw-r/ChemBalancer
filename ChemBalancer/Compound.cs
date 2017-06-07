using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Compound {

		public Dictionary<string,int> elements;

		public Compound(string _formula) {
			string[] e = Regex.Split(_formula, "([A-Z])(?=[A-Z])");
			
		}

	}
}
