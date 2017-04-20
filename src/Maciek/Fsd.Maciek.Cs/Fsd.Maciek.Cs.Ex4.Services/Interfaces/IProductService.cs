using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex4.Data.Models;

namespace Fsd.Maciek.Cs.Ex4.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetListOfProducts();
    }
}
