using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex3.Models.Interfaces
{
    public interface IDatabase
    {
        List<ProductInfo> Products { get; }

        void AddProduct(IProduct product, int count);
        void RemoveProduct(IProduct product);
        void EditProduct(IProduct product, int count);
    }
}
