using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex4.Data;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;

namespace Fsd.Maciek.Cs.Ex4.Services
{
    public class MockProductService : IProductService
    {
        public int GetProductsCount()
        {
            ListOfProductsGenerator generator = new ListOfProductsGenerator();
            List<Product> listOfProducts = (List<Product>)generator.GetListOfProducts();

            return listOfProducts.Count;
        }

        public IEnumerable<Product> GetListOfProducts()
        {
            ListOfProductsGenerator generator = new ListOfProductsGenerator();

            return generator.GetListOfProducts();
        }
    }
}
