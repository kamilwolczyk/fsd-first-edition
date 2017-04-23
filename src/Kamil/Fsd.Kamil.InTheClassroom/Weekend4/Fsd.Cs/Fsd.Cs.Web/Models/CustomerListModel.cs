using System.Collections.Generic;

namespace Fsd.Cs.Web.Models
{
    public class CustomerListModel
    {
        public IEnumerable<CustomerModel> Customers { get; set; }
    }
}