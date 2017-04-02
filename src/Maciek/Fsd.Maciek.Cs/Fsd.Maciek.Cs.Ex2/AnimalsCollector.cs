using System;
using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex2.Models;

namespace Fsd.Maciek.Cs.Ex2
{
    public class AnimalsCollector
    {
        public List<Animal> Animals { get; private set; }

        public AnimalsCollector()
        {
            Animals = new List<Animal>();
        }

        public void DefineOneOfAnimalType<Tparameter>(string singularAnimalName, string pluralAnimalName)
            where Tparameter : Animal
        {
            Presenter.AskForNumberOfAnimals(pluralAnimalName);
            int numberOfAnimals = Presenter.GetNumberOfAnimals();

            for (int i = 0; i < numberOfAnimals; i++)
            {
                Presenter.AskForNameOfAnimal(singularAnimalName);
                string AnimalName = Presenter.GetNameOfAnimal();
                Tparameter cat = (Tparameter)Activator.CreateInstance(typeof(Tparameter), AnimalName);
                Animals.Add(cat);
            }
        }
    }
}
