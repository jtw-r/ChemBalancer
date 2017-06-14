using System;

namespace ChemAtoms{
	public class Atom {

		public enum SearchType {
			Name,
			Symbol
		};

		public string Symbol { get; }
		public string Name { get; }

		public int Number { get; }
		public float Mass { get; }

		public int Period; // X-axis
		public int Group; // Y-axis

		public int Protons { get; }
		public int Neutrons { get; }
		public int Eletrons { get; }

		public int ElectronShells;
		public int ValenceElectrons;

		public Atom(string _input, SearchType _search_type = SearchType.Symbol) {
			Tuple<string, int, float, int, int, int> data;

			switch (_search_type) {
				case SearchType.Name:
					var source = new AtomData().FindAtomByName(_input);
					data = source.Value;
					Symbol = source.Key;
					break;
				case SearchType.Symbol:
					data = new AtomData().FindAtomBySymbol(_input);
					Symbol = _input;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(_search_type), _search_type, null);
			}

			if (data == null) return;
			Name = data.Item1;

			Number = data.Item2;
			Mass = data.Item3;

			Period = data.Item4;
			Group = data.Item5;

			Protons = data.Item2;
			Neutrons = (int) data.Item3;
			Eletrons = data.Item2;

			ElectronShells = data.Item4;
			ValenceElectrons = data.Item6;
		}
		
	}
}
