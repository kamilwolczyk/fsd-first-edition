﻿namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Sell seller = new Sell();
           
            seller.CustomerService(warehouse);
        }
    }
}
