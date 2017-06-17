using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ChemConsole;

namespace ChemBalancer {
	public static class Balancer {
		public static bool BalanceEquation(int _tollerence = 100) {
			// Ask user for reactants and products.
			var reactants = AskForCompounds("Reactants:");
			var products = AskForCompounds("Products:");

			// Create an array that refrences the compounds for easy
			// access with intagers.
			var comp = new[] {reactants, products};

			// Check if either reactants or products returned null,
			// if so, exit because we can't do anything.
			if (reactants == null || products == null) return true;

			// Create a list that will represent each element non repeting.
			var unique_elements = new List<string>();

			// Start the for-loop to look through the compounds for elements.
			for (int comp_index = 0; comp_index < comp.Length; comp_index++)
			for (int component = 0; component < comp[comp_index].Count; component++)
			for (int e = 0; e < comp[comp_index][component].Elements.Count; e++) {
				// Get the current atom that the for-loops are looking at.
				string current_atom = comp[comp_index][component].Elements[e].Atom.Symbol;
				
				// Check if the current element's symbol (H, N, Cl) is NOT already
				// in the unique_elements list. If so, add it to the list!
				if (!unique_elements.Contains(current_atom)) unique_elements.Add(current_atom);
			}

			// Create a new array for the balancing table. This table will keep
			// track of how many of each atom are in the equation on each side.
			var balance_table = new int[unique_elements.Count, 2];

			// This nested method will re-count all of the atoms and update the
			// balance table.
			Action recalc_balance_table = () => {
				// Creates a new array because it's easier. I will probably change
				// this later so that it does not and updates the value.
				balance_table = new int[unique_elements.Count, 2];

				for (int comp_index = 0; comp_index < comp.Length; comp_index++)
				for (int component = 0; component < comp[comp_index].Count; component++)
				for (int e = 0; e < comp[comp_index][component].Elements.Count; e++) {
					int atom_count = comp[comp_index][component].Elements[e].Count;
					int entry = unique_elements.FindIndex(comp[comp_index][component].Elements[e].Atom.Symbol.Equals);

					balance_table[entry, comp_index] += atom_count;
				}
			};

			// Calculate the balance table for the first time.
			recalc_balance_table();

			// This is the main loop! This loop cycles through the balance table
			// works on balancing elements out.
			int count = 0;
			while (true) {
				if (count > _tollerence) {
					return ConsoleFunctions.ThrowError("Equation could not be balanced");
				}

				// A simple true/false to tell if the loop should stop.
				// Default is true then gets set false later if needed.
				bool can_break = true;

				// This loop cycles through the elements in the balance table.
				for (int e = 0; e < balance_table.GetLength(0); e++) {

					// Calculates the need for the selected element.
					// Gets the element's reactant cound and subtracts the
					// product's count resulting in a sometimes negative number.
					int need = balance_table[e, 0] - balance_table[e, 1];
					
					if (need == 0) continue; // Yay, this element was perfectly balanced!
											 // Continue onto the next element in the table.

					// Oh no, the element was not balanced. Tell the loop that
					// it can't break yet.
					can_break = false;

					// Get the current element's symbol. FYI: unique_elements
					// and balance_table's element indexe's are aligned.
					string atom = unique_elements[e];

					// Set which side we need to adjust. Negative values denote the
					// reactant side while positive values denote the product side.
					int side = need < 0 ? 0 : 1;

					// Now that need doesn't need to be negative, get the absolute
					// value of it for later use where it shouldn't be negative.
					need = Math.Abs(need);

					// Create a list to keep track of all of the compounds that
					// contain the selected element.
					var occurances = new List<Compound>();

					// Look through all of the compounds on selected side and see if
					// they contain the element we are looking for.
					for (int i = 0; i < comp[side].Count; i++) {
						if (!comp[side][i].CheckFor(atom)) continue;
						for (int el = 0; el < comp[side][i].Elements.Count; el++) {
							if (comp[side][i].Elements[el].Atom.Symbol != atom) continue; // This element was not the one we want :(
																						  // Goto the next element in the compound.
							
							// Yay! the selected element was the one we were looking
							// for, break the loop so that it doesn't continue.
							break;
						}
						// The loop was broken so lets add the compound to the list.
						// There might possibly be a problem here? Not sure if when
						// the for-loop ends it goes directly here or not.
						occurances.Add(comp[side][i]);
					}

					// Check that our for-loops above actually found a compound with
					// the selected element in it.
					if (occurances.Count == 0) {
						// Huston, we have a problem. A need was detected for an
						// element that does not exist! That can't happen normally.
						// Warn the user.
						string side_value = side == 0 ? "reactant" : "product";
						return ConsoleFunctions.ThrowError("ERROR in " + side_value + ".");
					}

					// The index of the element that we want to target in the
					// compound. Default is zero.
					int occurance = 0;

					// Find the element's index.
					for (int el = 0; el < occurances[0].Elements.Count; el++) {
						if (occurances[0].Elements[el].Atom.Symbol != atom) continue;

						// Oh good, it found it. Set occurance to equal the index
						// then stop the loop.
						occurance = el;
						break;
					}

					// Get the element's base count (H^2 <-- 2)
					int occurance_base_count = occurances[0].Elements[occurance].BaseCount;

					// ReUp, multiply and add, the element, but first check to
					// make sure that need/o_b_c is > 1, if not make it > 1 using
					// DivideAndUpdate() which returns the new need.
					occurances[0].ReUp(DivideAndUpdate(need, occurance_base_count) / occurance_base_count);

					// Rebalance the balance table.
					recalc_balance_table();
					count++;
				}

				if (!can_break) continue;

				// Yay! The loop can break, start the output process.
				ConsoleFunctions.WriteLine("\n>Output:",ConsoleColor.Gray,false);

				// Create an array for the reactant and product output.
				var output = new[] {"", ""};

				// Loop through each compound on each side of the formula
				// and append it to the output.
				for (int comp_index = 0; comp_index < comp.Length; comp_index++)
				for (int component = 0; component < comp[comp_index].Count; component++) {
					if (component != 0) output[comp_index] += " + "; // Add a divider in-between each compound,
																	 // but not on the first entry.

					// Append the compounds multiplyer than the origional value;
					// 2NaO^4Xe^2
					output[comp_index] += comp[comp_index][component].GetMultiplier() + comp[comp_index][component].FullEquation;
				}

				// Finally, output the final values in bright yellow.
				ConsoleFunctions.WriteLine(output[0] + " >>> " + output[1],ConsoleColor.Yellow,false);
				break;
			}
			// Yes, it was successful! Return true.
			return true;
		}

		private static int DivideAndUpdate(int _a, int _b) {
			// If _a/_b is less than 1 then double _a until _a/_b is greater than 1.
			while (_a / _b < 1) _a += _a;

			// Yay! _a/_b is > 1, now return _a.
			return _a;
		}

		private static List<Compound> AskForCompounds(string _prompt) {
			while (true) {
				ConsoleFunctions.WriteLine(_prompt);
				string input = ConsoleFunctions.ReadLine();

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