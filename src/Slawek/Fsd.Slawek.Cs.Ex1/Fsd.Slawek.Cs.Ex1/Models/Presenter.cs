using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Slawek.Cs.Ex1.Models
{
    public class Presenter
    {
        public void ShowArguments(string[] args)
        {
            ShowTitle();

            if (args.Length == 0) Console.WriteLine("--- Nothing to do ;-) ---");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Argument {i + 1} of {args.Length}");
                ShowCounter(args[i]);
                Console.WriteLine("---------------------------------");
            }

            WaitForUser();
        }

        private void ShowTitle()
        {
            Console.Clear();
            Console.WriteLine($"Today is {DateTime.UtcNow}");
            Console.WriteLine("-----Ex-1----");
            Console.WriteLine();
        }

        private void ShowCounter(string arg)
        {
            Console.WriteLine($"Value = {arg}");
            Console.WriteLine($"Lower letters: {arg.CountLower()} - {arg.GetLower()}");
            Console.WriteLine($"Upper letters: {arg.CountUpper()} - {arg.GetUpper()}");
            Console.WriteLine($"Digits       : {arg.CountDigit()} - {arg.GetDigit()}");
        }

        private void WaitForUser()
        {
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
    }
}
