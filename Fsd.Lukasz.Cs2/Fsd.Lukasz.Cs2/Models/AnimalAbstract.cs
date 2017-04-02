using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2.Models
{
    public abstract class AnimalAbstract
    {
        public string Type { get; private set; }

        public AnimalAbstract(string AnimalType)
        {
            Type = AnimalType;
        }
    }
}
