using System;

namespace FarmGenerator.Models
{
    class Cat : Animal, IVoice
    {
        public Cat(string name)
            : base(name)
        {
        }

        public void IGiveVoice()
        {
            Console.WriteLine($"{Name} : Miał");
        }
    }
}
