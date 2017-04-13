using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3.Interfaces
{
    public interface ISalesman
    {
        void WelcomeCustomer();
        SalesAction AskAboutAction();
        void ShowProducts(Warehouse warehouse);
        void TrySellProducts(Warehouse warehouse);
    }
}
