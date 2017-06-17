using System;
using ChemBalancer;
using ChemAtoms;
using ChemConsole;

namespace ChemWrapper {
	public class ConsoleHandler {

		ColourFormatConsole cfc = new ColourFormatConsole();
		private AtomView cAtomView;
		private Balancer cBalancer;

		public ConsoleHandler() {
			cfc.WriteLine("ChemBalancer\n(c) Copyright 2017");
			cfc.WriteLine("\n> Type HELP for help");

			Handler();
		}

		internal void Handler() {
			while (true) {
				cfc.WriteLine("Command:");
				string line_input = cfc.ReadLine().ToLower();
				switch (line_input) {
					default:
						cfc.WriteLine("> This command does not exits.", ConsoleColor.Yellow);
						continue;
					case "help":
						cfc.WriteLines(new[] {
							"Balance - the command to balance an equation.\n",
							"[Does not exits]Check - the command to check if an equation is balanced correct.\n",
							"[WIP]Atom Info - the command to show information on a specific atom."
						});
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
						cfc.WriteLine("Have a nice day!",ConsoleColor.Gray,false);
						return;
				}
				cfc.WriteLine("",ConsoleColor.Gray,false);
			}
		}
	}
}
