namespace Fsd.Maciek.Cs.Ex2.Models
{
    public abstract class Animal
    {
        public abstract string Sound { get; }

        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public string GetNoise()
        {
            return Sound;
        }
    }
}
