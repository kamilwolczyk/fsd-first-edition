using Data.Models;
using System.Collections.Generic;

namespace Services.ProductServices
{
    public interface IProductList
    {
        IEnumerable<Product> GetProducts();
    }
}
