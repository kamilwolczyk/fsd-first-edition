using Fsd.Maciek.Cs.Ex4.Data.Enums;

namespace Fsd.Maciek.Cs.Ex4.Data.Models
{
    public class Product
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }
        public int ProductionYear { get; private set; }
        public ProductType ProductType { get; private set; }

        public Product(string manufacturer, string model, decimal price, int productionYear, ProductType productType)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            ProductionYear = productionYear;
            ProductType = productType;
        }
    }
}
