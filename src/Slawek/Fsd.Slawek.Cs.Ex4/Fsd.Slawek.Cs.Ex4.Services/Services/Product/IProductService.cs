using Fsd.Slawek.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public interface IProductService
    {
        IEnumerable<ProductBase> GetAllProducts();

        ProductBase GetProduct(int index);
    }
}