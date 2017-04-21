using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public abstract class ProductBase
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public ProductType Type { get; set; }

        public DateTime ProductionDate { get; set; }

        public decimal Price { get; set; }

        public ProductBase(string producer, string model, ProductType type, DateTime productionDate, decimal price)
        {
            Producer = producer;
            Model = model;
            Type = type;
            ProductionDate = productionDate;
            Price = price;
        }
    }
}