using Fsd.Cs.Web.Infractructure;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Start()
        {
            Database.ConnectByReader();

            return "Hello, world!";
        }

        public string Dupa()
        {
            return "Bida z nedzom!";
        }
    }
}