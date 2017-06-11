using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemAtoms {
	internal class AtomData {
		private Dictionary<string, Tuple< string, int, float, int, int>> data = new Dictionary<string, Tuple<string, int, float, int, int>>();
		public AtomData() {
			// Symbol, <Name, Number, Mass, Period, Group>
			data.Add("H", new Tuple<string, int, float, int, int>("Hydrogen", 1, 1.01f, 1, 1));
			data.Add("He", new Tuple<string, int, float, int, int>("Helium", 2, 4f, 1, 18));
			data.Add("Li", new Tuple<string, int, float, int, int>("Lithium", 0, 0f, 0, 0));
			data.Add("Be", new Tuple<string, int, float, int, int>("Beryllium", 0, 0f, 0, 0));
			data.Add("B", new Tuple<string, int, float, int, int>("Boron", 0, 0f, 0, 0));
			data.Add("C", new Tuple<string, int, float, int, int>("Carbon", 0, 0f, 0, 0));
			data.Add("N", new Tuple<string, int, float, int, int>("Nitrogen", 0, 0f, 0, 0));
			data.Add("O", new Tuple<string, int, float, int, int>("Oxygen", 0, 0f, 0, 0));
			data.Add("F", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ne", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Na", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Mg", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Al", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Si", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("P", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("S", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cl", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ar", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("K", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ca", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sc", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ti", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("V", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Mn", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Fe", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Co", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ni", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cu", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Zn", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ga", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ge", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("As", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Se", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Br", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Kr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Rb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Y", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Zr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Nb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Mo", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Tc", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ru", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Rh", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ag", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cd", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("In", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sn", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Te", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("I", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Xe", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cs", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ba", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("La", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ce", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Nd", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pm", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sm", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Eu", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Gd", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Tb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Dy", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ho", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Er", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Tm", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Yb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Lu", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Hf", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ta", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("W", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Re", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Os", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ir", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pt", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Au", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Hg", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Tl", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pb", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Bi", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Po", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("At", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Rn", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Fr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ra", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Ac", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Th", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pa", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("U", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Np", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Pu", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Am", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cm", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Bk", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Cf", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Es", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Fm", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Md", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("No", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Lr", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Rf", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Db", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Sg", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Bh", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Hs", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
			data.Add("Mt", new Tuple<string, int, float, int, int>("", 0, 0f, 0, 0));
		}

		public Tuple<string, int, float, int, int> FindAtom(string _symbol) {
			return data[_symbol];
		}

	}
}
