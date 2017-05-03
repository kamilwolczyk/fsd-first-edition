using System;

namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public abstract class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Vehicle(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract string Repair();
    }
}
