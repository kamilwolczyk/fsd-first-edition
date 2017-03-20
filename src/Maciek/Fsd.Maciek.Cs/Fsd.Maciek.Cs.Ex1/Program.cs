using System;

namespace Fsd.Maciek.Cs.Ex1
{
    class Program
    {
        private static void RenderHeader(bool isArgumentExists)
        {
            string information = isArgumentExists ? "Console arguments:\n" : "Oops, there are no arguments.\n";
            Console.WriteLine($"Excercise 1 - Introduction\n------------------------------------------------\nToday is {DateTime.Now.ToString("yyyy-MM-dd")} \n");
            Console.WriteLine(information);
        }

        static void Main(string[] args)
        {       
            RenderHeader(args.Length>0);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i+1} of {args.Length}");
                Console.WriteLine($"Value: {args[i]}");
                Console.WriteLine($"Upper letters: {WordStatistics.CalculateUpperCasesInWord(args[i])}");
                Console.WriteLine($"Lower letters: {WordStatistics.CalculateLowerCasesInWord(args[i])}");
                Console.WriteLine($"Digits: {WordStatistics.CalculateDigitsInWord(args[i])}\n");
            }

            Console.WriteLine("Click any key to continue...");
            Console.ReadKey();
        }
    }
}
