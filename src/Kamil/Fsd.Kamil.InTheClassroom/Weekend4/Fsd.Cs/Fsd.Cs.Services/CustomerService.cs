using Fsd.Cs.Data.Entities;
using System.Collections.Generic;
using Fsd.Cs.Data.Sql;

namespace Fsd.Cs.Services
{
    public class CustomerService : ICustomerService
    {
        private Repository<Customer> _repository;

        public CustomerService()
        {
            _repository = new Repository<Customer>("Customers", "Id", reader => new Customer
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Age = (int)reader["Age"],
                Email = (string)reader["Email"],
                Password = (string)reader["Password"]
            });
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAllData();
        }

        public Customer GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
