using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Slawek.Cs.Ex4.Web.Models
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public ProductType Type { get; set; }

        public DateTime ProductionDate { get; set; }

        public decimal Price { get; set; }

        public int Index { get; set; }
    }
}