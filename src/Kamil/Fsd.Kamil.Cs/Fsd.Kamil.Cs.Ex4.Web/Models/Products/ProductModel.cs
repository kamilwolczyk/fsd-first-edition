using Fsd.Kamil.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Kamil.Cs.Ex4.Web.Models.Products
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public ProductType Type { get; set; }

        public decimal Price { get; set; }

        public DateTime ProductionDate { get; set; }
    }
}
