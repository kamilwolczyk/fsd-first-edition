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
            //ListOfProducts = new List<Product>()
            //{
            //    new Product(1, "Honda","Civic",89000,2008,ProductType.Car),
            //    new Product(2, "Mercedes","E-class",289000,2016,ProductType.Car),
            //    new Product(3, "BMW","7-series",89000,2010,ProductType.Car),
            //    new Product(4, "Audi","SQ7",889000,2017,ProductType.Car),
            //    new Product(5, "Fiat","125p",9000,1968,ProductType.Car),
            //    new Product(6, "Samsung","Galaxy S8",3499,2017,ProductType.Smartphone),
            //    new Product(7, "Apple","iPhone 7",2799,2016,ProductType.Smartphone),
            //    new Product(8, "Nokia","3310",999,2010,ProductType.Smartphone),
            //    new Product(9, "Xiaomi","Mi8",2199,2016,ProductType.Smartphone),
            //    new Product(10, "Samsung","Galaxy S2",899,2009,ProductType.Smartphone),
            //    new Product(11, "Apple","MacBook Pro",11900,2017,ProductType.Laptop),
            //    new Product(12, "Dell","Lattitude E7450",5499,2015,ProductType.Laptop),
            //    new Product(13, "HP","Titanium",2499,2008,ProductType.Laptop),
            //    new Product(14, "Asus","Zenbook",89000,2008,ProductType.Laptop),
            //    new Product(15, "Lenovo","B70",4900,2008,ProductType.Laptop),
            //    new Product(16, "Burton","Custom X",2399,2008,ProductType.Snowboard),
            //    new Product(17, "Apo","Dragon",1299,2013,ProductType.Snowboard),
            //    new Product(18, "Jones","Freeride",3999,2018,ProductType.Snowboard),
            //    new Product(19, "DC","The Space Echo",2999,2017,ProductType.Snowboard),
            //    new Product(20, "LibTech","Skate Banana",2499,2013,ProductType.Snowboard),
            //};
        }

        public IEnumerable<Product> GetListOfProducts()
        {
            return ListOfProducts;
        }
    }
}
