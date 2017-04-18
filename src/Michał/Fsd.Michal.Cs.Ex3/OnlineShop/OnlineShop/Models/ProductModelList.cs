using System.Collections.Generic;

namespace OnlineShop.Models
{
    public class ProductModelList
    {
        public IEnumerable<ProductModel> Products { get; set; }

        public int Page { get; set; }

        public int Max { get; set; }

        public int Total { get; set; }
    }
}