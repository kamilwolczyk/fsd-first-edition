namespace FarmGenerator.Models
{
    public class Cow : Animal
    {
        public Cow(string name)
            : base(name)
        {

        }

        public override string GiveSound()
        {
            return "Muuu muuu";
        }
    }
}
