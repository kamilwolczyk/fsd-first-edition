using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs2.Models
{
    public interface IAnimal
    {
        string Name { get; set; }
        string AnimalType { get; set; }
        string Voice();
    }
}
