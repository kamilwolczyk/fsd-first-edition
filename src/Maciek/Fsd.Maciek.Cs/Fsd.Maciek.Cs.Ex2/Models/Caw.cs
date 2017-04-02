namespace Fsd.Maciek.Cs.Ex2.Models
{
    public class Caw : Animal
    {
        public override string Sound
        {
            get { return "Muuu Muuuu"; }
        }

        public Caw(string name) : base(name)
        {
        }
    }
}
