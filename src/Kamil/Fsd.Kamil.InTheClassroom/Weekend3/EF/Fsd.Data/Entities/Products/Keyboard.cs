using Fsd.Data.Enums;
using System;

namespace Fsd.Data.Entities.Products
{
    public class Keyboard : ProductBase
    {
        public Keyboard(string producer, string model, decimal price, DateTime productionDate)
            : base(producer, model, price, productionDate, ProductType.Keyboard)
        { }
    }
}
