using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class Warehouse
    {
        private List<Product> _products;

        public Warehouse()
        {
            _products = new List<Product>();
        }

        internal void AddProduct(Product product)
        {
            product = new Product();
            Console.Clear();
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (!IsProductExist(name))
            {
                product.ProductName = name;

                Console.Write("Count: ");
                int count = Convert.ToInt32(Console.ReadLine());
                product.ProductCount = count;

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                product.ProductPrice = price;

                _products.Add(product);

            }
            else
            {
                Product p = FindProduct(name);
                Console.WriteLine("count:");
                int count = Convert.ToInt32(Console.ReadLine());
                p.ProductCount += count;
            }
        }

        internal int Count()
        {
            return _products.Count();
        }

        internal Product FindProduct(string name)
        {
            return _products.FirstOrDefault(product => product.ProductName == name);
        }

        internal bool IsProductExist(string name)
        {
            foreach (Product product in _products)
            {
                if (product.ProductName == name)
                    return true;
            }
            return false;
        }

        internal void ShowProducts()
        {
            Console.WriteLine("{0,40}", "PRODUCTS");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|{0,25}|{1,5}|{2,5}|", "Name", "Price", "Count");

            foreach (Product product in _products)
            {
                Console.WriteLine("|{0,25}|{1,5}|{2,5}|", product.ProductName, product.ProductPrice, product.ProductCount);
            }
        }

        internal void RemoveProduct(Product p)
        {
            _products.Remove(p);
        }

        internal void BuyProduct()
        {
            Console.Clear();
            Console.WriteLine("What do you wan't to buy?");
            string name = Console.ReadLine();

            if (!IsProductExist(name))
            {
                Console.Clear();
                Console.WriteLine($"such product didn't exist in system");
            }
            else
            {
                Product p = FindProduct(name);
                Console.WriteLine("how many do you want to buy ?");

                int count = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine($"You could only buy {p.ProductCount} , try again");
                }
            }
        }
    }
}
