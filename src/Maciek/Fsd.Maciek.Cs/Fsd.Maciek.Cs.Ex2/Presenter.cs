using System;
using Fsd.Maciek.Cs.Ex2.Models;
using System.Collections.Generic;

namespace Fsd.Maciek.Cs.Ex2
{
    public static class Presenter
    {
        public static void RenderHeader()
        {
            Console.WriteLine($"Exercise 2 - Interfaces\n---------------------------------------------");
        }

        public static void IntroduceAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Hello! My name is {animal.Name}, {animal.Sound}.");
            }
        }

        public static void AskForNumberOfAnimals(string pluralSpeciesName)
        {
            Console.Write($"Insert number of {pluralSpeciesName}: ");
        }

        public static void AskForNameOfAnimal(string singularSpeciesName)
        {
            Console.Write($"{singularSpeciesName} name: ");
        }

        public static int GetNumberOfAnimals()
        {
            try
            {
                int numberOfAnimals = int.Parse(Console.ReadLine());
                return numberOfAnimals;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong value. It cannot be parsed to integer.");
                return 0;
            }

        }

        public static string GetNameOfAnimal()
        {
            return Console.ReadLine();
        }

        public static void WaitForUser()
        {
            Console.ReadLine();
        }
    }
}