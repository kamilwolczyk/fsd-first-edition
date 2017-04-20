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
            MockProductService ProductService = new MockProductService();
            List<Product> ListofProducts = (List<Product>)ProductService.GetListOfProducts();
            int numberOfProducts = ListofProducts.Count;

            return View(numberOfProducts);
        }
    }
}