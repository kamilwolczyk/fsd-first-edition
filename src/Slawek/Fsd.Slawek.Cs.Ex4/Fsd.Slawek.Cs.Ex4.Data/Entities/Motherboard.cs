using System;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class Motherboard : ProductBase
    {
        public string Chipset { get; set; }

        public string Socket { get; set; }

        public Motherboard(string producer, string model, DateTime productionDate, decimal price, string chipset, string socket) : 
            base(producer, model, ProductType.Motherboard, productionDate, price)
        {
            Chipset = chipset;
            Socket = socket;
        }
    }
}