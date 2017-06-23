using System.Text.RegularExpressions;
using ChemAtoms;

namespace ChemBalancer {
	internal class Element {

		public Atom Atom { get; }
		public int BaseCount { get; }
		public int Count { private set; get; }

		public Element(string _atom, int _count, bool _polyatomic = false) {
			Atom = _polyatomic
				? new Atom(Regex.Replace(_atom, "([0-9]+^)", ""), Atom.SearchType.Polyatomic)
				: new Atom(Regex.Replace(_atom, "([0-9]+^)", ""));
			BaseCount = _count;
			Count = _count;
		}

		public void ReUp(int _times) {
			Count += _times * BaseCount;
		}

	}
}
