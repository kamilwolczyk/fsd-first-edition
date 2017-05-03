using Fsd.Data.Db;
using Fsd.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Ui.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ShopContext();

            context.Persons.Add(new Person
            {
                FirstName = "Kamil",
                LastName = "Wołczyk",
                EmailAddress = "k.wolczyk@headchannel.co.uk"
            });

            context.SaveChanges();
        }
    }
}
