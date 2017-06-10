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
				for (int e = 0; e < reactants[r].Elements.Count; e++) {
					string current_atom = reactants[r].Elements[e].Atom;

					if (!unique_elements.Contains(current_atom)) {
						unique_elements.Add(current_atom);
					}
				}
			}

			for (int p = 0; p < products.Count; p++) {
				for (int e = 0; e < products[p].Elements.Count; e++) {
					string current_atom = products[p].Elements[e].Atom;

					if (!unique_elements.Contains(current_atom)) {
						unique_elements.Add(current_atom);
					}
				}
			}

			var balance_table = new int[unique_elements.Count, 2];
			Action recalc_balance_table = () => {
				balance_table = new int[unique_elements.Count, 2];
				for (int r = 0; r < reactants.Count; r++) {
					for (int e = 0; e < reactants[r].Elements.Count; e++) {
						int atom_count = reactants[r].Elements[e].Count;
						int entry = unique_elements.FindIndex(reactants[r].Elements[e].Atom.Equals);

						balance_table[entry, 0] += atom_count;
					}
				}

				for (int p = 0; p < products.Count; p++) {
					for (int e = 0; e < products[p].Elements.Count; e++) {
						int atom_count = products[p].Elements[e].Count;
						int entry = unique_elements.FindIndex(products[p].Elements[e].Atom.Equals);

						balance_table[entry, 1] += atom_count;
					}
				}
			};

			recalc_balance_table();

			while (true) {
				bool can_break = true;
				for (int e = 0; e < balance_table.GetLength(0); e++) {
					int need = balance_table[e, 0] - balance_table[e, 1];

					if (need == 0) continue;
					can_break = false;
					string atom = unique_elements[e];

					int side;
					side = need < 0 ? 0 : 1;

					var comp = new List<Compound>[] {reactants, products};

					var occurances = new List<Compound>();
					for (int i = 0; i < comp[side].Count; i++) {
						if (comp[side][i].CheckFor(atom)) {
							//int entry = comp[side][i].Elements.FindIndex(a => Element.Atom atom.Equals);

							int entry = 0;
							for (int el = 0; el < comp[side][i].Elements.Count; el++) {
								if (comp[side][i].Elements[el].Atom == atom) {
									entry = el;
									break;
								}
							}

							int entry_base_count = comp[side][i].Elements[entry].base_count;

							// Checks if entry divides evenly by need.
							if (need % entry_base_count == 0) {
								occurances.Add(comp[side][i]);
							}
						}
					}

					if (occurances.Count == 0) {
						string side_value = "";
						side_value = side == 0 ? "reactant" : "product";
						Console.WriteLine("> ERROR in " + side_value + ".");
						return;
					}

					int occurance = 0;
					for (int el = 0; el < occurances[0].Elements.Count; el++) {
						if (occurances[0].Elements[el].Atom == atom) {
							occurance = el;
							break;
						}
					}
					int occurance_base_count = occurances[0].Elements[occurance].base_count;

					occurances[0].ReUp(need / occurance_base_count);
					recalc_balance_table();
				}

				if (can_break) {
					Console.WriteLine("\n>Output:");
					foreach (var item in reactants) {
						Console.WriteLine(item.Multip + item.Full);
					}
					foreach (var item in products) {
						Console.WriteLine(item.Multip + item.Full);
					}
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
