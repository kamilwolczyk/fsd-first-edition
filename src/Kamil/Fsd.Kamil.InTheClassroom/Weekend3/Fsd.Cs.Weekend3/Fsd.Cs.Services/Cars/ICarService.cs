using Fsd.Cs.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Cs.Services.Cars
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
    }
}
