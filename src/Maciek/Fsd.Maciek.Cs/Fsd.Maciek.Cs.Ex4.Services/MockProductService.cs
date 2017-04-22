using Fsd.Maciek.Cs.Ex4.Data;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;
using System.Collections.Generic;

namespace Fsd.Maciek.Cs.Ex4.Services
{
    public class MockProductService : IProductService
    {
        public IEnumerable<Product> GetListOfProducts()
        {
            ListOfProductsGenerator generator = new ListOfProductsGenerator();

            return generator.GetListOfProducts();
        }
    }
}
