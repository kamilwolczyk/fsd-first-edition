using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Count = new MemoryProductService().GetAllProducts().Count();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Some information about me.";

            return View();
        }
    }
}