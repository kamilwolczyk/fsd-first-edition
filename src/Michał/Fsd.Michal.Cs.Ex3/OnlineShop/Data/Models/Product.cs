using System;

namespace Data.Models
{
    public class Product
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public string Type { get; set; }

        public Product(string producer, string model, double price, DateTime productionDate, string type)
        {
            Producer = producer;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            Type = type;
        }
    }
}
