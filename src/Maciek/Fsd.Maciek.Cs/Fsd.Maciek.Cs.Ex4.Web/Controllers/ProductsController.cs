using Fsd.Maciek.Cs.Ex4.Services;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;
using Fsd.Maciek.Cs.Ex4.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Maciek.Cs.Ex4.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page = 1, int items = 20)
        {
            ProductListWebModel productModel = new ProductListWebModel()
            {
                Products = _productService.GetListOfProducts().ToList()
                    .Skip((page - 1) * items).Take(items)
                    .Select(item => new ProductWebModel
                    {
                        Manufacturer = item.Manufacturer,
                        Model = item.Model,
                        Price = item.Price,
                        ProductionYear = item.ProductionYear,
                        ProductType = item.ProductType.ToString()
                    })
            };

            return View(productModel);
        }
    }
}
