using System.Collections.Generic;
using Fsd.Maciek.Cs.Ex3.Models;

namespace Fsd.Maciek.Cs.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {        
            Salesman Salesman = new Salesman("Maciek");
            Warehouse Warehouse = new Warehouse(new List<Product>());
            Shop Shop = new Shop(Salesman, Warehouse);
            
            Shop.HandleCustomer();
        }
    }
}
