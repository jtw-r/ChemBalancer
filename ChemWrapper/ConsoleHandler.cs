using System;
using ChemBalancer;
using ChemAtoms;
using ChemConsole;

namespace ChemWrapper {
	public class ConsoleHandler {

		private AtomView cAtomView;

		public ConsoleHandler() {
			ConsoleFunctions.WriteLine("ChemBalancer\n(c) Copyright 2017");
			ConsoleFunctions.WriteLine("\n> Type HELP for help");

			Handler();
		}

		private void Handler() {
			while (true) {
				ConsoleFunctions.WriteLine("Command:");
				string line_input = ConsoleFunctions.ReadLine().ToLower();
				switch (line_input) {
					default:
						ConsoleFunctions.WriteLine("> This command does not exits.", ConsoleColor.Yellow);
						continue;
					case "help":
						ConsoleFunctions.WriteLines(new[] {
							"Balance - the command to balance an equation.\n",
							"[Does not exits]Check - the command to check if an equation is balanced correct.\n",
							"[WIP]Atom Info - the command to show information on a specific atom."
						});
						break;
					case "balance":
						while (true) {
							if (Balancer.BalanceEquation() == false) continue;
							break;
						}
						break;
					case "atom info":
						cAtomView = new AtomView();
						cAtomView.ShowDialog();
						break;
					case "exit":
						ConsoleFunctions.WriteLine("Have a nice day!",ConsoleColor.Gray,false);
						return;
				}
				ConsoleFunctions.WriteLine("",ConsoleColor.Gray,false);
			}
		}
	}
}
