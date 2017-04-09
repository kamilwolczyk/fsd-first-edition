using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Start()
        {
            return "Hello, world!";
        }

        public string Dupa()
        {
            return "Bida z nedzom!";
        }
    }
}