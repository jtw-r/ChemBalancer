using System;
using System.Collections.Generic;
using System.Linq;

namespace ChemAtoms {
	internal class AtomData {
		private readonly Dictionary<string, Tuple< string, int, float, int, int, int>> data = new Dictionary<string, Tuple<string, int, float, int, int, int>>();
		public AtomData() {
			// Please tell me there's an easier way to do this :\
			// Input, <Name, Number, Mass, Period, Group>
			data.Add("",   new Tuple<string, int, float, int, int, int>("Null",          0,   0f,      0,  0,  0 ));
			data.Add("H",  new Tuple<string, int, float, int, int, int>("Hydrogen",      1,   1.01f,   1,  1,  1 ));
			data.Add("He", new Tuple<string, int, float, int, int, int>("Helium",        2,   4f,      1,  18, 8 ));
			data.Add("Li", new Tuple<string, int, float, int, int, int>("Lithium",       3,   6.94f,   2,  1,  1 ));
			data.Add("Be", new Tuple<string, int, float, int, int, int>("Beryllium",     4,   9.01f,   2,  2,  2 ));
			data.Add("B",  new Tuple<string, int, float, int, int, int>("Boron",         5,   10.81f,  2,  13, 3 ));
			data.Add("C",  new Tuple<string, int, float, int, int, int>("Carbon",        6,   21.01f,  2,  14, 4 ));
			data.Add("N",  new Tuple<string, int, float, int, int, int>("Nitrogen",      7,   14.01f,  2,  15, 5 ));
			data.Add("O",  new Tuple<string, int, float, int, int, int>("Oxygen",        8,   16f,     2,  16, 6 ));
			data.Add("F",  new Tuple<string, int, float, int, int, int>("Fluorine",      9,   19f,     2,  17, 7 ));
			data.Add("Ne", new Tuple<string, int, float, int, int, int>("Neon",          10,  20.18f,  2,  18, 8 ));
			data.Add("Na", new Tuple<string, int, float, int, int, int>("Sodium",        11,  22.99f,  3,  1,  1 ));
			data.Add("Mg", new Tuple<string, int, float, int, int, int>("Magnesium",     12,  24.31f,  3,  2,  2 ));
			data.Add("Al", new Tuple<string, int, float, int, int, int>("Aluminum",      13,  26.98f,  3,  13, 3 ));
			data.Add("Si", new Tuple<string, int, float, int, int, int>("Silicon",       14,  28.09f,  3,  14, 4 ));
			data.Add("P",  new Tuple<string, int, float, int, int, int>("Phosphorus",    15,  30.97f,  3,  15, 5 ));
			data.Add("S",  new Tuple<string, int, float, int, int, int>("Sulfur",        16,  32.07f,  3,  16, 6 ));
			data.Add("Cl", new Tuple<string, int, float, int, int, int>("Chlorine",      17,  35.45f,  3,  17, 7 ));
			data.Add("Ar", new Tuple<string, int, float, int, int, int>("Argon",         18,  39.95f,  3,  18, 8 ));
			data.Add("K",  new Tuple<string, int, float, int, int, int>("Potassium",     19,  0f,      4,  1,  1 ));
			data.Add("Ca", new Tuple<string, int, float, int, int, int>("Calcium",       20,  0f,      4,  2,  2 ));
			data.Add("Sc", new Tuple<string, int, float, int, int, int>("Scandium",      21,  0f,      4,  3,  2 ));
			data.Add("Ti", new Tuple<string, int, float, int, int, int>("Titanium",      22,  0f,      4,  4,  2 ));
			data.Add("V",  new Tuple<string, int, float, int, int, int>("Vanadium",      23,  0f,      4,  5,  2 ));
			data.Add("Cr", new Tuple<string, int, float, int, int, int>("Chromium",      24,  0f,      4,  6,  1 ));
			data.Add("Mn", new Tuple<string, int, float, int, int, int>("Manganese",     25,  0f,      4,  7,  2 ));
			data.Add("Fe", new Tuple<string, int, float, int, int, int>("Iron",          26,  0f,      4,  8,  2 ));
			data.Add("Co", new Tuple<string, int, float, int, int, int>("Cobalt",        27,  0f,      4,  9,  2 ));
			data.Add("Ni", new Tuple<string, int, float, int, int, int>("Nickel",        28,  0f,      4,  10, 2 ));
			data.Add("Cu", new Tuple<string, int, float, int, int, int>("Copper",        29,  0f,      4,  11, 1 ));
			data.Add("Zn", new Tuple<string, int, float, int, int, int>("Zink",          30,  0f,      4,  12, 2 ));
			data.Add("Ga", new Tuple<string, int, float, int, int, int>("Gallium",       31,  0f,      4,  13, 3 ));
			data.Add("Ge", new Tuple<string, int, float, int, int, int>("Germanium",     32,  0f,      4,  14, 4 ));
			data.Add("As", new Tuple<string, int, float, int, int, int>("Arsenic",       33,  0f,      4,  15, 5 ));
			data.Add("Se", new Tuple<string, int, float, int, int, int>("Selenium",      34,  0f,      4,  16, 6 ));
			data.Add("Br", new Tuple<string, int, float, int, int, int>("Bromine",       35,  0f,      4,  17, 7 ));
			data.Add("Kr", new Tuple<string, int, float, int, int, int>("Krypton",       36,  0f,      4,  18, 8 ));
			data.Add("Rb", new Tuple<string, int, float, int, int, int>("Rubidium",      37,  0f,      5,  1,  1 ));
			data.Add("Sr", new Tuple<string, int, float, int, int, int>("Strontium",     38,  0f,      5,  2,  2 ));
			data.Add("Y",  new Tuple<string, int, float, int, int, int>("Yttrium",       39,  0f,      5,  3,  2 ));
			data.Add("Zr", new Tuple<string, int, float, int, int, int>("Zirconium",     40,  0f,      5,  4,  2 ));
			data.Add("Nb", new Tuple<string, int, float, int, int, int>("Niobium",       41,  0f,      5,  5,  1 ));
			data.Add("Mo", new Tuple<string, int, float, int, int, int>("Molybdenum",    42,  0f,      5,  6,  1 ));
			data.Add("Tc", new Tuple<string, int, float, int, int, int>("Technetium",    43,  0f,      5,  7,  2 ));
			data.Add("Ru", new Tuple<string, int, float, int, int, int>("Ruthenium",     44,  0f,      5,  8,  1 ));
			data.Add("Rh", new Tuple<string, int, float, int, int, int>("Rhodium",       45,  0f,      5,  9,  1 ));
			data.Add("Pd", new Tuple<string, int, float, int, int, int>("Palladium",     46,  0f,      5,  10, 0 ));
			data.Add("Ag", new Tuple<string, int, float, int, int, int>("Silver",        47,  0f,      5,  11, 1 ));
			data.Add("Cd", new Tuple<string, int, float, int, int, int>("Cadmium",       48,  0f,      5,  12, 2 ));
			data.Add("In", new Tuple<string, int, float, int, int, int>("Indium",        49,  0f,      5,  13, 3 ));
			data.Add("Sn", new Tuple<string, int, float, int, int, int>("Tin",           50,  0f,      5,  14, 4 ));
			data.Add("Sb", new Tuple<string, int, float, int, int, int>("Antimony",      51,  0f,      5,  15, 5 ));
			data.Add("Te", new Tuple<string, int, float, int, int, int>("Tellurium",     52,  0f,      5,  16, 6 ));
			data.Add("I",  new Tuple<string, int, float, int, int, int>("Iodine",        53,  0f,      5,  17, 7 ));
			data.Add("Xe", new Tuple<string, int, float, int, int, int>("Xenon",         54,  0f,      5,  18, 8 ));
			data.Add("Cs", new Tuple<string, int, float, int, int, int>("Cesium",        55,  0f,      6,  1,  1 ));
			data.Add("Ba", new Tuple<string, int, float, int, int, int>("Barlum",        56,  0f,      6,  2,  2 ));
			data.Add("La", new Tuple<string, int, float, int, int, int>("Lanthanum",     57,  0f,      6,  3,  2 ));
			data.Add("Ce", new Tuple<string, int, float, int, int, int>("Cerium",        58,  0f,      -1, -1, 0 ));
			data.Add("Pr", new Tuple<string, int, float, int, int, int>("Praseodymium",  59,  0f,      -1, -1, 0 ));
			data.Add("Nd", new Tuple<string, int, float, int, int, int>("Neodymium",     60,  0f,      -1, -1, 0 ));
			data.Add("Pm", new Tuple<string, int, float, int, int, int>("Promethium",    61,  0f,      -1, -1, 0 ));
			data.Add("Sm", new Tuple<string, int, float, int, int, int>("Samarium",      62,  0f,      -1, -1, 0 ));
			data.Add("Eu", new Tuple<string, int, float, int, int, int>("Europium",      63,  0f,      -1, -1, 0 ));
			data.Add("Gd", new Tuple<string, int, float, int, int, int>("Gadolinium",    64,  0f,      -1, -1, 0 ));
			data.Add("Tb", new Tuple<string, int, float, int, int, int>("Terbium",       65,  0f,      -1, -1, 0 ));
			data.Add("Dy", new Tuple<string, int, float, int, int, int>("Dysprosium",    66,  0f,      -1, -1, 0 ));
			data.Add("Ho", new Tuple<string, int, float, int, int, int>("Holmium",       67,  0f,      -1, -1, 0 ));
			data.Add("Er", new Tuple<string, int, float, int, int, int>("Erbium",        68,  0f,      -1, -1, 0 ));
			data.Add("Tm", new Tuple<string, int, float, int, int, int>("Thulium",       69,  0f,      -1, -1, 0 ));
			data.Add("Yb", new Tuple<string, int, float, int, int, int>("Ytterbium",     70,  0f,      -1, -1, 0 ));
			data.Add("Lu", new Tuple<string, int, float, int, int, int>("Lutetium",      71,  0f,      -1, -1, 0 ));
			data.Add("Hf", new Tuple<string, int, float, int, int, int>("Hafnium",       72,  0f,      6,  4,  2 ));
			data.Add("Ta", new Tuple<string, int, float, int, int, int>("Tantalum",      73,  0f,      6,  5,  2 ));
			data.Add("W",  new Tuple<string, int, float, int, int, int>("Tungsten",      74,  0f,      6,  6,  2 ));
			data.Add("Re", new Tuple<string, int, float, int, int, int>("Rhenium",       75,  0f,      6,  7,  2 ));
			data.Add("Os", new Tuple<string, int, float, int, int, int>("Osmium",        76,  0f,      6,  8,  2 ));
			data.Add("Ir", new Tuple<string, int, float, int, int, int>("Iridium",       77,  0f,      6,  9,  2 ));
			data.Add("Pt", new Tuple<string, int, float, int, int, int>("Platinum",      78,  0f,      6,  10, 1 ));
			data.Add("Au", new Tuple<string, int, float, int, int, int>("Gold",          79,  0f,      6,  11, 1 ));
			data.Add("Hg", new Tuple<string, int, float, int, int, int>("Mercury",       80,  0f,      6,  12, 2 ));
			data.Add("Tl", new Tuple<string, int, float, int, int, int>("Thallium",      81,  0f,      6,  13, 3 ));
			data.Add("Pb", new Tuple<string, int, float, int, int, int>("Lead",          82,  0f,      6,  14, 4 ));
			data.Add("Bi", new Tuple<string, int, float, int, int, int>("Bismuth",       83,  0f,      6,  15, 5 ));
			data.Add("Po", new Tuple<string, int, float, int, int, int>("Polonium",      84,  0f,      6,  16, 6 ));
			data.Add("At", new Tuple<string, int, float, int, int, int>("Astatine",      85,  0f,      6,  17, 7 ));
			data.Add("Rn", new Tuple<string, int, float, int, int, int>("Radon",         86,  0f,      6,  18, 8 ));
			data.Add("Fr", new Tuple<string, int, float, int, int, int>("Francium",      87,  0f,      7,  1,  1 ));
			data.Add("Ra", new Tuple<string, int, float, int, int, int>("Radium",        88,  0f,      7,  2,  2 ));
			data.Add("Ac", new Tuple<string, int, float, int, int, int>("Actinium",      89,  0f,      7,  3,  0 ));
			data.Add("Th", new Tuple<string, int, float, int, int, int>("Thorium",       90,  0f,      -1, -1, 0 ));
			data.Add("Pa", new Tuple<string, int, float, int, int, int>("Protactinium",  91,  0f,      -1, -1, 0 ));
			data.Add("U",  new Tuple<string, int, float, int, int, int>("Uranium",       92,  0f,      -1, -1, 0 ));
			data.Add("Np", new Tuple<string, int, float, int, int, int>("Neptunium",     93,  0f,      -1, -1, 0 ));
			data.Add("Pu", new Tuple<string, int, float, int, int, int>("Plutonium",     94,  0f,      -1, -1, 0 ));
			data.Add("Am", new Tuple<string, int, float, int, int, int>("Americium",     95,  0f,      -1, -1, 0 ));
			data.Add("Cm", new Tuple<string, int, float, int, int, int>("Curium",        96,  0f,      -1, -1, 0 ));
			data.Add("Bk", new Tuple<string, int, float, int, int, int>("Berkelium",     97,  0f,      -1, -1, 0 ));
			data.Add("Cf", new Tuple<string, int, float, int, int, int>("Californium",   98,  0f,      -1, -1, 0 ));
			data.Add("Es", new Tuple<string, int, float, int, int, int>("Einsteinium",   99,  0f,      -1, -1, 0 ));
			data.Add("Fm", new Tuple<string, int, float, int, int, int>("Fermium",       100, 0f,      -1, -1, 0 ));
			data.Add("Md", new Tuple<string, int, float, int, int, int>("Mendelevium",   101, 0f,      -1, -1, 0 ));
			data.Add("No", new Tuple<string, int, float, int, int, int>("Nobelium",      102, 0f,      -1, -1, 0 ));
			data.Add("Lr", new Tuple<string, int, float, int, int, int>("Lawrencium",    103, 0f,      -1, -1, 0 ));
			data.Add("Rf", new Tuple<string, int, float, int, int, int>("Rutherfordium", 104, 261f,    7,  4,  2 ));
			data.Add("Db", new Tuple<string, int, float, int, int, int>("Dubnium",       105, 262f,    7,  5,  2 ));
			data.Add("Sg", new Tuple<string, int, float, int, int, int>("Seaborgium",    106, 266f,    7,  6,  2 ));
			data.Add("Bh", new Tuple<string, int, float, int, int, int>("Bohrium",       107, 264f,    7,  7,  2 ));
			data.Add("Hs", new Tuple<string, int, float, int, int, int>("Hassium",       108, 269f,    7,  8,  2 ));
			data.Add("Mt", new Tuple<string, int, float, int, int, int>("Meitnerium",    109, 268f,    7,  9,  2 ));
		}

		public Tuple<string, int, float, int, int, int> FindAtomBySymbol(string _symbol) {
			return data[_symbol];
		}

		public KeyValuePair<string, Tuple<string, int, float, int, int, int>> FindAtomByName(string _name) {
			for (int i = 0; i < data.ToArray().Length; i++) {
				if (data.ToArray()[i].Value.Item1 != _name) continue;
				return data.ToArray()[i];
			}
			return new KeyValuePair<string,Tuple<string, int, float, int, int, int>>(data.ToArray().FirstOrDefault().Key,data.ToArray().FirstOrDefault().Value);
		}

	}
}
