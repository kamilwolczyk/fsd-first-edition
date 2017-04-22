using System.Web.Mvc;

namespace Fsd.Maciek.Cs.Ex4.Web.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View("View");
        }
    }
}