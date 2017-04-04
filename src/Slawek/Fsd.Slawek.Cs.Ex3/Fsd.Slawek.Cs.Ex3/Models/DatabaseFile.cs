using Fsd.Slawek.Cs.Ex3.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class DatabaseFile : IDatabase
    {
        public List<ProductInfo> Products { get; }
        FileReader _file = new FileReader();

        public DatabaseFile()
        {
            Products = new List<ProductInfo>();
            if (_file.FileCheck())
                Products = _file.ReadData().ToList();
        }

        public void AddProduct(IProduct product, int count)
        {
            if (Products.Any(p => p.Item.Name == product.Name))
            {
                EditProduct(product, count);
                return;
            }

            Products.Add(new ProductInfo(product, count));
            _file.WriteData(Products);
        }

        public void EditProduct(IProduct product, int count)
        {
            int index = Products.FindIndex(t => t.Item.Name == product.Name);
            int itemCount = Products[index].Count;

            if (count + itemCount == 0)
            {
                RemoveProduct(product);
                return;
            }

            Products[index] = new ProductInfo(product, count + itemCount);
            _file.WriteData(Products);
        }

        public void RemoveProduct(IProduct product)
        {
            var del = Products.FirstOrDefault(t => t.Item.Name == product.Name);

            Products.Remove(del);
            _file.WriteData(Products);
        }
    }
}
