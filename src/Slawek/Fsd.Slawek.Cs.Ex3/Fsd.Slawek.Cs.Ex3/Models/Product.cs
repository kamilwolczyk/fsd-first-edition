using Fsd.Slawek.Cs.Ex3.Models.Interfaces;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class Product : IProduct
    {
        public string Name { get; }
        public decimal Price { get; }
        
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
