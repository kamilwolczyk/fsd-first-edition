using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Slawek.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine($"Today is {DateTime.UtcNow}");
            Console.WriteLine("-----Ex-1----");
            Console.WriteLine();

            if (args.Length == 0) Console.WriteLine("--- Nothing to do ;-) ---");

            LoopWrite(args);

            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }

        static void Counter(string arg)
        {
            Console.WriteLine($"Value = {arg}");
            Console.WriteLine($"Lower letters: {arg.CountLower()} - {arg.GetLower()}");
            Console.WriteLine($"Upper letters: {arg.CountUpper()} - {arg.GetUpper()}");
            Console.WriteLine($"Digits       : {arg.CountDigit()} - {arg.GetDigit()}");
        }

        static void LoopWrite(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Argument {i + 1} of {args.Length}");
                Counter(args[i]);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
