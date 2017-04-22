using System.Collections.Generic;
using System.Web.Mvc;
using Fsd.Maciek.Cs.Ex4.Data.Models;
using Fsd.Maciek.Cs.Ex4.Services;

namespace Fsd.Maciek.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MockProductService productService = new MockProductService();
            List<Product> listofProducts = (List<Product>)productService.GetListOfProducts();
            int numberOfProducts = listofProducts.Count;

            return View(numberOfProducts);
        }
    }
}