using Fsd.Cs.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Cs.Services
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    FirstName = "Kamil",
                    LastName = "Wołczyk",
                    Email = "k.wolczyk@headchannel.co.uk",
                    Age = 28,
                    Password = "nicTuNIeMa;p"
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Email = "jkowalski@gmail.com",
                    Age = 60,
                    Password = "qwerty"
                }
            };
        }
    }
}
