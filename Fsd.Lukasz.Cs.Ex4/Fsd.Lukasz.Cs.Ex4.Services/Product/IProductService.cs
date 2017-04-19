using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Lukasz.Cs.Ex4.Services.Product
{
    public interface IProductService
    {
        IEnumerable<ProductBase> GetProducts();
        int Count();
    }
}