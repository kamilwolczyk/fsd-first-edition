using Fsd.Kamil.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Kamil.Cs.Ex4.Data.Entities
{
    public abstract class ProductBase
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public ProductType Type { get; set; }

        public decimal Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public ProductBase(string producer, string model, decimal price, DateTime productionDate, ProductType type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            Type = type;
        }
    }
}
