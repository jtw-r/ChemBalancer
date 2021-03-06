﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ChemConsole;

namespace ChemBalancer {
	public static class Checker {
		public static void CheckEquation() {
			string was_balanced = Try();
			if (was_balanced == "true") {
				ConsoleFunctions.WriteLine("\nYour equation is properaly balanced.", ConsoleColor.Green, false);
			} else if (was_balanced != "exit") {
				ConsoleFunctions.WriteLine("\nYour equation is NOT properaly balanced.", ConsoleColor.Yellow, false);
				ConsoleFunctions.WriteLine(was_balanced, ConsoleColor.Yellow, false);
			}
		}

		private static string Try() {
			// Ask user for reactants and products.
			var reactants = AskForCompounds("Reactants:");
			var products = AskForCompounds("Products:");

			// Create an array that refrences the compounds for easy
			// access with intagers.
			var comp = new[] { reactants, products };

			// Check if either reactants or products returned null,
			// if so, exit because we can't do anything.
			if (reactants == null || products == null) return "exit";

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

			// Calculate the balance table for the first time.
			for (int comp_index = 0; comp_index < comp.Length; comp_index++)
			for (int component = 0; component < comp[comp_index].Count; component++)
			for (int e = 0; e < comp[comp_index][component].Elements.Count; e++) {
				int atom_count = comp[comp_index][component].Elements[e].Count * comp[comp_index][component].Multiplier;
				int entry = unique_elements.FindIndex(comp[comp_index][component].Elements[e].Atom.Symbol.Equals);

				balance_table[entry, comp_index] += atom_count;
			}

			// This loop cycles through the elements in the balance table.
			for (int e = 0; e < balance_table.GetLength(0); e++) {

				// Calculates the need for the selected element.
				// Gets the element's reactant cound and subtracts the
				// product's count resulting in a sometimes negative number.
				int need = balance_table[e, 0] - balance_table[e, 1];

				if (need == 0) continue; // Yay, this element was perfectly balanced!
										 // Continue onto the next element in the table.

				int side = need < 0 ? 0 : 1;
				string side_value = side == 0 ? "reactant" : "product";
				return "Try adjusting " + unique_elements[e] + " by " + Math.Abs(need) + " on the " + side_value + "s side.";
			}

			// Yes, it was successful! Return true.
			return "true";
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
