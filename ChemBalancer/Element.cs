using System.Text.RegularExpressions;

namespace ChemBalancer {
	class Element {

		public string Atom { get; }
		public int BaseCount { get; }
		public int Count { private set; get; }

		public Element(string _atom, int _count) {
			Atom = Regex.Replace(_atom,"([0-9]+^)","");
			BaseCount = _count;
			Count = _count;
		}

		public void ReUp(int _times) {
			Count += _times * BaseCount;
		}

	}
}
