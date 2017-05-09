using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public interface IProduct
    {
        int Id { get; set; }

        string Producer { get; set; }

        string Model { get; set; }

        ProductType Type { get; set; }

        DateTime ProductionDate { get; set; }

        decimal Price { get; set; }
    }
}
