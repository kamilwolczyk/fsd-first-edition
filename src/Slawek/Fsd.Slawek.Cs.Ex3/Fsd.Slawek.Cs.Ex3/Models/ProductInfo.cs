using Fsd.Slawek.Cs.Ex3.Models.Interfaces;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class ProductInfo
    {
        public IProduct Item { get; private set; }
        public int Count { get; private set;}

        public ProductInfo(IProduct product, int count)
        {
            Item = product;
            Count = count;
        }
    }
}
