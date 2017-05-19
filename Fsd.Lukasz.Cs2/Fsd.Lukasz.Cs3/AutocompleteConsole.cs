using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3
{
    class AutocompleteConsole
    {
        public bool oneMatch = false;
        public string input = string.Empty;
        public List<string> dictionary = new List<string>();
        public List<string> suggestions = new List<string>();

        public AutocompleteConsole(List<string> dictionary, ref string returnValue)
        {
            ConsoleKeyInfo interceptKey;
            int BeginningTop = int.MinValue;
            int BeginningRow = int.MinValue;
            BeginningRow = Console.CursorLeft;
            BeginningTop = Console.CursorTop;

            this.dictionary = dictionary;

            while (true)
            {
                interceptKey = Console.ReadKey(true);
                if (interceptKey.Key == ConsoleKey.Delete)
                {
                    Console.SetCursorPosition(BeginningRow, BeginningTop);
                    ClearCurrentLine();
                    ClearSuggestions();
                    input = string.Empty;
                }
                else if ((interceptKey.Key == ConsoleKey.Backspace) && (input.Count() > 0))
                {
                    input = input.Remove(input.Length - 1, 1);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

                    SearchSuggestions();
                    ClearSuggestions();
                    WriteSuggestions();
                    ClearCurrentLine();
                }
                else if ((char.IsLetterOrDigit(interceptKey.KeyChar) || (interceptKey.Key == ConsoleKey.Spacebar)) && !oneMatch)
                {
                    input += interceptKey.KeyChar.ToString();
                    Console.Write(interceptKey.KeyChar.ToString());

                    SearchSuggestions();
                    ClearSuggestions();
                    WriteSuggestions();

                    if (suggestions.Count == 1)
                    {
                        Console.SetCursorPosition(BeginningRow, BeginningTop);
                        ClearCurrentLine();
                        Console.Write(suggestions.FirstOrDefault());
                        input = suggestions.FirstOrDefault();
                        oneMatch = true;
                    }

                }
                else if ((interceptKey.Key == ConsoleKey.Enter))
                {
                    ClearSuggestions();
                    if (IsInSuggestions(input))
                    {
                        Console.WriteLine();
                        returnValue = input;
                        break;
                    }
                }
            }

        }

        private bool IsInSuggestions(string valueToCheck)
        {

            if (dictionary.Count(x => x == valueToCheck) == 1)
            {
                return true;
            }
            return false;
        }

        private void ClearSuggestions()
        {
            using (new CursorPositionKeeper())
            {
                for (var top = Console.CursorTop + 1; top < Console.WindowHeight; top++)
                {
                    //Debug.WriteLine($"top: {top}");
                    Console.SetCursorPosition(0, top);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
            }
        }

        private void ClearCurrentLine()
        {
            using (new CursorPositionKeeper())
            {
                Console.Write(new string(' ', Console.WindowWidth - Console.CursorLeft));
            }
        }

        private void SearchSuggestions()
        {
            suggestions = dictionary.FindAll(x => x.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0);
            if (suggestions.Count > 1)
            {
                oneMatch = false;
            }
        }

        private void WriteSuggestions()
        {
            if (suggestions.Count > 1)
            {
                using (new CursorPositionKeeper())
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (string item in suggestions)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.ResetColor();
                }
            }
        }


    }
}
