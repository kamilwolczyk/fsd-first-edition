using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}