using System;
using System.Collections.Generic;
using System.Linq;

namespace ChemConsole {
	public static class ConsoleFunctions {

		public static void WriteLine(string _input = "", ConsoleColor _color = ConsoleColor.Gray, bool _insert_start = true) {
			Console.ForegroundColor = _color;
			if (!_insert_start) Console.WriteLine(_input);
			else Console.WriteLine("> " + _input);
		}

		public static void WriteLines(IEnumerable<string> _input, bool _insert_start = true) {
			Console.ForegroundColor = ConsoleColor.Gray;
			_input.ToList().ForEach(_item => {
				if (_insert_start) Console.WriteLine("> " + _item);
				else Console.WriteLine(_item);
			});
		}

		public static string ReadLine() {
			Console.ForegroundColor = ConsoleColor.White;
			return Console.ReadLine();
		}

		public static bool ThrowError(string _prompt, string _question = "") {
			WriteLine(_prompt, ConsoleColor.Red);
			switch (_question) {
				case null:
					return false;
				case "":
					_question = "Restart? Y/N";
					break;
			}

			while (true) {
				WriteLine(_question);
				string read_line = ReadLine();
				if (read_line == null) continue;
				string input = read_line.ToLower();
				return input != "y";
			}
		}
	}
}
