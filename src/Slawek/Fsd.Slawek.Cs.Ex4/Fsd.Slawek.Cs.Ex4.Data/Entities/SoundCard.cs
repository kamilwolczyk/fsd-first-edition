using System;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class SoundCard : ProductBase
    {
        public string Interfaces { get; set; }

        public SoundCard(string producer, string model, DateTime productionDate, decimal price, string interfaces) : 
            base(producer, model, ProductType.SoundCard, productionDate, price)
        {
            Interfaces = interfaces;
        }
    }
}