using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2.Models
{
    public class AnimalFactory
    {
        public IAnimal CreateAnimal(AnimalType animal)
        {
            switch (animal)
            {
                case AnimalType.Cat:
                    return new Cat() { AnimalType = animal.ToString() };
                case AnimalType.Cow:
                    return new Cow() { AnimalType = animal.ToString() };
                case AnimalType.Dog:
                    return new Dog() { AnimalType = animal.ToString() };
                case AnimalType.Pig:
                    return new Pig() { AnimalType = animal.ToString() };
                default:
                    return new Cat() { AnimalType = animal.ToString() };
            }
        }
    }
}
