using Fsd.Lukasz.Cs3.Models;

namespace Fsd.Lukasz.Cs3
{
    interface IShop
    {
        bool Leave { get; set; }
        //void WarehouseState();
        void AddNewProduct(IProduct product);
        void Buy(IProduct product);
       
    }
}
