using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChemConsole;

namespace ChemBalancer {
	public static class Checker {
		public static void CheckEquation() {
			bool was_balanced = Balancer.BalanceEquation(100, Balancer.UseType.Check);
			if (was_balanced) {
				ConsoleFunctions.WriteLine("Your equation is properaly balanced.", ConsoleColor.Green);
			} else {
				ConsoleFunctions.WriteLine("Your equation is NOT properaly balanced.", ConsoleColor.Yellow);
			}
		}
	}
}
