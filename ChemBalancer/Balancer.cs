using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChemBalancer {
	class Balancer {
		public void BalanceEquation() {
			var reactants = AskForCompounds("> Reactants:");
			var products = AskForCompounds("> Products:");
			var comp = new[] { reactants, products };

			if (reactants == null || products == null) return;

			var unique_elements = new List<string>();

			for (int comp_index= 0; comp_index < comp.Length; comp_index++) {
				for (int component = 0; component < comp[comp_index].Count; component++) {
					for (int e = 0; e < comp[comp_index][component].Elements.Count; e++) {
						string current_atom = comp[comp_index][component].Elements[e].Atom;

						if (!unique_elements.Contains(current_atom)) {
							unique_elements.Add(current_atom);
						}
					}
				}
			}

			var balance_table = new int[unique_elements.Count, 2];

			Action recalc_balance_table = () => {
				balance_table = new int[unique_elements.Count, 2];

				for (int comp_index = 0; comp_index < comp.Length; comp_index++) {
					for (int component = 0; component < comp[comp_index].Count; component++) {
						for (int e = 0; e < comp[comp_index][component].Elements.Count; e++) {
							int atom_count = comp[comp_index][component].Elements[e].Count;
							int entry = unique_elements.FindIndex(comp[comp_index][component].Elements[e].Atom.Equals);

							balance_table[entry, comp_index] += atom_count;
						}
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
					int side = need < 0 ? 0 : 1;
					need = Math.Abs(need);
					
					var occurances = new List<Compound>();
					for (int i = 0; i < comp[side].Count; i++) {
						if (!comp[side][i].CheckFor(atom)) continue;
						for (int el = 0; el < comp[side][i].Elements.Count; el++) {
							if (comp[side][i].Elements[el].Atom != atom) continue;
							break;
						}
						occurances.Add(comp[side][i]);
					}

					if (occurances.Count == 0) {
						string side_value = side == 0 ? "reactant" : "product";
						Console.WriteLine("> ERROR in " + side_value + ".");
						return;
					}

					int occurance = 0;
					for (int el = 0; el < occurances[0].Elements.Count; el++) {
						if (occurances[0].Elements[el].Atom != atom) continue;
						occurance = el;
						break;
					}
					int occurance_base_count = occurances[0].Elements[occurance].BaseCount;

					need = CheckAndUpdate(need, occurance_base_count);

					occurances[0].ReUp(need / occurance_base_count);
					recalc_balance_table();
				}

				if (!can_break) continue;
				Console.WriteLine("\n>Output:");
				var output = new[] {"", ""};

				for (int comp_index = 0; comp_index < comp.Length; comp_index++) {
					for (int component = 0; component < comp[comp_index].Count; component++) {
						if (component != 0) {
							output[comp_index] += " + ";
						}
						output[comp_index] += comp[comp_index][component].GetMultiplier() + comp[comp_index][component].Full;
					}
				}

				Console.WriteLine(output[0] + " >>> " + output[1]);
				break;
			}

		}

		public int CheckAndUpdate(int _a, int _b) {
			while (_a/_b < 1) {
				_a += _a;
			}
			return _a;
		}

		public List<Compound> AskForCompounds(string _prompt) {
			while (true) {
				Console.WriteLine(_prompt);
				string input = Console.ReadLine();

				if (input == null) continue;
				switch (input.ToLower()) {
					default:
						var input_split = Regex.Split(input.Replace(" ", ""), "[+]");
						return input_split.Select(_compounds => new Compound(_compounds.Replace("+", ""))).ToList();
					case "redo":
						continue;
					case "exit":
						return null;
					case "":
						return null;
				}
			}
		}
	}
}
