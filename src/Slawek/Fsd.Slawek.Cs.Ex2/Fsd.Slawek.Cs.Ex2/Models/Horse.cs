namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class Horse : Animal, IAnimalVoice
    {
        public string Voice => "ii hahha prrrr";

        public Horse(string name) : base(name)
        {
        }
    }
}
