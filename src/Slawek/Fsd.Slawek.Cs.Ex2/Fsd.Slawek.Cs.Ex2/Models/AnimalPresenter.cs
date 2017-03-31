﻿using System;

namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class AnimalPresenter
    {
        public void IntroduceAnimal(Animal animal)
        {
            GetAnimalName(animal);

            var myVoice = animal as IAnimalVoice;
            GetAnimalVoice(myVoice);
        }

        private void GetAnimalVoice(IAnimalVoice voice)
        {
            if (voice == null) Console.WriteLine("<no voice>");
            Console.WriteLine(voice.Voice); 
        }

        private void GetAnimalName(Animal animal)
        {
            Console.Write($"Hello my name is {animal.Name}. ");
        }
    }
}
