using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Program {

		[STAThread]
		static void Main(string[] args) {
			Program pr = new Program();
			pr.CommandLineHandler();
		}

		public void CommandLineHandler() {
			Console.WriteLine("ChemBalancer\n(c) Copyright 2017");
			while (true) {
				Console.WriteLine("\nCommand:");
				var line_input = Console.ReadLine().ToLower();
				switch(line_input) {
					case "help":
						Console.WriteLine("> Balance\n"+"> Check");
						break;
					case "balance":
						Balancer bal = new Balancer();
						bal.BalanceEquation();
						break;
					case "check":
						break;
				}
			}
		}
	}
}
