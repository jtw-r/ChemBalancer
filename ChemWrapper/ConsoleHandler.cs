using System;
using System.Diagnostics;
using ChemBalancer;
using ChemAtoms;

namespace ChemWrapper {
	public class ConsoleHandler {

		private readonly Atom c_Atom;
		private readonly Balancer c_Balancer;

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
						continue;
					case "help":
						Console.WriteLine("> Balance - the command to balance an equation.\n" +
						                  "> [WIP]Check - the command to check if an equation is balanced correct.");
						break;
					case "balance":
						while (true) {
							if (c_Balancer.BalanceEquation() == false) continue;
							break;
						}
						break;
					case "atom info":
						break;
					case "check":
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
