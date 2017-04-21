using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex4.Web.Models
{
    public class ProductList
    {
        public IEnumerable<ProductModel> ProductsList { get; set; }
        public int Page { get; set; }
        public int Max { get; set; }
        public int Total { get; set; }
    }
}