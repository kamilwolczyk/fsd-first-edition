using Fsd.Data.Enums;
using System;

namespace Fsd.Data.Entities.Products
{
    public class Monitor : ProductBase
    {
        public Monitor(string producer, string model, decimal price, DateTime productionDate)
            : base(producer, model, price, productionDate, ProductType.Monitor)
        { }
    }
}
