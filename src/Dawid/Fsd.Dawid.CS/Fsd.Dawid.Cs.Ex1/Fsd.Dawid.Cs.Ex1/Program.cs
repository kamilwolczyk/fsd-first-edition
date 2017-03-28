using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Dawid.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excercise 1 - Introduction");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Today is " + DateTime.Now.ToString());
            Console.WriteLine();
            Console.WriteLine(args.Length == 0 ? "You didn't specify arguments :(" : "Console arguments:");
            Console.WriteLine();
            for (int i=0; i< args.Length; i++)
                ArgInfo(args[i], i+1, args.Length);
            
            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
        static void ArgInfo(string arg, int argNumer, int argsCount)
        {
            Console.WriteLine($"Argument {argNumer} of {argsCount}");
            Console.WriteLine($"Value: {arg}");
            Console.WriteLine($"Upper letters: {arg.Count(Char.IsUpper)}");
            Console.WriteLine($"Lower letters: {arg.Count(Char.IsLower)}");
            Console.WriteLine($"Digits: {arg.Count(Char.IsDigit)}");
            Console.WriteLine();
        }
    }
}
