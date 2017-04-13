using Fsd.Slawek.Cs.Ex3.Models;
using Fsd.Slawek.Cs.Ex3.UI;

namespace Fsd.Slawek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFile data = new DatabaseFile(); //Baza z pliku
            //Database data = new Database();       //Baza z klasy
            Presenter presenter = new Presenter();
            presenter.ShowMenu(data);
        }
    }
}
