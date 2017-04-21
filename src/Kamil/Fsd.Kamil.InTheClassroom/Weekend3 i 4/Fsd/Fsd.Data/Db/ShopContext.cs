using Fsd.Data.Entities.Products;
using Fsd.Data.Entities.Users;
using System.Data.Entity;

namespace Fsd.Data.Db
{
    public class ShopContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Monitor> Monitors { get; set; }
        public DbSet<Mouse> Mouses { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Tablet> Tablets { get; set; }

        public ShopContext() : base("ShopContext")
        { }
    }
}
