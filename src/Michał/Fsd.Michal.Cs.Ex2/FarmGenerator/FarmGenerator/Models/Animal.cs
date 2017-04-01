namespace FarmGenerator.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract string GiveSound();

        public string SayHello()
        {
            return $"hello, my name is: {Name}";
        }
    }
}
