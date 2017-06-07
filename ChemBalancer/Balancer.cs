using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Balancer {
		public void BalanceEquation() {
			GetReactants();
		}

		public List<string> GetReactants() {
			Console.WriteLine("> Reactants:");
			string input = Console.ReadLine();

			var c = new Compound(input);

			return null;
		}

		public List<string> GetProducts() {
			return null;
		}
	}
}
