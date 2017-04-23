using Fsd.Cs.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Cs.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
    }
}
