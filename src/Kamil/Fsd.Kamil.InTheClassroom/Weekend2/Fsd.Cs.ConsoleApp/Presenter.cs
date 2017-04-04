using Fsd.Cs.ConsoleApp.Models;
using System;

namespace Fsd.Cs.ConsoleApp
{
    public static class Presenter
    {
        public static void ShowIntroduction(string developerName, DateTime currentDate)
        {
            Console.WriteLine($"{developerName}'s library");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Today is {currentDate.ToShortDateString()}\n\n");
        }

        internal static void WaitForUser()
        {
            Console.ReadKey();
        }

        public static void ShowBookList(Book[] books)
        {
            Console.WriteLine("Available books:\n");

            Console.WriteLine(String.Format("{0,3}{1,50}{2,7}{3,10}", "No", "Title", "Pages", "Type"));
            Console.WriteLine("-------------------------------------------------------------------------");

            for (var i = 0; i < books.Length; i++)
            {
                Book book = books[i];
                Console.WriteLine(String.Format("{0,3}{1,50}{2,7}{3,10}", i + 1, book.Title, book.PageCount, book.Type));
            }
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
