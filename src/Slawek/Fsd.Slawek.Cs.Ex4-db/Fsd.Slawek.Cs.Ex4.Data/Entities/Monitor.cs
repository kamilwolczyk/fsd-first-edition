using System;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class Monitor : ProductBase
    {
        public int ResponseTime { get; set; }

        public decimal Size { get; set; }

        public Monitor()
        {
        }

        public Monitor(int id, string producer, string model, DateTime productionDate, decimal price, int responseTime, decimal size) :
            base(id, producer, model, ProductType.Monitor, productionDate, price)
        {
            ResponseTime = responseTime;
            Size = size;
        }
    }
}