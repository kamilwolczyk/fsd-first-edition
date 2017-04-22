using Fsd.Lukasz.Cs.Ex4.Services.Product;
using Fsd.Lukasz.Cs.Ex4.Web.Models;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Lukasz.Cs.Ex4.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductAndTypeService _productService;

        public ProductController()
        {
            _productService = new MockData();
        }

        // GET: Product
        public ActionResult List(int? page, int? items)
        {
            ProductView productView = new ProductView
            {
                Products = _productService.GetProducts().Select(x =>
                new ProductModel
                {
                    Producer = x.Producer,
                    Model = x.Model,
                    ProductionDate = x.ProductionDate,
                    Type = _productService.GetProductTypeName(x.Type),
                    Price = x.Price
                }).ToPagedList(page ?? 1, items ?? _productService.GetProducts().Count())
            };

            return View(productView);
        }
    }
}