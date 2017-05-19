using Fsd.Lukasz.Cs3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3
{
    public class Presenter
    {
        public void ShowProducts(List<IProduct> products)
        {
            //int width = 70;
            //int NameWidth = 70 - 9 - 6 - 3;
            Console.Clear();
            Console.WriteLine("PRODUCTS");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("|{0,51}|{1,9}|{2,6}|", "Name", "Price", "Count");
            foreach (IProduct product in products)
            {
                Console.WriteLine(new string('-', 70));
                Console.WriteLine($"|{product.Name.ToString(),51}|{product.Price.ToString(),9}|{product.Quantity.ToString(),6}|");
            }
            Console.WriteLine(new string('-', 70));
            Console.ReadKey();
        }

        public IProduct AddNewProduct()
        {
            IProduct product = new Product();
            string ConsoleInput;

            Console.Clear();
            Console.Write("Name: ");
            ConsoleInput = Console.ReadLine();
            product.Name = ConsoleInput;

            product.Price = AskDecimal("Invalid input.Try Again:", "Price:");
            product.Quantity = AskInteger("Invalid input.Try Again:", "Count:");

            return product;
        }

        public void Intro()
        {
            Console.WriteLine("Exercise 3 - Objects");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
        }

        public IProduct BuyProduct(List<string> products)
        {
            Console.Clear();

            Console.WriteLine("Delete - to reset searched name");
            Console.Write("What do you want buy? ");
            string nameOfProduct = string.Empty;
            AutocompleteConsole test = new AutocompleteConsole(products, ref nameOfProduct);

            IProduct product = new Product() { Name = nameOfProduct };
            product.Quantity = AskInteger("Invalid input.Try Again:", "Number of products:");

            Data storage = Data.Instance;

            if (product.Quantity > storage.products.Find(x => x.Name == product.Name).Quantity)
            {
                Console.WriteLine("Wrong number of product.");
                Console.WriteLine("We have available quantity of this product: " + storage.products.Find(x => x.Name == product.Name).Quantity + ".");
                Console.Read();
            }
            return product;
        }

        public ShopAction MainScreen()
        {
            Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.Write("Decision: ");

            string Decision = Console.ReadLine();
            //if (CheckInt(Decision))
            //            {
            //    return ((Convert.ToInt32(Decision) > 0) && (Convert.ToInt32(Decision) < 5)) ? Convert.ToInt32(Decision) : 0;
            //}
            //return 0;
            if (CheckClass.CheckDecision(Decision))
            {
                return (ShopAction)Enum.Parse(typeof(ShopAction), Decision);
            }
            return ShopAction.Default;

        }

        private void ClearLine(int row)
        {
            Console.CursorTop = row;
            Console.CursorLeft = 0;
            Console.Write("".PadRight(Console.BufferWidth));
            Console.CursorTop = row;
        }

        private int AskInteger(string errorMessage, string askMessage) //change name :>
        {
            string numberInput;
            int i = 0;
            do
            {
                if (i > 0)
                {
                    ClearLine(Console.CursorTop - 1);
                    //Console.CursorTop = Console.CursorTop - 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(errorMessage + " ");
                    Console.ResetColor();
                }
                Console.Write(askMessage + " ");
                numberInput = Console.ReadLine();
                i++;
            } while (!CheckClass.CheckInt(numberInput));

            return Convert.ToInt32(numberInput);
        }

        private decimal AskDecimal(string errorMessage, string askMessage) //change name :>
        {
            string numberInput;
            int i = 0;
            do
            {
                if (i > 0)
                {
                    ClearLine(Console.CursorTop - 1);
                    //Console.CursorTop = Console.CursorTop - 1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(errorMessage + " ");
                    Console.ResetColor();
                }
                Console.Write(askMessage + " ");
                numberInput = Console.ReadLine();
                i++;
            } while (!CheckClass.CheckDecimal(numberInput));

            return Convert.ToDecimal(numberInput);
        }
    }
}
