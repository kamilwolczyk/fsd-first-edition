using FarmGenerator.Models;
using System;
using System.Collections.Generic;

namespace FarmGenerator.Interfaces
{
    class AnimalPresenter
    {
        public static void AnimalsGiveVoice(List<IVoice> animals)
        {
            foreach (IVoice animal in animals)
            {
                animal.IGiveVoice();
            }
        }
    }
}
