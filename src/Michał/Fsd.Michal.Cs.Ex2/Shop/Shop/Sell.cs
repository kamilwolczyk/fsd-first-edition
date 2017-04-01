using System;

namespace Shop
{
    public class Sell
    {
        public Warehouse warehouse { get; set; }

        Product product { get; set; }

        public void CustomerService(Warehouse warehouse)
        {
            string input;

            do
            {
                ShowMenuOptions();
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        warehouse.BuyProduct();
                        Console.WriteLine();
                        DoYouWantToLeaveShop();
                        break;

                    case "2":
                        Console.Clear();
                        warehouse.ShowProducts();
                        Console.WriteLine();
                        DoYouWantToLeaveShop();
                        break;

                    case "3":
                        warehouse.AddProduct(product);
                        Console.WriteLine();
                        DoYouWantToLeaveShop();
                        Console.Clear();
                        break;

                    case "4":
                        DoYouWantToLeaveShop();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("incorrect key - try again");
                        DoYouWantToLeaveShop();
                        break;

                }
            } while (true);
        }

        internal void ShowMenuOptions()
        {
            Console.WriteLine("what do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave");
            Console.WriteLine("Decision: ");
        }

        internal void DoYouWantToLeaveShop()
        {
            string input;

            Console.WriteLine("Do you want to leave shop?  [(Y)es]  [(N)o]");
            input = Console.ReadLine();

            switch (input)
            {
                case "y":
                case "Y":
                    Environment.Exit(0);
                    break;
                case "n":
                case "N":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Incorrect key, try again");
                    break;
            }
        }
    }
}
