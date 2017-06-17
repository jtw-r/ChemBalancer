using System;
using System.Linq;

namespace ChemConsole {
	public class ColourFormatConsole {
		public void WriteLine(string _input = "", ConsoleColor _color = ConsoleColor.Gray, bool _insert_start = true) {
			Console.ForegroundColor = _color;
			if (!_insert_start) Console.WriteLine(_input);
			else Console.WriteLine("> " + _input);
		}

		public void WriteLines(string[] _input, bool _insert_start = true) {
			Console.ForegroundColor = ConsoleColor.Gray;
			_input.ToList().ForEach(_item => {
				if (_insert_start) Console.WriteLine("> " + _item);
				else Console.WriteLine(_item);
			});
		}

		public string ReadLine() {
			Console.ForegroundColor = ConsoleColor.White;
			return Console.ReadLine();
		}
	}
}
