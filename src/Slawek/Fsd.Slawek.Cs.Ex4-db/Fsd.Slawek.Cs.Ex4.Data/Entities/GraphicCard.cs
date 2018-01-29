using System;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class GraphicCard : ProductBase
    {
        public decimal MemorySize { get; set; }

        public string MemoryType { get; set; }

        public GraphicCard()
        {

        }

        public GraphicCard(int id, string producer, string model, ProductType type, DateTime productionDate, decimal price, decimal memorySize, string memoryType) :
            base(id, producer, model, type, productionDate, price)
        {
            MemorySize = memorySize;
            MemoryType = memoryType;
        }
    }
}