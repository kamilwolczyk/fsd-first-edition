using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Fsd.Slawek.Cs.Ex2.Models
{
    public abstract class Animal 
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }
    }
}
