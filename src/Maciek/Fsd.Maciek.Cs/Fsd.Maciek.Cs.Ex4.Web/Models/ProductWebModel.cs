namespace Fsd.Maciek.Cs.Ex4.Web.Models
{
    public class ProductWebModel
    {
        public string Manufacturer { get; internal set; }
        public string Model { get; internal set; }
        public decimal Price { get; internal set; }
        public int ProductionYear { get; internal set; }
        public string ProductType { get; internal set; }
    }
}