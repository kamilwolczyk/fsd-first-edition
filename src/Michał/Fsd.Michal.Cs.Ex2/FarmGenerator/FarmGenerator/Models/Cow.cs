using System;

namespace FarmGenerator.Models
{
    public class Cow : Animal, IVoice
    {
        public Cow(string name)
            : base(name)
        {
        }

        public void IGiveVoice()
        {
            Console.WriteLine($"{Name} : Muuu");
        }
    }
}
