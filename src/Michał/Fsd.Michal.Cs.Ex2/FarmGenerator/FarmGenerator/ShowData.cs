using FarmGenerator.Models;
using System;
using System.Collections.Generic;

namespace FarmGenerator.Interfaces
{
    class ShowData
    {
        public static void ShowAnimals(List<Animal> animalList)
        {
            foreach (Animal animal in animalList)
            {
                Console.WriteLine( $"{animal.SayHello()}, {animal.GiveSound()}");
            }
        }

        public static void ShowIntroduction()
        {
            Console.WriteLine("Exercise 2 -Interfaces\n---------------------------------------------");
        }
    }
}
