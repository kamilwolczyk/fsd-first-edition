using System.Collections.Generic;
using System.Web.Mvc;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using Fsd.Maciek.Cs.Ex4.Services;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;

namespace Fsd.Maciek.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            List<Product> listofProducts = (List<Product>)_productService.GetListOfProducts();
            int numberOfProducts = listofProducts.Count;

            return View(numberOfProducts);
        }
    }
}