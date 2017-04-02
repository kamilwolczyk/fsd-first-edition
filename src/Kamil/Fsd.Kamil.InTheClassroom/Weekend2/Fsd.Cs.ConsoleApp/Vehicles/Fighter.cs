namespace Fsd.Cs.ConsoleApp.Vehicles
{
    public class Fighter : Airplane
    {
        public int GunPower { get; set; }
        
        public Fighter(int id, string name, decimal price, int wingCount, int gunPower)
            : base(id, name, price, wingCount)
        {
            GunPower = gunPower;
        }

        public override string Repair()
        {
            return "Fighter has been repaired";
        }
    }
}
