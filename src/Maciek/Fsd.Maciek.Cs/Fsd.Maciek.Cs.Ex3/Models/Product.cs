namespace Fsd.Maciek.Cs.Ex3.Models
{
    public class Product
    {
        public string Name { get; set; }
        public float Cost { get; set; }
        public int Count { get; set; }

        public Product(string name, float cost)
        {
            Name = name;
            Cost = cost;
            Count = 1;
        }
    }
}
