﻿using System;

namespace Fsd.Michal.Cs.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Argument { i + 1}  of {args.Length}");
                    Console.WriteLine($"Value : {args[i]}");
                    Console.WriteLine($"Upper letters: {WordAnalyzer.CountUpperLetters(args[i])}");
                    Console.WriteLine($"Lower letters: {WordAnalyzer.CountLowerLetter(args[i])}");
                    Console.WriteLine($"Digits: {WordAnalyzer.CountDigits(args[i])}\n");
                }
            }
            else
            {
                Console.WriteLine("You didn't specify any arguments! Please specify at least one argument.");
            }

            Footer();
        }
        
        static void Header()
        {
            Console.WriteLine("Exercise 1 - Introduction");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"Today is {DateTime.Now.ToShortDateString()}\n");
            Console.WriteLine("Console arguments:\n");
        }

        static void Footer()
        {
            Console.WriteLine("\nClick any key to continue...");
            Console.ReadKey();
        }
    }
}
