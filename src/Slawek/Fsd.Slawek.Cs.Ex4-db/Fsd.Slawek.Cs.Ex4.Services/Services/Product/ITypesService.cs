using Fsd.Slawek.Cs.Ex4.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public interface ITypesService<Ttype>
    {
        IEnumerable<Ttype> GetAllProducts();

        Ttype GetProduct(int id);
    }
}