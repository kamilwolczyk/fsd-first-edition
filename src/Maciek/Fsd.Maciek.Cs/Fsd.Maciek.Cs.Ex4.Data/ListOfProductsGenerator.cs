using Fsd.Maciek.Cs.Ex4.Data.Enums;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using System.Collections.Generic;

namespace Fsd.Maciek.Cs.Ex4.Data
{
    public class ListOfProductsGenerator
    {
        public IEnumerable<Product> ListOfProducts { get; private set; }

        public ListOfProductsGenerator()
        {
            IEnumerable<Product> _listOfProducts = new List<Product>()
            {
                new Product("Honda","Civic",89000,2008,ProductType.Car),
                new Product("Mercedes","E-class",289000,2016,ProductType.Car),
                new Product("BMW","7-series",89000,2010,ProductType.Car),
                new Product("Audi","SQ7",889000,2017,ProductType.Car),
                new Product("Fiat","125p",9000,1968,ProductType.Car),
                new Product("Samsung","Galaxy S8",3499,2017,ProductType.Smartphone),
                new Product("Apple","iPhone 7",2799,2016,ProductType.Smartphone),
                new Product("Nokia","3310",999,2010,ProductType.Smartphone),
                new Product("Xiaomi","Mi8",2199,2016,ProductType.Smartphone),
                new Product("Samsung","Galaxy S2",899,2009,ProductType.Smartphone),
                new Product("Apple","MacBook Pro",11900,2017,ProductType.Laptop),
                new Product("Dell","Lattitude E7450",5499,2015,ProductType.Laptop),
                new Product("HP","Titanium",2499,2008,ProductType.Laptop),
                new Product("Asus","Zenbook",89000,2008,ProductType.Laptop),
                new Product("Lenovo","B70",4900,2008,ProductType.Laptop),
                new Product("Burton","Custom X",2399,2008,ProductType.Snowboard),
                new Product("Apo","Dragon",1299,2013,ProductType.Snowboard),
                new Product("Jones","Freeride",3999,2018,ProductType.Snowboard),
                new Product("DC","The Space Echo",2999,2017,ProductType.Snowboard),
                new Product("LibTech","Skate Banana",2499,2013,ProductType.Snowboard),
            };

            ListOfProducts = _listOfProducts;
        }

        public IEnumerable<Product> GetListOfProducts()
        {
            return ListOfProducts;
        }
    }
}
