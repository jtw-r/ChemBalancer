using System;
using ChemAtoms;
using ChemBalancer;
using static ChemConsole.ConsoleFunctions;

namespace ChemWrapper {
	public class ConsoleHandler {
		public ConsoleHandler() {
			WriteLine("ChemBalancer\n(c) Copyright 2017");
			WriteLine("\n> Type HELP for help");

			Handler();
		}

		private static void Handler() {
			while (true) {
				WriteLine("Command:");
				string line_input = ReadLine().ToLower();
				switch (line_input) {
					default:
						WriteLine("> This command does not exits.", ConsoleColor.Yellow);
						continue;
					case "help":
						WriteLines(new[] {
							"Balance - the command to balance an equation.\n",
							"[WIP]Check - the command to check if an equation is balanced correct.\n",
							"[WIP]Atom Info - the command to show information on a specific atom."
						});
						break;
					case "balance":
						while (true) {
							if (Balancer.BalanceEquation() == false) continue;
							break;
						}
						break;
					case "check":
						WriteLine("WARNING: The command CHECK is not fully finished!", ConsoleColor.Red);
						break;
					case "check -dev":
						WriteLine("Entered Dev Mode", ConsoleColor.Yellow, false);
						Checker.CheckEquation();
						break;
					case "atom info":
						new AtomView().ShowDialog();
						break;
					case "exit":
						WriteLine("Have a nice day!", ConsoleColor.Gray, false);
						return;
				}
				WriteLine("", ConsoleColor.Gray, false);
			}
		}
	}
}
