using System;

namespace ChemBalancer {
	internal class Program {
		[STAThread]
		private static void Main() {
			var pr = new Program();
			pr.CommandLineHandler();
		}

		public void CommandLineHandler() {
			Console.WriteLine("ChemBalancer\n(c) Copyright 2017");
			Console.WriteLine("\n> Type HELP for help");
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
						var bal = new Balancer();
						while (true) {
							if (bal.BalanceEquation() == false) continue;
							break;
						}
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