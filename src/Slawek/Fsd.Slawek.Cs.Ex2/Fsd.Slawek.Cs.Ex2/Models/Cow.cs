namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class Cow : Animal, IAnimalVoice
    {
        public string Voice => "muuuu muuuu";

        public Cow(string name) : base(name)
        {
        }
    }
}
