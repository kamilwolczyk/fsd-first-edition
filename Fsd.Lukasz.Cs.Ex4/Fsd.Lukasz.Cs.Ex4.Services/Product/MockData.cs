using Fsd.Lukasz.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Lukasz.Cs.Ex4.Services.Product
{
    public class MockData : IProductAndProductTypeService
    {
        public int Count()
        {
            return SampleData().Count();
        }

        public IEnumerable<ProductBase> GetProducts()
        {
            return SampleData();
        }

        public string GetProductTypeName(int id)
        {
            return GetTypes()[id].TypeName;
        }

        public IDictionary<int, ProductType> GetTypes()
        {
            return Types();
        }

        private IEnumerable<ProductBase> SampleData()
        {
            IList<ProductBase> sampleData = new List<ProductBase>
            {
                new Data.Entities.Product("Merida", "NINETY - SIX 9.TEAM", 35000m, new DateTime(2016,1,1), 1),
                new Data.Entities.Product("Merida", "Crossway 40-D", 2100m, new DateTime(2016,1,1),1),
                new Data.Entities.Product("Kross", "Soil 2.0", 12999m, new DateTime(2016,1,1), 1),
                new Data.Entities.Product("Kross", "Moon 3.0", 14999m, new DateTime(2016,1,1), 1),
                new Data.Entities.Product("Kelly's", "Reyon", 6999m, new DateTime(2016,1,1), 1),
                new Data.Entities.Product("Shimano", "SPD SH-MT5", 299m, new DateTime(2016,1,1), 2),
                new Data.Entities.Product("SIDI", "Eagle 7", 649m, new DateTime(2016,1,1),2),
                new Data.Entities.Product("Mavic", "Crissmax Xl Pro", 649m, new DateTime(2016,1,1), 2),
                new Data.Entities.Product("SIDI", "Level", 509m, new DateTime(2016,1,1), 2),
                new Data.Entities.Product("SIDI", "Ergo 4", 979m, new DateTime(2016,1,1), 2),
                new Data.Entities.Product("ROGELLI", "Perugia", 69m, new DateTime(2016,1,1), 3),
                new Data.Entities.Product("Endura", "FS260-Pro", 159m, new DateTime(2016,1,1),3),
                new Data.Entities.Product("Fox", "Aircool Zip", 239m, new DateTime(2016,1,1),3),
                new Data.Entities.Product("X-BIONIC", "Twyce", 679m, new DateTime(2016,1,1), 3),
                new Data.Entities.Product("ENDURA", "Extact II", 199m, new DateTime(2016,1,1), 3),
                new Data.Entities.Product("SELLE ITALIA", "Novus Superflow S3 2017", 629m, new DateTime(2016,1,1), 4),
                new Data.Entities.Product("SELLE ROYAL", "Athletic Freccia", 99m, new DateTime(2016,1,1), 4),
                new Data.Entities.Product("Continental", "Ride Tour", 45m, new DateTime(2016,1,1), 5),
                new Data.Entities.Product("Shimano", "SPD DEORE XT", 299m, new DateTime(2016,1,1), 6),
                new Data.Entities.Product("SR SUNTOUR", "XCR RLR 27.5", 599m, new DateTime(2016,1,1), 7),
            };
            return sampleData;
        }

        private IDictionary<int, ProductType> Types()
        {
            IDictionary<int, ProductType> types = new Dictionary<int, ProductType>();

            types.Add(1, new ProductType(1, "Bike"));
            types.Add(2, new ProductType(2, "Shoe"));
            types.Add(3, new ProductType(3, "Shirt"));
            types.Add(4, new ProductType(4, "Saddle"));
            types.Add(5, new ProductType(5, "Tire"));
            types.Add(6, new ProductType(6, "Pedal"));
            types.Add(7, new ProductType(7, "Damper"));

            return types;
        }
    }
}