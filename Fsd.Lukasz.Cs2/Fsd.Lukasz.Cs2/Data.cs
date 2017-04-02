using Fsd.Lukasz.Cs2.Models;
using System.Collections.Generic;

namespace Fsd.Lukasz.Cs2
{
    public class Data
    {
        public IList<IAnimal> Farm { get; set; }

        public Data()
        {
            Farm = new List<IAnimal>();
        }
    }
}
