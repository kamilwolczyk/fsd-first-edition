using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public class ProductType
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public ProductType(int id, string name)
        {
            TypeName = name;
            TypeId = id;
        }
    }
}
