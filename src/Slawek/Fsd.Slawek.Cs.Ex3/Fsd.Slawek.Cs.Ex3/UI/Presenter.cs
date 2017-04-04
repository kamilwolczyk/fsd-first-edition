using Fsd.Slawek.Cs.Ex3.Models;
using Fsd.Slawek.Cs.Ex3.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex3.UI
{
    public class Presenter
    {
        public void ShowMenu(IDatabase database)
        {
            Console.Clear();
            Console.WriteLine("---== Exercise 3 ==---");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy a product");
            Console.WriteLine("[2] Check our warehouse state");
            Console.WriteLine("[3] Add new product");
            Console.WriteLine("[4] Leave shop");
            Console.Write("Your decision(1-4): ");
            var nr = UserService.GetSingleDigit(1, 4);
            Console.WriteLine();
            GetMenuItem(nr-1).Invoke(database);
        }

        public void AddProduct(IDatabase database)
        {
            Console.Clear();
            Console.Write("Product name: ");
            var name = UserService.GetName();
            Console.Write("Product price: ");
            var price = UserService.GetPrice();
            Console.Write("Product number: ");
            var count = UserService.GetQuantity();
            database.AddProduct(new Product(name, price), count);
            Console.WriteLine($"You have add products to Warehouse...");
            WaitForUser();
            ShowMenu(database);
        }

        public void ShowProducts(IDatabase database)
        {
            Console.Clear();
            Console.WriteLine("Avaible products:");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-3}{1,30}{2,20}{3,13}", "|Nr", "Name", "Price", "Count |"));
            Console.WriteLine("-----------------------------------------------------------------|");
            for (int i = 0; i < database.Products.Count; i++)
            {       
                Console.WriteLine(string.Format("{0,-3}{1,30}{2,20:C}{3,13}", $"|{i + 1}", 
                                  database.Products[i].Item.Name, database.Products[i].Item.Price, $"{database.Products[i].Count} |"));
                Console.WriteLine("|----------------------------------------------------------------|");
            }
        }

        public void ShowWarehouse(IDatabase data)
        {
            ShowProducts(data);
            WaitForUser();
            ShowMenu(data);
        }

        public void BuyProduct(IDatabase database)
        {
            if (database.Products.Count == 0)
            {
                Console.WriteLine($"No products in Warehouse");
                WaitForUser();
                ShowMenu(database);
                return;
            }
            ShowProducts(database);
            Console.WriteLine($"Which product You want to buy? ({1} - {database.Products.Count}): ");
            var nrProduct = UserService.GetNumber(1, database.Products.Count);
            database.EditProduct(database.Products[nrProduct-1].Item, - 1);
            Console.WriteLine($"You have buy {database.Products[nrProduct-1].Item.Name}");
            WaitForUser();
            ShowMenu(database);
        }

        private void CloseMe(IDatabase database)
        {
            if (WaitForUserExit())
                return;
            ShowMenu(database);
        }

        public bool WaitForUserExit()
        {
            Console.WriteLine("Do You want to leave a shop? [(Y)es] or [(N)o] ");
            return UserService.GetYesOrNo() == 'Y';
        }

        public void WaitForUser()
        {
            Console.WriteLine("Press a key to return to the menu...");
            Console.ReadKey();
        }

        public Action<IDatabase> GetMenuItem(int nr)
        {
            IList<Action<IDatabase>> menuMethods;
            menuMethods = new List<Action<IDatabase>>()
            {
                new Action<IDatabase>(BuyProduct),
                new Action<IDatabase>(ShowWarehouse),
                new Action<IDatabase>(AddProduct),
                new Action<IDatabase>(CloseMe)
            };
            return menuMethods[nr];
        }
    }
}
