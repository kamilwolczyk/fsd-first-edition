namespace FarmGenerator.Models
{
    class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {

        }

        public override string GiveSound()
        {
            return "hau hau hau";
        }
    }
}
