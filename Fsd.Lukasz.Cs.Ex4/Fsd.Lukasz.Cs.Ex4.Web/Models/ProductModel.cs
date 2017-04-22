using System;

namespace Fsd.Lukasz.Cs.Ex4.Web.Models
{
    public class ProductModel
    {
        public string Producer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
    }
}