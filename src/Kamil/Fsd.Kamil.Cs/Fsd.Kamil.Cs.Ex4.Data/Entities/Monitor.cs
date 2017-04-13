using Fsd.Kamil.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Kamil.Cs.Ex4.Data.Entities
{
    public class Monitor : ProductBase
    {
        public Monitor(string producer, string model, decimal price, DateTime productionDate)
            : base(producer, model, price, productionDate, ProductType.Monitor)
        { }
    }
}
