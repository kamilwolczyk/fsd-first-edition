using FarmGenerator.Interfaces;
using System;

namespace FarmGenerator.Models
{
    public class Sheep : Animal, IVoice
    {
        public Sheep(string name) 
            : base(name)
        {
        }
       
        public string IGiveVoice()
        {
            return $"{Name} : Beee";
        }
    }
}
