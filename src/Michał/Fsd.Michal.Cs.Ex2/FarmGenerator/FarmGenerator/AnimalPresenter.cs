using FarmGenerator.Interfaces;
using System.Collections.Generic;

namespace FarmGenerator
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
