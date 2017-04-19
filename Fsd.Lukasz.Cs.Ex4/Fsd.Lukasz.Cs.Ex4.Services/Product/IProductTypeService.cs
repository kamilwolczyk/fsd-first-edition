using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Lukasz.Cs.Ex4.Services.Product
{
    public interface IProductTypeService
    {
        IDictionary<int, ProductType> GetTypes();
        string GetProductTypeName(int id);
    }
}