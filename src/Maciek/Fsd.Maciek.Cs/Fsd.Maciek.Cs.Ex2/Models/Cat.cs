namespace Fsd.Maciek.Cs.Ex2.Models
{
    public class Cat : Animal
    {
        public override string Sound
        {
            get { return "Miauuuu"; }
        }

        public Cat(string name) : base(name)
        {
        }
    }
}
