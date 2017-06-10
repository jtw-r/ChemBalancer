using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Possible read from datafile. .json?
// Atom.cs calls a look up form:
// new Atom( string _prefex) {
//		LookUp(_prefex)
// }

namespace ChemAtoms {
	class Table {
		public void Load() {
			var Atoms = new List<Atom> {
				new Atom("H","Hydrogen",1,1.01f,1,1),
				new Atom("He","Helium",2,4f,1,18),
				new Atom("Li","Lithium",3,6.94f,2,1),
				new Atom("","",4,0f,0,0),
				new Atom("","",5,0f,0,0),
				new Atom("","",6,0f,0,0),
				new Atom("","",7,0f,0,0),
				new Atom("","",8,0f,0,0),
				new Atom("","",9,0f,0,0),
				new Atom("","",10,0f,0,0),
				new Atom("","",11,0f,0,0),
				new Atom("","",12,0f,0,0),
				new Atom("","",13,0f,0,0),
				new Atom("","",14,0f,0,0),
				new Atom("","",15,0f,0,0),
				new Atom("","",16,0f,0,0),
				new Atom("","",17,0f,0,0),
				new Atom("","",18,0f,0,0),
				new Atom("","",19,0f,0,0),
				new Atom("","",20,0f,0,0),
				new Atom("","",21,0f,0,0),
				new Atom("","",22,0f,0,0),
				new Atom("","",23,0f,0,0),
				new Atom("","",24,0f,0,0),
				new Atom("","",25,0f,0,0),
				new Atom("","",26,0f,0,0),
				new Atom("","",27,0f,0,0),
				new Atom("","",28,0f,0,0),
				new Atom("","",29,0f,0,0),
				new Atom("","",30,0f,0,0),
				new Atom("","",31,0f,0,0),
				new Atom("","",32,0f,0,0),
				new Atom("","",33,0f,0,0),
				new Atom("","",34,0f,0,0),
				new Atom("","",35,0f,0,0),
				new Atom("","",36,0f,0,0),
				new Atom("","",37,0f,0,0),
				new Atom("","",38,0f,0,0),
				new Atom("","",39,0f,0,0),
				new Atom("","",40,0f,0,0)
			};
		}
	}
}
