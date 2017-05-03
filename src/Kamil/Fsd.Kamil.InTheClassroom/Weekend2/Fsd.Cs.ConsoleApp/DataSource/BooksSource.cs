using Fsd.Cs.ConsoleApp.Models;

namespace Fsd.Cs.ConsoleApp.DataSource
{
    public class BooksSource
    {
        public Book[] GetBooks()
        {
            return new Book[]
            {
                new Book("Stary człowiek i morze", 420, BookType.Comedy),
                new Book("The Ring", 370, BookType.Horror),
                new Book("O psie który jeździł koleją", 256, BookType.Comedy),
            };
        }
    }
}
