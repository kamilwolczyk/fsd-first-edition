using System;

namespace FarmGenerator.Models
{
    class Dog : Animal , IVoice
    {
        public Dog(string name)
            : base(name)
        {
        }

        public void IGiveVoice()
        {
            Console.WriteLine($"{Name} : hau hau");
        }
    }
}
