namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Seller seller = new Seller();
            seller.CustomerService(warehouse);
        }
    }
}
