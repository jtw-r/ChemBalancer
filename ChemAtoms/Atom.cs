using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Atom {

		public string Symbol { private set; get; }
		public int Number { private set; get; }
		public float Mass { private set; get; }

		private int Period; // X-axis
		private int Group; // Y-axis

		public int Protons { private set; get; }
		public int Neutrons { private set; get; }
		public int Eletrons { private set; get; }

		private int electron_shells;

		public Atom(string _symbol) {

		}
		
	}
}
