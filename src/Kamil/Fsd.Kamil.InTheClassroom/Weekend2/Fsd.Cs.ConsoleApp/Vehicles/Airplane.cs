using System;

namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Airplane : Vehicle
    {
        public int WingCount { get; set; }

        public Airplane(int id, string name, decimal price, int wingCount)
            : base(id, name, price)
        {
            WingCount = wingCount;
        }

        public override string Repair()
        {
            return "Airplane has been repaired";
        }
    }
}
