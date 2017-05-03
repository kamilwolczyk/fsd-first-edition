using Fsd.Cs.ConsoleApp.Models.Persons;

namespace Fsd.Cs.ConsoleApp.Models
{
    public interface IRental
    {
        RentResult RentBook(string title, BookReader reader);

        void ReturnBook(Book book, BookReader reader);
    }
}