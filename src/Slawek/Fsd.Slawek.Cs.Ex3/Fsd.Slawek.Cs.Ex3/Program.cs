using Fsd.Slawek.Cs.Ex3.Models;

namespace Fsd.Slawek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFile data = new DatabaseFile(); //Baza z pliku
            //Database data = new Database();       //Baza z klasy
            Presenter presenter = new Presenter(data);
            presenter.ShowMenu();
        }
    }
}
