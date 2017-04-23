using Fsd.Cs.Services;
using Fsd.Cs.Web.Extensions;
using Fsd.Cs.Web.Models;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class HomeController : Controller
    {
        private IContentService _contentService;

        public HomeController(IContentService contentService)
        {
            _contentService = contentService;
        }

        public ActionResult Index()
        {
            string x = "hello, world!";
            
            string resultString = x.AddNamePrefix();
            
            return View(new PageModel
            {
                Introduction = _contentService.GetIntroduction()
            });
        }
    }
}