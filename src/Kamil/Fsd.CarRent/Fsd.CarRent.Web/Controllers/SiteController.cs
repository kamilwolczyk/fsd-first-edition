using System.Web.Mvc;

namespace Fsd.CarRent.Web.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult PublicPage()
        {
            return Redirect("~/content/public/index.html");
        }

        public ActionResult AdminPage()
        {
            return Redirect("~/content/admin/index.html");
        }
    }
}