using System;

namespace OnlineShop.Models
{
    public class ProductModel
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public double Price { get; set; }

        public DateTime ProductionDate { get; set; }

        public string Type { get; set; }
    }
}