using FarmGenerator.Interfaces;
using System;

namespace FarmGenerator.Models
{
    public class Cow : Animal, IVoice
    {
        public Cow(string name)
            : base(name)
        {
        }

        public string IGiveVoice()
        {
            return $"{Name} : Muuu";
        }
    }
}
