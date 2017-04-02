using Fsd.Lukasz.Cs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2
{
    public class Presenter
    {
        public static void Intro()
        {
            Console.WriteLine("Ecercise 2 - Interface");
            Console.WriteLine(new string('-', 60));
        }

        public static int InsertNumberOfAnimal(AnimalType animal)
        {
            string ConsoleInput;
            int ConsoleInputAsInteger = int.MinValue;

            do
            {
                Console.Write($"Insert number of {animal.ToString()}s: ");
                ConsoleInput = Console.ReadLine().ToString();

            } while (!((int.TryParse(ConsoleInput, out ConsoleInputAsInteger)) & (ConsoleInputAsInteger >= 0)));

            return ConsoleInputAsInteger;
        }

        public static string GetNameForAnimal(IAnimal animal)
        {
            //Console.Write($"{animal.GetType().ToString().Split('.').LastOrDefault()} name: ");
            Console.Write($"{animal.AnimalType} name: ");
            String Name = Console.ReadLine();
            return Name;
        }

        public static void ShowAnimals(IList<IAnimal> animals)
        {
            foreach (var Animal in animals)
            {
                Console.WriteLine($"Hello, my name is {Animal.Name.ToString()}, {Animal.Voice().ToString()}");
            }
        }

        public static void EmptyLine()
        {
            Console.WriteLine();
        }
    }
}
