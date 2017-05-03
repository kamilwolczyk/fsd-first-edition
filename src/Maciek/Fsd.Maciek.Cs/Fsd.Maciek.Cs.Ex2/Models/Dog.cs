namespace Fsd.Maciek.Cs.Ex2.Models
{
    public class Dog : Animal
    {
        public override string Sound
        {
            get { return "Hau Hau Hau"; }
        }

        public Dog(string name) : base(name)
        {
        }
    }
}
