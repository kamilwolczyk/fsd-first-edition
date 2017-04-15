using System;
using System.Collections.Generic;
using Fsd.Slawek.Cs.Ex4.Data.Entities;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public class MemoryProductService : IProductService
    {
        private IEnumerable<ProductBase> _products = new List<ProductBase>
        {
            new Motherboard("MSI", "B250M PRO-VDH", new DateTime(2016,04,04), 324, "Intel B250", "Socket 1151"),
            new Motherboard("Gigabyte", "GA-B250M-D3H", new DateTime(2016,06,12), 420, "Intel B250", "Socket 1151"),
            new Motherboard("MSI", "B350 TOMAHAWK", new DateTime(2017,01,06), 388, "AMD B350", "Socket AM4"),
            new GraphicCard("Gigabyte", "GeForce GTX 1060", new DateTime(2016,11,06), 1199,6, "GDDR5"),
            new GraphicCard("Asus", "Radeon R5 230", new DateTime(2016,07,06), 149, 1 , "GDDR3"),
            new GraphicCard("Asus", "GeForce GTX 1050", new DateTime(2017,02,02), 539 ,2 ,"GDDR5"),
            new SoundCard("Creative","Sound Blaster X-Fi", new DateTime(2016,05,22), 215, "USB"),
            new SoundCard("AIM","SC808", new DateTime(2016,02,11), 429, "PCI-E"),
            new SoundCard("Asus","Xonar DG", new DateTime(2016,08,04), 139, "PCI"),
            new Monitor("Dell", "U2515H", new DateTime(2016,09,14), 1479, 8, 24),
            new Monitor("iiyama", "X2483HSU", new DateTime(2016,09,14), 719, 4, 23.8M),
            new Processor("Intel","i7-7700K", new DateTime(2017,02,03), 1599, 4200, 8),
            new Processor("Intel","i5-7400", new DateTime(2017,01,07), 809, 3000, 6),
            new Processor("AMD","Ryzen 7", new DateTime(2017,01,23), 2349, 3600, 16),
        };

        public IEnumerable<ProductBase> GetAllProducts()
           => _products;
    }
}