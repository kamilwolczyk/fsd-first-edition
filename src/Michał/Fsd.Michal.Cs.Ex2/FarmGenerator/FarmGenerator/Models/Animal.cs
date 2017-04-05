namespace FarmGenerator.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public string SayHello()
        {
            return $"hello, my name is: {Name}";
        }
    }
}
