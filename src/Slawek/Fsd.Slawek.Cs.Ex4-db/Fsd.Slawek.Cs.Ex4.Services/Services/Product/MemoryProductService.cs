using System;
using System.Collections.Generic;
using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public class MemoryProductService : IProductService
    {
        private IReadOnlyList<ProductBase> _products = new List<ProductBase>
        {
            //new Motherboard(1,"MSI", "B250M PRO-VDH", ProductType.Motherboard, new DateTime(2016,04,04), 324, "Intel B250", "Socket 1151"),
            //new Motherboard(2,"Gigabyte", "GA-B250M-D3H", new DateTime(2016,06,12), 420, "Intel B250", "Socket 1151"),
            //new Motherboard(3,"MSI", "B350 TOMAHAWK", new DateTime(2017,01,06), 388, "AMD B350", "Socket AM4"),
            //new GraphicCard(1,"Gigabyte", "GeForce GTX 1060", ProductType.GraphicCard,new DateTime(2016,11,06), 1199,6, "GDDR5"),
            //new GraphicCard(2,"Asus", "Radeon R5 230", new DateTime(2016,07,06), 149, 1 , "GDDR3"),
            //new GraphicCard(3,"Asus", "GeForce GTX 1050", new DateTime(2017,02,02), 539 ,2 ,"GDDR5"),
            //new SoundCard(1,"Creative","Sound Blaster X-Fi", new DateTime(2016,05,22), 215, "USB"),
            //new SoundCard(2,"AIM","SC808", new DateTime(2016,02,11), 429, "PCI-E"),
            //new SoundCard(3,"Asus","Xonar DG", new DateTime(2016,08,04), 139, "PCI"),
            //new Monitor(1,"Dell", "U2515H", new DateTime(2016,09,14), 1479, 8, 24),
            //new Monitor(2,"iiyama", "X2483HSU", new DateTime(2016,09,14), 719, 4, 23),
            //new Processor(1,"Intel","i7-7700K", new DateTime(2017,02,03), 1599, 4200, 8),
            //new Processor(2,"Intel","i5-7400", new DateTime(2017,01,07), 809, 3000, 6),
            //new Processor(3,"AMD","Ryzen 7", new DateTime(2017,01,23), 2349, 3600, 16),
        };

        public void AddProduct(ProductBase cc)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBase> GetAllProducts()
           => _products;

        public int GetCount()
        {
           return _products.Count;
        }

        public ProductBase GetProduct(int id, ProductType type)
        {
            throw new NotImplementedException();
        }
    }
}