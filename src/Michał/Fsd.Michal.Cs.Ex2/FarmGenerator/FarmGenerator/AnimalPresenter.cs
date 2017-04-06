using FarmGenerator.Interfaces;
using System.Collections.Generic;
using System;

namespace FarmGenerator
{
    class AnimalPresenter
    {
        public static void AnimalsGiveVoice(List<IVoice> animals)
        {
            foreach (IVoice animal in animals)
                Console.WriteLine(animal.IGiveVoice());
        }
    }
}
