using FarmGenerator.Models;
using System;
using System.Collections.Generic;

namespace FarmGenerator.Interfaces
{
    public class AnimalCreator
    {
        public static List<IVoice> ZooCreator()
        {
            List<IVoice> animals = new List<IVoice>();

            animals.AddRange(AnimalGenerator<Cow>("", "cows"));
            animals.AddRange(AnimalGenerator<Dog>("", "dogs"));
            animals.AddRange(AnimalGenerator<Cat>("", "cats"));
            animals.AddRange(AnimalGenerator<Sheep>("", "sheeps"));

            return animals;
        }

        private static List<IVoice> AnimalGenerator<TAnimal>(string animalName, string species) where TAnimal : IVoice
        {
            List<IVoice> animals = new List<IVoice>();

            Console.Write($"\nInsert number of {species}: ");

            try
            {
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < input; i++)
                {
                    Console.Write($"{species} name:");
                    animalName = Console.ReadLine();
                    animals.Add((TAnimal)Activator.CreateInstance(typeof(TAnimal), animalName));
                }
            }
            catch (SystemException exception)
            {
                Console.WriteLine("count must be integer value");
            }
            return animals;
        }
    }
}
