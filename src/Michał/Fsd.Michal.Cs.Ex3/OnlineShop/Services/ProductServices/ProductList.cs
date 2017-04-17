using Data.Models;
using System;
using System.Collections.Generic;

namespace Services.ProductServices
{
    public class ProductList : IProductList
    {
        private IEnumerable<Product> SampleProductList = new List<Product>
        {
               new Product("Audi","A4",19999,new DateTime(2007,01,19),"car"),
               new Product("Toyota","Corolla",9999,new DateTime(2002,11,11),"car"),
               new Product("Toyota","Hilux",25000,new DateTime(2005,03,28),"car"),
               new Product("HTC","M8",500,new DateTime(2016,01,11),"mobile"),
               new Product("Lenovo","x230",700,new DateTime(2011,05,05),"laptop"),
               new Product("HP","proobook",9999,new DateTime(2016,11,21),"laptop"),
               new Product("Brother","LC985",459,new DateTime(2017,04,04),"car"),
               new Product("Audi","A4",9999,new DateTime(2000,11,11),"car"),
               new Product("Microsoft","Xbox one",800, new DateTime(2016,04,09),"console"),
               new Product("Sony","PS4",850,new DateTime(2016,04,29),"console"),
               new Product("Apple","Iphone 6",1850,new DateTime(2016,05,29),"mobile"),
               new Product("Lenovo","x240",3850,new DateTime(2016,05,30),"laptop"),
               new Product("Samsung","S6",4000,new DateTime(2016,08,07),"mobile"),
               new Product("Sony","Bravia 40", 1699,new DateTime(2016,11,08),"TV"),
               new Product("JBL","GO",349,new DateTime(2017,03,09),"speaker"),
               new Product("Zelmer","ZCK0277S",89, new DateTime(2017,02,02),"kettle"),
               new Product("Indesit","IWSD",689,new DateTime(2016,12,12),"washer"),
               new Product("Amazon","Kindle touch",799, new DateTime(2017,03,09),"ebook reader"),
               new Product("Go Pro","Hero", 999, new DateTime(2016,12,22),"camera"),
               new Product("XIAOMI","YI", 249, new DateTime(2016,10,22),"camera"),
        };

        public IEnumerable<Product> GetProducts()
        {
            return SampleProductList;
        }
    }
}
