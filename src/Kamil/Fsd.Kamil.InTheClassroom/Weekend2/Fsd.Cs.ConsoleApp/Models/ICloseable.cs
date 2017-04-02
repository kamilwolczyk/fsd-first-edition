using Fsd.Cs.ConsoleApp.Models.Persons;

namespace Fsd.Cs.ConsoleApp.Models
{
    public interface ICloseable
    {
        bool IsOpen { get; }

        void Open(LibraryWorker worker);

        void Close(LibraryWorker worker);
    }
}