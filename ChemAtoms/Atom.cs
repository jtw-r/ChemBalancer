using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemAtoms{
	public class Atom {

		public string Symbol { private set; get; }
		public string Name { private set; get; }

		public int Number { private set; get; }
		public float Mass { private set; get; }

		private int period; // X-axis
		private int group; // Y-axis

		public int Protons { private set; get; }
		public int Neutrons { private set; get; }
		public int Eletrons { private set; get; }

		private int electronShells;

		public Atom(string _symbol, string _name, int _number, float _mass, int _period, int _group) {
			Symbol = _symbol;
			Name = _name;

			Number = _number;
			Mass = _mass;

			period = _period;
			group = _group;

			Protons = (int) _mass;
			Neutrons = (int) _mass;
			Eletrons = _number;

			electronShells = _period;
		}
		
	}
}
