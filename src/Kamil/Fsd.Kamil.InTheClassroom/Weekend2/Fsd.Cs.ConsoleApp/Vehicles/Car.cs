using Fsd.Cs.ConsoleApp.Vehicles.Features;

namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Car : Vehicle, IComfort
    {
        public int DoorCount { get; set; }

        public int WindowCount => DoorCount + 2;

        private bool _isClimatronicOn;

        public Car(int id, string name, decimal price, int doorCount) 
            : base(id, name, price)
        {            
            DoorCount = doorCount;
        }

        public override string Repair()
        {
            return "Car has been repaired";
        }

        public void TurnClimatronicOn()
        {
            _isClimatronicOn = true;
        }

        public void TurnClimatronicOff()
        {
            _isClimatronicOn = false;
        }
    }
}
