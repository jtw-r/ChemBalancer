using System;
using System.Windows.Forms;

namespace ChemAtoms {
	public partial class AtomView : Form {
		public AtomView() {
			InitializeComponent();
			Atom atom = null;
			Console.WriteLine("> Method (SYmbol, NAme)");
			Console.ForegroundColor = ConsoleColor.White;
			string read_line = Console.ReadLine();
			Console.ForegroundColor = ConsoleColor.Gray;
			if (read_line != null) {
				string input = read_line.ToLower();
				switch (input) {
					default:
						Console.WriteLine("> Symbol:");
						Console.ForegroundColor = ConsoleColor.White;
						atom = new Atom(Console.ReadLine());
						break;
					case "na":
						Console.WriteLine("> Name:");
						Console.ForegroundColor = ConsoleColor.White;
						atom = new Atom(Console.ReadLine(), Atom.SearchType.Name);
						break;
				}
			}

			Console.ForegroundColor = ConsoleColor.Gray;
			if (atom == null) {
				Close();
				return;
			}

			lb_atomSymbol.Text = atom.Symbol;
			lb_atomName.Text = atom.Name;
			lb_atomNumber.Text = atom.Number + "";
			lb_atomMass.Text = atom.Mass + "";

			switch (atom.Group) {
				case -1:
					lb_atomPosition.Text = "(F-Block)";
					break;
				case 0:
					lb_atomPosition.Text = "(Null)";
					break;
				default:
					lb_atomPosition.Text = "(" + atom.Group + "," + atom.Period + ")";
					break;
			}

			lb_atomProtons.Text = atom.Protons + "";
			lb_atomNeutrons.Text = atom.Neutrons + "";
			lb_atomElectrons.Text = atom.Eletrons + "";
			lb_atomShells.Text = atom.ElectronShells + "";
			lb_atomValence.Text = atom.ValenceElectrons + "";
		}
	}
}
