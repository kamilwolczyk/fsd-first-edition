using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class MyActionTestController : Controller
    {
        // GET: Test
        [ActionName("pierwsza-akcja")]
        public string FromTestStart1(string name)
        {
            return $"Hello world from test: {name} [1]";
        }

        [ActionName("druga-akcja")]
        public string FromTestStart2(string name)
        {
            return $"Hello world from test: {name} [2]";
        }

        [ActionName("trzecia-akcja")]
        public string FromTestStart3(string name)
        {
            return $"Hello world from test: {name} [3]";
        }
    }
}