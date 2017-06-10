using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemBalancer {
	class Element {

		public string Atom { private set; get; }
		public int base_count { get; }
		public int Count { private set; get; }

		public Element(string _atom, int _count) {
			this.Atom = Regex.Replace(_atom,"([0-9]+^)","");
			this.base_count = _count;
			this.Count = _count;
		}

		public void ReUp(int times) {
			this.Count += times * base_count;
		}

	}
}
