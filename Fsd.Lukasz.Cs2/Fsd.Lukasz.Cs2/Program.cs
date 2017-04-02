using Fsd.Lukasz.Cs2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory Factory = new AnimalFactory();
            Data Farm = new Data();

            Presenter.Intro();
            foreach (AnimalType AnimalType in Enum.GetValues(typeof(AnimalType)))
            {
                Presenter.EmptyLine();
                int NumberOfAnimals = Presenter.InsertNumberOfAnimal(AnimalType);
                for (int i = 0; i < NumberOfAnimals; i++)
                {

                    IAnimal Animal = Factory.CreateAnimal(AnimalType);
                    Animal.Name = Presenter.GetNameForAnimal(Animal);
                    Farm.Farm.Add(Animal);
                }
            }
            Presenter.EmptyLine();
            Presenter.ShowAnimals(Farm.Farm);

            Console.ReadKey();
        }
    }
}
