using PagedList;

namespace Fsd.Lukasz.Cs.Ex4.Web.Models
{
    public class ProductView
    {
        public IPagedList<ProductModel> Products { get; set; }
    }
}