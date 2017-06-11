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

		public Atom(string _symbol) {
			var data = new AtomData().FindAtom(_symbol);
			Symbol = _symbol;
			Name = data.Item1;

			Number = data.Item2;
			Mass = data.Item3;

			period = data.Item4;
			group = data.Item5;

			Protons = data.Item2;
			Neutrons = (int) data.Item3;
			Eletrons = data.Item2;

			electronShells = data.Item4;

		}
		
	}
}
