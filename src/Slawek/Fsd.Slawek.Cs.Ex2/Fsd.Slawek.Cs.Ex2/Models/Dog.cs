
namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class Dog : Animal, IAnimalVoice
    {
        public string Voice => "hau hau";

        public Dog(string name) : base(name)
        {
        }
    }
}
