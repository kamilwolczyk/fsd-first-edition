using System;
using Fsd.Maciek.Cs.Ex3.Interfaces;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3
{
    public class Salesman : ISalesman
    {
        public string Name { get; internal set; }

        public Salesman(string name)
        {
            Name = name;
        }

        public SalesAction AskAboutAction()
        {
            Presenter.AskCustomerAboutNeeds();
            try
            {
                switch (Presenter.GetDecision())
                {
                    case 1:
                        return SalesAction.BuySomething;
                    case 2:
                        return SalesAction.CheckWarehouseState;
                    case 3:
                        return SalesAction.AddNewProduct;
                    case 4:
                        return SalesAction.LeaveShop;
                    default:
                        return SalesAction.NoAction;
                }
            }
            catch (Exception e)
            {

                throw new ArgumentException($"Key cannot be parsed into decision. Details: {e.Message}");
            }
        }

        public void TrySellProducts(Warehouse warehouse)
        {
            string ProductName = Presenter.GetProductName();

            if (warehouse.IsProductInWarehouse(ProductName))
            warehouse.SellProductInWarehouse(ProductName);

        }

        public void ShowProducts(Warehouse warehouse)
        {
            Presenter.PresentProducts(warehouse.Products);
        }

        public bool AskAboutContinuation()
        {
            return Presenter.AskAboutContinuation();
        }

        public void WelcomeCustomer()
        {
            Presenter.RenderHeader();
            Presenter.WelcomeUserInShop(this);
        }
    }
}
