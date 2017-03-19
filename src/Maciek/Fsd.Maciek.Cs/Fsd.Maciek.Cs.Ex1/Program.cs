using System;

namespace Fsd.Maciek.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int argsCount = 0;
            int lowerCaseCount = 0;
            int upperCaseCount = 0;
            int digitsCount = 0;
            string information = args.Length > 0 ? "Console arguments:\n" : "Oops, there are no arguments.\n";

            Console.WriteLine($"Excercise 1 - Introduction\n------------------------------------------------\nToday is {DateTime.Now.ToString("yyyy-MM-dd")} \n");
            Console.WriteLine(information);
                        
            foreach (var arg in args)
            {
                argsCount += 1;
                Console.WriteLine($"Argument {argsCount} of {args.Length}");
                Console.WriteLine($"Value: {arg}");

                for (int i = 0; i < arg.Length; i++)
                {
                    if (char.IsLower(arg[i]))
                        lowerCaseCount++;
                    else
                        if (char.IsUpper(arg[i]))
                            upperCaseCount++;
                        else
                            if (char.IsDigit(arg[i]))
                                digitsCount++;
                }

                Console.WriteLine($"Upper letters: {upperCaseCount}");
                Console.WriteLine($"Lower letters: {lowerCaseCount}");
                Console.WriteLine($"Digits: {digitsCount}\n");
            }

            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
    }
}
