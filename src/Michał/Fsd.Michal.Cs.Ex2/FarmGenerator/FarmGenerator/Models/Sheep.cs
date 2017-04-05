using System;

namespace FarmGenerator.Models
{
    public class Sheep : Animal, IVoice
    {
        public Sheep(string name) 
            : base(name)
        {
        }

        public void IGiveVoice()
        {
            Console.WriteLine($"{Name} : Beee");
        }
    }
}
