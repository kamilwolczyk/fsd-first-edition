using FarmGenerator.Interfaces;

namespace FarmGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter.ShowIntroduction();

            var animals = AnimalCreator.ZooCreator();

            AnimalPresenter.AnimalsGiveVoice(animals);
            Presenter.WaitForUser();
        }
    }
}
