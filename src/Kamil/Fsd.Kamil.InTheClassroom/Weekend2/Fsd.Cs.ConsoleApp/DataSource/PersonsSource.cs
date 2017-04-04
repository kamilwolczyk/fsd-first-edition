using Fsd.Cs.ConsoleApp.Models.Persons;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Cs.ConsoleApp.DataSource
{
    public class PersonsSource
    {
        private IEnumerable<Person> _persons;

        public PersonsSource()
        {
            _persons = new Person[]
            {
                new BookReader("Marian Ziom", 42),
                new BookReader("Basia Zielińska", 17),
                new BookReader("Franciszek Gitara", 76),
                new LibraryWorker("Zenon Trąba", 36)
            };
        }

        public IEnumerable<LibraryWorker> GetWorkers()
        {
            return _persons
                .Where(person => person is LibraryWorker)
                .Select(person => person as LibraryWorker);
        }

        public IEnumerable<BookReader> GetReaders()
        {
            return _persons
                .Where(person => person is BookReader)
                .Select(person => person as BookReader);
        }
    }
}
