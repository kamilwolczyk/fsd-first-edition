﻿using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;

namespace Fsd.Slawek.Cs.Ex4.Data.Entities
{
    public class Processor : ProductBase
    {
        public int ClockSpeed { get; set; }

        public int CacheSize { get; set; }

        public Processor(string producer, string model, DateTime productionDate, decimal price, int clockSpeed, int cacheSize) :
            base(producer, model, ProductType.Processor, productionDate, price)
        {
            ClockSpeed = clockSpeed;
            CacheSize = cacheSize;
        }
    }
}