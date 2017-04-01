namespace FarmGenerator.Models
{
    public class Sheep : Animal
    {
        public Sheep(string name) 
            : base(name)
        {

        }

        public override string GiveSound()
        {
            return "Bee beee bee";
        }
    }
}
