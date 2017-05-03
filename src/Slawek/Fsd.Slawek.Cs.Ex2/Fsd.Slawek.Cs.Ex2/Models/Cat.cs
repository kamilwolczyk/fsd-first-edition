namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class Cat : Animal, IAnimalVoice
    {
        public string Voice => "miau miau";

        public Cat(string name) : base(name)
        {
        }
    }
}
