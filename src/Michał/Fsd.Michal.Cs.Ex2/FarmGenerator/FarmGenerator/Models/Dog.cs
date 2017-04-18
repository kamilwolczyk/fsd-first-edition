using FarmGenerator.Interfaces;
using System;

namespace FarmGenerator.Models
{
    class Dog : Animal , IVoice
    {
        public Dog(string name)
            : base(name)
        {
        }

        public string IGiveVoice()
        {
            return $"{Name} : hau hau";
        }
    }
}
