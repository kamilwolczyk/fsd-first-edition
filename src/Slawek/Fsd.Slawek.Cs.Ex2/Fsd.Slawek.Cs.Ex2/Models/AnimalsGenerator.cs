using System;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class AnimalsGenerator
    {
        string[] kindsOfAnimals = new string[] { "cat", "dog", "horse", "cow" };
        UserService userService = new UserService();
        
        public IEnumerable<Animal> GetAllAnimals()
        {
            List<Animal> list = new List<Animal>();
            foreach (var kind in creatorFactory.Keys)
            {
                int count = userService.GetNumber(kind);
                list.AddRange(GetAnimals(count, kind));
            }
            
            return list;
        }

        public IEnumerable<Animal> GetAnimals(int numberOfAnimals, string type)
        {
            List<Animal> list = new List<Animal>();
            
            for (int i = 0; i < numberOfAnimals; i++)
            {
                var name = userService.GetName(type,i+1);
                list.Add(creatorFactory[type].Invoke(name));
            }
            return list;
        }

        Dictionary<string, Func<string,Animal>> creatorFactory = new Dictionary<string, Func<string, Animal>>
        {
            {"cat", (t) => new Cat(t)},
            {"dog", (t) => new Dog(t)},
            {"horse", (t) => new Horse(t)},
            {"cow", (t) => new Cow(t)}
        };
    }
}
