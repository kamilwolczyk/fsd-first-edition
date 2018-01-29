using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public interface IProductService
    {
        IEnumerable<ProductBase> GetAllProducts();

        ProductBase GetProduct(int index, ProductType type);

        int GetCount();

        void AddProduct(ProductBase cc);
    }
}