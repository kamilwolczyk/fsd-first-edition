namespace Fsd.Maciek.Cs.Ex2.Models
{
    public class Sheep : Animal
    {
        public override string Sound
        {
            get { return "Bee Bee Bee"; }
        }

        public Sheep(string name) : base(name)
        {
        }
    }
}
