using Fsd.Cs.Web.Models;
using System;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            PersonModel kowalski = new PersonModel
            {
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = new DateTime(1980, 2, 15)
            };

            return View(kowalski);
        }
    }
}