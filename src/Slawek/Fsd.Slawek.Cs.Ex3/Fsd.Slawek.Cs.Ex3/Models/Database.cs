using Fsd.Slawek.Cs.Ex3.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class Database: IDatabase
    {
        public List<ProductInfo> Products { get; } = new List<ProductInfo>();

        public Database()
        {
            Products = new List<ProductInfo>()
            {
                 new ProductInfo(new Product("Computer",120),3),
                 new ProductInfo(new Product("TV",520),5),
                 new ProductInfo(new Product("Radio",50),10),
                 new ProductInfo(new Product("Headphones",160),2)
            };
        }

        public virtual void AddProduct(IProduct product, int count)
        {
            if (Products.Any(p => p.Item.Name == product.Name))
            {
                EditProduct(product, count);
                return;
            }
            Products.Add(new ProductInfo(product,count));
        }

        public virtual void RemoveProduct(IProduct product)
        {
            var del = Products.FirstOrDefault(t => t.Item.Name == product.Name);
            Products.Remove(del);
        }

        public virtual void EditProduct(IProduct product, int count)
        {
            int index = Products.FindIndex(t => t.Item.Name == product.Name);
            int itemCount = Products[index].Count;
            if (count + itemCount == 0)
            {
                RemoveProduct(product);
                return;
            }
            Products[index] = new ProductInfo(product, count + itemCount);
        }

    }
}
