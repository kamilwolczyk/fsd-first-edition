using System;
using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3
{
    public class Presenter
    {
        public static void RenderHeader()
        {
            Console.Clear();
            Console.WriteLine($"Exercise 3 - Objects\n---------------------------------------------");
        }

        public static void AskCustomerAboutNeeds()
        {
            //Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.WriteLine("Decision: ");
        }

        public static int GetDecision()
        {
            try
            {
                return int.Parse(Console.ReadKey().KeyChar.ToString());
            }
            catch (Exception e)
            {
                throw new ArgumentException("Key cannot be parsed into integer.");
            }

        }

        public static Product GetProduct()
        {
            Console.Clear();
            Console.WriteLine("Define product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Define cost of the product: ");
            float price = float.Parse(Console.ReadLine());
            return new Product(name, price);
        }

        public static string GetProductName()
        {
            Console.WriteLine("What is name of product that you want to buy? ");
            return Console.ReadLine();
        }

        public static void PresentProducts(List<Product> products)
        {
            Console.Clear();

            foreach (var item in products)
            {
                Console.WriteLine($"Product o nazwie {item.Name} kosztuje {item.Cost}. Ilość na magazynie: {item.Count}");
            }
        }

        public static void WelcomeUserInShop(Salesman salesman)
        {
            Console.WriteLine($"Hi! I am {salesman.Name}. Welcome in Maciek's Shop!\n");
        }

        public static bool AskAboutContinuation()
        {
            Console.WriteLine("\nDo you want to leave a shop ? [(Y)es] [(N)o]");
            if (Console.ReadKey().Key != ConsoleKey.N)
                return false;

            return true;
        }

        public static void WaitForUser()
        {
            Console.ReadLine();
        }
    }
}
