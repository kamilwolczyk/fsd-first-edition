using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3.Models
{
    public class Product : IProduct
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
