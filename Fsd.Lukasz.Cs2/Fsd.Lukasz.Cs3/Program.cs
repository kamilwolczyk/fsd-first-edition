using Fsd.Lukasz.Cs3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3
{
    class Program
    {
        private static IShop Shop;
        private static Presenter Presenter;
        private static Data ShopStorage;
        static void Main(string[] args)
        {
            ShopStorage = Data.Instance;
            ShopStorage.products = new FakeData().GetData();

            Shop = new Shop();
            Presenter = new Presenter();

            do
            {
                MainScreen();
            } while (!Shop.Leave);

        }

        private static void MainScreen()
        {
            CheckDecison(Presenter.MainScreen());
        }

        static void CheckDecison(ShopAction Decision)
        {
            switch (Decision)
            {
                case ShopAction.Buy:
                    Shop.Buy(Presenter.BuyProduct(ShopStorage.GetDictionary()));
                    break;
                case ShopAction.ShowWarehouse:
                    Presenter.ShowProducts(ShopStorage.products);
                    break;
                case ShopAction.AddNewProduct:
                    Shop.AddNewProduct(Presenter.AddNewProduct());
                    break;
                case ShopAction.Leave:
                    Shop.Leave = true;
                    break;
                default:
                    break;
            }
        }

        
    }
}

