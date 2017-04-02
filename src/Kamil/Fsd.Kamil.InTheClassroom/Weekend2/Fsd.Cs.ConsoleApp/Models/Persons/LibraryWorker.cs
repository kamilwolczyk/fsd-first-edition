namespace Fsd.Cs.ConsoleApp.Models.Persons
{
    public class LibraryWorker : BookReader
    {
        public LibraryWorker(string fullName, int age)
            : base(fullName, age)
        {
        }
    }
}
