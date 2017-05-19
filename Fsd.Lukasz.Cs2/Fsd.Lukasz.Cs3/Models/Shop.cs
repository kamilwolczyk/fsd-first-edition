using Fsd.Lukasz.Cs3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3.Models
{
    public class Shop : IShop
    {
        bool IShop.Leave { get; set; }
        
        public void Buy(IProduct product)
        {
            Data Storage = Data.Instance;
            IProduct selectedProduct = Storage.products.Find(x => x.Name == product.Name);

            selectedProduct.Quantity -= product.Quantity;
        }

        public void AddNewProduct(IProduct product)
        {
            Data Storage = Data.Instance;
            Storage.products.Add(product);
        }
    }
}
