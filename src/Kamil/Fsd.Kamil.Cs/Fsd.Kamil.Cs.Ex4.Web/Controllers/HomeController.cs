using System.Web.Mvc;

namespace Fsd.Kamil.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}