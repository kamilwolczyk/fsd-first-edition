using System;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class GraphicCard : ProductBase
    {
        public decimal MemorySize { get; set; }

        public string MemoryType { get; set; }

        public GraphicCard(string producer, string model, DateTime productionDate, decimal price, decimal memorySize, string memoryType) : 
            base(producer, model, ProductType.GraphicCard, productionDate, price)
        {
            MemorySize = memorySize;
            MemoryType = memoryType;
        }
    }
}