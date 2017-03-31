using Fsd.Slawek.Cs.Ex3.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Fsd.Slawek.Cs.Ex3.Models
{
    public class Presenter
    {
        IDatabase data;
        UserService userService;
        Dictionary<int, Action<IDatabase>> menuMethods;

        public Presenter(IDatabase database)
        {
            data = database;
            userService = new UserService();
            menuMethods = new Dictionary<int, Action<IDatabase>>()
            {
                [1] = new Action<IDatabase>(BuyProduct),
                [2] = new Action<IDatabase>(ShowWarehouse),
                [3] = new Action<IDatabase>(AddProduct)
            };
        }

        private void CloseMe()
        {
            if (userService.WaitForUserExit()) return;
            ShowMenu();
        }
        
        public void ShowMenu()
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
            var nr = userService.GetSingleDigit(1, 4);
            Console.WriteLine();
            if (nr < 4) menuMethods[nr].DynamicInvoke(data);
            else CloseMe();
        }

        public void AddProduct(IDatabase database)
        {
            Console.Clear();
            var name = userService.GetName();
            var price = userService.GetPrice();
            var count = userService.GetQuantity();
            database.AddProduct(new Product(name, price), count);
            Console.WriteLine($"You have add products to Warehouse...");
            userService.WaitForUser();
            ShowMenu();
        }

        public void ShowProducts(IDatabase database)
        {
            Console.Clear();
            Console.WriteLine("Avaible products:");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-3}{1,30}{2,12}{3,13}", "|Nr", "Name", "Price", "Count |"));
            Console.WriteLine("---------------------------------------------------------|");
            for (int i = 0; i < database.Products.Count; i++)
            {       
                Console.WriteLine(string.Format("{0,-3}{1,30}{2,12:C}{3,13}", $"|{i + 1}", 
                                  database.Products[i].Item.Name, database.Products[i].Item.Price, $"{database.Products[i].Count} |"));
                Console.WriteLine("|--------------------------------------------------------|");
            }
        }

        public void ShowWarehouse(IDatabase data)
        {
            ShowProducts(data);
            userService.WaitForUser();
            ShowMenu();
        }

        public void BuyProduct(IDatabase database)
        {
            if (database.Products.Count == 0)
            {
                Console.WriteLine($"No products in Warehouse");
                userService.WaitForUser();
                ShowMenu();
                return;
            }
            ShowProducts(database);
            var nrProduct = userService.GetNumber(1, database.Products.Count);
            database.EditProduct(database.Products[nrProduct-1].Item, - 1);
            ShowMenu();
        }
    }
}
