using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3.Interfaces
{
    public interface IWarehouse
    {
        List<Product> GetListOfProducts();
        void AddProductToWarehouse();
        bool IsProductInWarehouse(string name);
        void SellProductInWarehouse(string name);
    }
}
