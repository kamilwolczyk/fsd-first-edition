using System;

namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class AnimalPresenter
    {
        public string IntroduceAnimal(Animal animal)
        {
            return (GetAnimalName(animal) + GetAnimalVoice(animal as IAnimalVoice));
        }

        private string GetAnimalVoice(IAnimalVoice voice)
        {
            if (voice == null)
                return "<no voice> \n";

            return $"{voice.Voice}.\n"; 
        }

        private string GetAnimalName(Animal animal)
        {
            return $"Hello my name is {animal.Name}. ";
        }
    }
}
