using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2.Models
{
    public class Pig : IAnimal
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public string Voice()
        {
            return "Kwi Kwi";
        }
    }
}
