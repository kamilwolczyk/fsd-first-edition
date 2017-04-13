using Fsd.Maciek.Cs.Ex3.Interfaces;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3
{
    public class Shop : IShop
    {
        public Salesman Salesman { get; internal set; }
        public Warehouse Warehouse { get; internal set; }

        public Shop(Salesman salesman, Warehouse warehouse)
        {
            Salesman = salesman;
            Warehouse = warehouse;
        }

        public void HandleCustomer()
        {
            Salesman.WelcomeCustomer();

            switch (Salesman.AskAboutAction())
            {
                case SalesAction.NoAction:
                    Salesman.AskAboutAction();
                    break;
                case SalesAction.AddNewProduct:
                    Warehouse.AddProductToWarehouse();
                    if (Salesman.AskAboutContinuation())
                        HandleCustomer();
                    break;
                case SalesAction.BuySomething:
                    Salesman.TrySellProducts(Warehouse);
                    if (Salesman.AskAboutContinuation())
                        HandleCustomer();
                    break;
                case SalesAction.CheckWarehouseState:
                    Salesman.ShowProducts(Warehouse);
                    if (Salesman.AskAboutContinuation())
                        HandleCustomer();
                    break;
                case SalesAction.LeaveShop:
                    break;

                default:
                    HandleCustomer();
                    break;
            }
        }
    }
}
