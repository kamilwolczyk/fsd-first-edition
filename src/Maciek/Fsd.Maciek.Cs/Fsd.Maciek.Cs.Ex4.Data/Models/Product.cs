using Fsd.Maciek.Cs.Ex4.Data.Enums;

namespace Fsd.Maciek.Cs.Ex4.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int ProductionYear { get; set; }
        public ProductType ProductType { get; set; }

        //    public Product(int id, string manufacturer, string model, decimal price, int productionYear, ProductType productType)
        //    {
        //        Id = id;
        //        Manufacturer = manufacturer;
        //        Model = model;
        //        Price = price;
        //        ProductionYear = productionYear;
        //        ProductType = productType;
        //    }
    }
}
