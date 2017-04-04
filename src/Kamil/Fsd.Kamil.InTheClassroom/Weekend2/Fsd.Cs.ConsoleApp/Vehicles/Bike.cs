namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Bike : Vehicle
    {
        public Bike(int id, string name, decimal price) 
            : base(id, name, price)
        { }

        public override string Repair()
        {
            return "Bike has been repaired";
        }
    }
}
