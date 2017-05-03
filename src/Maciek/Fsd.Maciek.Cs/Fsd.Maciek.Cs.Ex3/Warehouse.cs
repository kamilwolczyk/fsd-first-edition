using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex3.Interfaces;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3
{
    public class Warehouse : IWarehouse
    {
        public List<Product> Products { get; internal set; }

        public Warehouse(List<Product> products)
        {
            Products = products;
        }

        public void AddProductToWarehouse()
        {
            Products.Add(Presenter.GetProduct());
        }

        public List<Product> GetListOfProducts()
        {
            return Products;
        }

        public bool IsProductInWarehouse(string name)
        {
            if (Products.Exists(x => x.Name == name) && Products.Find(x => x.Name == name).Count > 0)
                return true;

            return false;
        }

        public void SellProductInWarehouse(string name)
        {
            Products.Find(x => x.Name == name).Count--;
        }
    }
}
