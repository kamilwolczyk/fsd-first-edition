using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public abstract class ProductBase
    {
        public int Id { get; set; }

        public string Producer { get; set; }

        public string Model { get; set; }

        public ProductType Type { get; set; }

        public DateTime ProductionDate { get; set; }

        public decimal Price { get; set; }

        protected ProductBase()
        {

        }

        protected ProductBase(int id, string producer, string model, ProductType type, DateTime productionDate, decimal price)
        {
            Id = id;
            Producer = producer;
            Model = model;
            Type = type;
            ProductionDate = productionDate;
            Price = price;
        }
    }
}