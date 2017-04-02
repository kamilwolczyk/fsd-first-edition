using Fsd.Cs.ConsoleApp.Models.Persons;

namespace Fsd.Cs.ConsoleApp.Models
{
    public class RentInfo
    {
        public Person Person{ get; set; }

        public Book Book { get; set; }

        public bool IsEnded { get; set; }

        public RentInfo(Person person, Book book)
        {
            Person = person;
            Book = book;
        }
    }
}
