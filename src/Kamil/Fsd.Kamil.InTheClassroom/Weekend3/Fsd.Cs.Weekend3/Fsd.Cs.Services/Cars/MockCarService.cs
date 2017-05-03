using System.Collections.Generic;
using Fsd.Cs.Data.Entities;

namespace Fsd.Cs.Services.Cars
{
    public class MockCarService : ICarService
    {
        private IEnumerable<Car> sampleData = new List<Car>
        {
            new Car { Brand= "Audi", Model="A4", Power=130, Price=119000},
            new Car { Brand= "BMW", Model="3", Power=150, Price=149000},
            new Car { Brand= "Renaul", Model="Megane 3", Power=110, Price=75000},
            new Car { Brand= "Fiat", Model="Panda", Power=60, Price=36000},
            new Car { Brand= "Skoda", Model="Superb", Power=140, Price=102000}
        };

        public IEnumerable<Car> GetCars()
        {
            return sampleData;
        }
    }
}
