using System.Collections.Generic;

namespace Fsd.Maciek.Cs.Ex4.Web.Models
{
    public class ProductListWebModel
    {
       public IEnumerable<ProductWebModel> Products { get; internal set; }
    }
}