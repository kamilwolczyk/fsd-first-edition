using System;

namespace Fsd.Lukasz.Cs.Ex4.Data.Entities
{
    public class Product : ProductBase
    {
        public Product(string producer, string model, decimal price, DateTime productionDate, int type) : base(producer, model, price, productionDate, type)
        {
        }
    }
}