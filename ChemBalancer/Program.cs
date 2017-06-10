using System;

namespace ChemBalancer {
	internal class Program {

		[STAThread]
		private static void Main() {
			var pr = new Program();
			pr.CommandLineHandler();
		}

		public void CommandLineHandler() {
			Console.WriteLine("ChemBalancer\n(c) Copyright 2017\n\n> Type HELP for help");
			while (true) {
				Console.WriteLine("> Command:");
				string line_input = Console.ReadLine().ToLower();
				switch(line_input) {
					default:
						continue;
					case "help":
						Console.WriteLine("> Balance\n"+"> Check");
						break;
					case "balance":
						var bal = new Balancer();
						bal.BalanceEquation();
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
