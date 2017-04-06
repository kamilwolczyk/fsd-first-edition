using FarmGenerator.Interfaces;
using System;

namespace FarmGenerator.Models
{
    class Cat : Animal, IVoice
    {
        public Cat(string name)
            : base(name)
        {
        }

        public string IGiveVoice()
        {
            return$"{Name} : Miał";
        }
    }
}
