using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Balancer {
		public void BalanceEquation() {
			var reactants = GetReactants();
			var products = GetProducts();

			var unique_elements = new List<string>();

			for (int r = 0; r < reactants.Count; r++) {
				for (int e = 0; e < reactants[r].elements.Count; e++) {
					string current_atom = reactants[r].elements[e].Atom;

					if (!unique_elements.Contains(current_atom)) {
						unique_elements.Add(current_atom);
					}
				}
			}

			for (int p = 0; p < products.Count; p++) {
				for (int e = 0; e < products[p].elements.Count; e++) {
					string current_atom = products[p].elements[e].Atom;

					if (!unique_elements.Contains(current_atom)) {
						unique_elements.Add(current_atom);
					}
				}
			}

			var balance_table = new int[unique_elements.Count, 2];
			Action recalc_balance_table = () => {
				balance_table = new int[unique_elements.Count, 2];
				for (int r = 0; r < reactants.Count; r++) {
					for (int e = 0; e < reactants[r].elements.Count; e++) {
						int atom_count = reactants[r].elements[e].Count;
						int entry = unique_elements.FindIndex(reactants[r].elements[e].Atom.Equals);

						balance_table[entry, 0] += atom_count;
					}
				}

				for (int p = 0; p < products.Count; p++) {
					for (int e = 0; e < products[p].elements.Count; e++) {
						int atom_count = products[p].elements[e].Count;
						int entry = unique_elements.FindIndex(products[p].elements[e].Atom.Equals);

						balance_table[entry, 1] += atom_count;
					}
				}
			};

			recalc_balance_table();

			while (true) {
				bool can_break = true;
				for (int e = 0; e < balance_table.GetLength(0); e++) {
					int need = balance_table[e, 0] - balance_table[e, 1];

					if (need == 0) {
						break;
					}

					can_break = false;
					string atom = unique_elements[e];

					int side;
					if (need < 0) {
						side = 0;
					}
					else {
						side = 1;
					}

					var comp = new List<Compound>[] { reactants, products };

					var occurances = new List<Compound>();
					for (int i = 0; i < comp[side].Count; i++) {
						if (comp[side][i].CheckFor(atom)) {
							occurances.Add(comp[side][i]);
						}
					}

				}

				if (can_break) {
					break;
				}
			}

		}

		

		public List<Compound> GetReactants() {
			Console.WriteLine("> Reactants:");
			string input = Console.ReadLine();

			var rs = Regex.Split(input.Replace(" ",""),"[+]");

			return rs.Select(t => new Compound(t.Replace("+", ""))).ToList();
		}

		public List<Compound> GetProducts() {
			Console.WriteLine("> Products:");
			string input = Console.ReadLine();

			var ps = Regex.Split(input.Replace(" ", ""), "[+]");

			return ps.Select(t => new Compound(t.Replace("+", ""))).ToList();
		}
	}
}
