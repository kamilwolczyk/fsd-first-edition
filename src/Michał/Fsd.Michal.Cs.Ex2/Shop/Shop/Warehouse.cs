using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Warehouse
    {
        private List<Product> _products;

        internal List<Product> Products { get => _products; set => _products = value; }

        public Warehouse()
        {
            _products = new List<Product>();
        }

        public void AddProduct()
        {
            Console.Clear();
            Product product = new Product();
            string name = WarehousePresenter.GetInput("Name: ");

            if (!IsProductCreated(name))
            {
                product.ProductName = name;
                int count = WarehousePresenter.GetIntInput("Count: ");
                product.ProductCount = count;

                double price = WarehousePresenter.GetDoubleInput();
                product.ProductPrice = price;

                _products.Add(product);
            }
            else
            {
                Product p = FindProduct(name);
                int count = WarehousePresenter.GetIntInput("Count: ");
                p.ProductCount += count;
            }
        }

        public int Count()
        {
            return _products.Count();
        }

        internal Product FindProduct(string name)
        {
            return _products.FirstOrDefault(product => product.ProductName == name);
        }

        public bool IsProductCreated(string name)
        {
            return _products.Any(product => product.ProductName == name);
        }

        private void RemoveProduct(Product p)
        {
            _products.Remove(p);
        }

        public void BuyProduct()
        {
            Console.Clear();
            string name = WarehousePresenter.GetInput("What do you wan't to buy?");

            if (!IsProductCreated(name))
            {
                WarehousePresenter.ShowMessage("such product didn't exist in system");
            }
            else
            {
                Product p = FindProduct(name);
                int count = WarehousePresenter.GetIntInput("how many do you want to buy ?");

                if (count <= p.ProductCount)
                {
                    p.ProductCount -= count;
                    if (p.ProductCount == 0)
                    {
                        RemoveProduct(p);
                    }
                }
                else
                {
                    WarehousePresenter.ShowMessage($"You could only buy {p.ProductCount} , try again");
                }
            }
        }
    }
}
