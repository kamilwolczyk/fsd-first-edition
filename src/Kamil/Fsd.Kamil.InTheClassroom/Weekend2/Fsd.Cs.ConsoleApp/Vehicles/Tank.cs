using System;

namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Tank : Vehicle
    {
        public int GunCount { get; set; }

        public string GunType { get; set; }

        public Tank(int id, string name, decimal price, int gunCount, string gunType) 
            : base(id, name, price)
        {
            GunCount = gunCount;
            GunType = gunType;
        }

        public override string Repair()
        {
            return "Tank has been repaired";
        }
    }
}
