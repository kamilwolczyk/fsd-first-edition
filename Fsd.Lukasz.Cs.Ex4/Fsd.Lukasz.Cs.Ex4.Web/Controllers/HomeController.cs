using Fsd.Lukasz.Cs.Ex4.Services.Product;
using System.Web.Mvc;

namespace Fsd.Lukasz.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CountProducts = new MockData().Count();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}