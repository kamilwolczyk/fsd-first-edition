using Fsd.Slawek.Cs.Ex4.Data.Sql;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public class TypeService<TType> : ITypesService<TType>
    {
        private Repository<TType> _db = new Repository<TType>();
        
        public IEnumerable<TType> GetAllProducts()
        {
            return _db.SelectData(reader => MappingType<TType>.Mapping(reader));
        }

        public TType GetProduct(int id)
        {
            return _db.SelectItem(id, reader => MappingType<TType>.Mapping(reader));
        }
    }
}