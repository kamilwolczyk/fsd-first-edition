using System;

namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class AnimalPresenter
    {
        public string IntroduceAnimal(Animal animal)
            => $"{GetAnimalName(animal)} {GetAnimalVoice(animal as IAnimalVoice)}";
        
        private string GetAnimalVoice(IAnimalVoice voice)
            => (voice == null) ? "<no voice> \n" : $"{voice.Voice}.\n"; 
        
        private string GetAnimalName(Animal animal)
            => $"Hello my name is {animal.Name}.";
    }
}
