using System;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class UserService
    {
        public int GetSingleDigit(int min, int max)
        {
            int number = 0;
            bool accept = false;
            while (!accept)
            {
                var readNumber = Console.ReadKey().KeyChar.ToString();
                int.TryParse(readNumber, out number);
                accept = (number >= min && number <= max);
                if (!accept) Console.Write("\b \b");
            }
            return number;
        }

        public int GetNumber(int min, int max)
        {
            int number = 0;
            bool accept = false;
            while (!accept)
            {
                Console.WriteLine($"Which product You want to buy? ({min} - {max}): ");
                var readNumber = Console.ReadLine();
                int.TryParse(readNumber, out number);
                accept = (number >= min && number <= max);
                if (!accept) Console.WriteLine("Wrong number! Try again...");
            }
            return number;
        }

        public decimal GetPrice()
        {
            decimal newPrice = 0;
            bool accept = false;
            
            while (!accept)
            {
                Console.Write("Product price: ");
                var readPrice = Console.ReadLine();
                accept = (decimal.TryParse(readPrice, out newPrice) && newPrice > 0);
                if (!accept) Console.WriteLine("Wrong price. Try again...");
            }
            return newPrice;
        }

        public int GetQuantity()
        {
            int newQuantity = 0;
            bool accept = false;

            while (!accept || newQuantity <= 0)
            {
                Console.Write("Product number: ");
                var readNumber = Console.ReadLine();
                accept = int.TryParse(readNumber, out newQuantity);
                if (!accept || newQuantity <= 0) Console.WriteLine("Wrong number. Try again...");
            }
            return newQuantity;
        }

        public string GetName()
        {
            string newName = null;
            bool accept = false;

            while (!accept)
            {
                Console.Write("Product name: ");
                var readName = Console.ReadLine();
                accept = (readName.Length > 3 && readName.Length < 25);
                if (!accept) Console.WriteLine("Wrong name(min.4 - max.25 characters) Try again...");
                newName = readName;
            }
            return newName;
        }

        public void WaitForUser()
        {
            Console.WriteLine("Press a key to return to the menu...");
            Console.ReadKey();
        }

        public char GetYesOrNo()
        {
            char readChar = default(char); 
            bool accept = false;
            while (!accept)
            {
                readChar = char.ToUpper(Console.ReadKey().KeyChar);
                accept = (readChar == 'Y' || readChar == 'N');
                if (!accept) Console.Write("\b \b");
            }
            return readChar;
        }

        public bool WaitForUserExit()
        {
            Console.WriteLine("Do You want to leave a shop? [(Y)es] or [(N)o] ");
            return GetYesOrNo() == 'Y';
        }
    }
}
