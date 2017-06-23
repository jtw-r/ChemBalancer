using System;

namespace ChemConsole {
	public static class ConsoleFunctions {

		public static void WriteLine(string _input = "", ConsoleColor _color = ConsoleColor.Gray, bool _insert_start = true) {
			Console.ForegroundColor = _color;
			if (!_insert_start) Console.WriteLine(_input);
			else Console.WriteLine("> " + _input);
		}

		public static void WriteLines(string[] _input, bool _insert_start = true, ConsoleColor[] _color = null) {
			for (int i = 0; i < _input.Length; i++) {
				if (_color == null) Console.ForegroundColor = ConsoleColor.Gray;
				else {
					if (_color.Length >= i + 1) {
						Console.ForegroundColor = _color[i];
					} else if (_color.Length == 1) {
						Console.ForegroundColor = _color[0];
					}
				}

				if (_insert_start) Console.WriteLine("> " + _input[i]);
				else Console.WriteLine(_input[i]);
			}
		}

		public static string ReadLine() {
			Console.ForegroundColor = ConsoleColor.White;
			return Console.ReadLine();
		}

		public static bool ThrowError(string _prompt, string _question = "") {
			WriteLine(_prompt, ConsoleColor.Red, false);
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
