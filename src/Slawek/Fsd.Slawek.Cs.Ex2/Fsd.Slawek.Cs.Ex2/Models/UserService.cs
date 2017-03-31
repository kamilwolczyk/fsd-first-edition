using System;

namespace Fsd.Slawek.Cs.Ex2.Models
{
    public class UserService
    {
        public int GetNumber(string kind)
        {
            int number;
            string myNr;

            while(true)
            {
                Console.Write($"How many {kind}s you want: ");
                myNr = Console.ReadLine();
                if (int.TryParse(myNr, out number)) break;
                Console.WriteLine("That's not valid number. Please try again: ");
            }

            return number;
        }

        public string GetName(string type, int number)
        {
            string myName;

            while(true)
            {
                Console.Write($"Write name for {type}({number}): ");
                myName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(myName)) break;
                Console.WriteLine("That's not valid name. Please try again: ");
            }

            return myName.TrimEnd().TrimStart();
        }
    }
}
