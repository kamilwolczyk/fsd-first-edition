using Fsd.Kamil.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Kamil.Cs.Ex4.Services.Products
{
    public interface IProductService
    {
        IEnumerable<ProductBase> GetAllProducts();

        int GetProductCount();
    }
}
