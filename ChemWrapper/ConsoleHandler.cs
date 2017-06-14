using System;
using ChemBalancer;
using ChemAtoms;

namespace ChemWrapper {
	public class ConsoleHandler {

		private AtomView cAtomView;
		private Balancer cBalancer;

		public ConsoleHandler() {
			Console.WriteLine("ChemBalancer\n(c) Copyright 2017");
			Console.WriteLine("\n> Type HELP for help");

			Handler();
		}

		internal void Handler() {
			while (true) {
				Console.WriteLine("> Command:");
				Console.ForegroundColor = ConsoleColor.White;
				string line_input = Console.ReadLine().ToLower();
				Console.ForegroundColor = ConsoleColor.Gray;
				switch (line_input) {
					default:
						Console.WriteLine("> This command does not exits.");
						continue;
					case "help":
						Console.WriteLine("> Balance - the command to balance an equation.\n" +
						                  "> [Does not exits]Check - the command to check if an equation is balanced correct.\n" +
										  "> [WIP]Atom Info - the command to show information on a specific atom.");
						break;
					case "balance":
						cBalancer = new Balancer();
						while (true) {
							if (cBalancer.BalanceEquation() == false) continue;
							break;
						}
						break;
					case "atom info":
						cAtomView = new AtomView();
						cAtomView.ShowDialog();
						break;
					case "exit":
						Console.Write("Have a nice day!");
						return;
				}
				Console.WriteLine();
			}
		}
	}
}
