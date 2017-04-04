namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Boat : Vehicle
    {
        public Boat(int id, string name, decimal price)
            : base(id, name, price)
        { }

        public override string Repair()
        {
            return "Boat has been repaired";
        }
    }
}
