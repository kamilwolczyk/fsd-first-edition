using Fsd.Maciek.Cs.Ex2.Models;

namespace Fsd.Maciek.Cs.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter.RenderHeader();

            var AnimalsCollector = new AnimalsCollector();
            AnimalsCollector.DefineOneOfAnimalType<Cat>("Cat", "Cats");
            AnimalsCollector.DefineOneOfAnimalType<Dog>("Dog", "Dogs");
            AnimalsCollector.DefineOneOfAnimalType<Caw>("Caw", "Caws");
            AnimalsCollector.DefineOneOfAnimalType<Sheep>("Sheep", "Sheeps");

            Presenter.IntroduceAnimals(AnimalsCollector.Animals);
            Presenter.WaitForUser();
        }
    }
}
