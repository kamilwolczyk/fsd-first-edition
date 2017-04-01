namespace FarmGenerator.Models
{
    class Cat : Animal 
    {
        public Cat(string name)
            : base(name)
        {

        }

        public override string GiveSound()
        {
            return "miał";
        }
    }
}
