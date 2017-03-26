using System;
using System.Linq;

namespace Fsd.Lukasz.Cs.Ex1
{

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                Console.WriteLine("Add arguments to command line.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            string current_date = DateTime.Now.ToShortDateString();

            Console.WriteLine("Exercise 1 - Introduction");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Today is {current_date}\n");
            Console.WriteLine("Console arguments:\n");

            foreach (string item in args)
            {
                Console.WriteLine($"Argument {Array.IndexOf(args, item) + 1} of {args.Count()}");
                ShowWordInfo(item);
            }

            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }

        static void ShowWordInfo(string arg)
        {
            int countlower = 0;
            int countupper = 0;
            int countdigit = 0;

            foreach (char c in arg)
            {
                if (char.IsLower(c)) countlower++;
                else if (char.IsUpper(c)) countupper++;
                else if (char.IsDigit(c)) countdigit++;
            }

            Console.WriteLine($"Value: {arg}");
            Console.WriteLine($"Upper letters: {countupper}");
            Console.WriteLine($"Lower letters: {countlower}");
            Console.WriteLine($"Digits: {countdigit}\n");
        }

    }
}
