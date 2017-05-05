using Fsd.Maciek.Cs.Ex4.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using Fsd.Maciek.Cs.Ex4.Data.SQL;
using Fsd.Maciek.Cs.Ex4.Data.Enums;

namespace Fsd.Maciek.Cs.Ex4.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetListOfProducts()
        {
            Repository<Product> repository = new Repository<Product>();
            return repository.SelectData<Product>("Products", reader =>
                 new Product
                 {
                     Id = (int)reader["Id"],
                     Manufacturer = (string)reader["Manufacturer"],
                     Model = (string)reader["Model"],
                     Price = (decimal)reader["Price"],
                     ProductionYear = (int)reader["ProductionYear"],
                    // ProductType = (ProductType)reader["ProductType"]
                 });
        }

        public int GetProductsCount()
        {
            return 5; //To Do
        }
    }
}
