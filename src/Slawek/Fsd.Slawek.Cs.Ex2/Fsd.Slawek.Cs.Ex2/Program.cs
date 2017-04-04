using Fsd.Slawek.Cs.Ex2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Slawek.Cs.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalsGenerator animalGenerator = new AnimalsGenerator();
            AnimalPresenter animalPresenter = new AnimalPresenter();

            IEnumerable<Animal> animals = animalGenerator.GetAllAnimals();
            animals.ToList().ForEach(a => animalPresenter.IntroduceAnimal(a));
            
            Console.ReadKey();
        }
    }
}
