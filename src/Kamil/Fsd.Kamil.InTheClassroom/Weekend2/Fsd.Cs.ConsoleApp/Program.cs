using Fsd.Cs.ConsoleApp.DataSource;
using Fsd.Cs.ConsoleApp.Models;
using Fsd.Cs.ConsoleApp.Models.Persons;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Cs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksSource bookSource = new BooksSource();
            PersonsSource personSource = new PersonsSource();

            LibraryWorker worker = personSource.GetWorkers().First();
            IEnumerable<BookReader> readers = personSource.GetReaders();

            Library library = new Library(bookSource.GetBooks());

            BookReader matureReader = readers.First(reader => reader.Age > 18);
            BookReader immatureReader = readers.First(reader => reader.Age < 18);

            library.Open(worker);

            TryReantABook(library, "Stary człowiek i morze", matureReader);      //ok
            TryReantABook(library, "The Ring", immatureReader);                  // error - immature
            TryReantABook(library, "The Ring", matureReader);                    // ok
            TryReantABook(library, "Stary człowiek i morze", matureReader);      //error - rented

            library.Close(worker);
            TryReantABook(library, "O psie który jeździł koleją", matureReader);  //error - closed
            Presenter.WaitForUser();
        }

        static void TryReantABook(Library library, string title, BookReader reader)
        {
            RentResult result = library.RentBook(title, reader);

            string message = result.Book != null ?
                $"Book {result.Book.Title} has been rented" :
                $"Fuck you {reader.FirstName} {reader.LastName}: {result.Message}";

            Presenter.ShowMessage(message);
        }
    }
}
