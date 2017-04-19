using System;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public abstract class ProductBase
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public int Type { get; set; }

        public ProductBase(string producer, string model, decimal price, DateTime productionDate, int type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            Type = type;
        }
    }
}