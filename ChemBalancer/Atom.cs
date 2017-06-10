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
		private int valence_electrons;

		public Atom(string _symbol, int _number, float _mass, int _period, int _group, int _protons, int _neutrons, int _electrons) {
			this.Symbol = _symbol;
			this.Number = _number;
			this.Mass = _period;

			this.Period = _period;
			this.Group = _group;

			this.Protons = _protons;
			this.Neutrons = _neutrons;
			this.Eletrons = _electrons;

			this.electron_shells = _period;

			if (electron_shells == 1) {
				this.valence_electrons = _electrons;
			} else {
				var mod = (int)Math.Floor((_electrons - 2)/8f);
				var _mod = Math.Abs((_electrons-2)-((electron_shells-1)*8));
				this.valence_electrons = _electrons-(8*mod);
			}
		}
	}
}
