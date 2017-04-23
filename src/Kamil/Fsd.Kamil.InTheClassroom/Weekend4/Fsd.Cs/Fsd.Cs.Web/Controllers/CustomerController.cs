using Fsd.Cs.Web.Models;
using System;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CustomerModel customer1 = new CustomerModel
            {
                FirstName = "Kamil2",
                LastName = "Wołczyk",
                Email = "k.wolczyk@headchannel.co.uk",
                Age = 28,
                Password = "nicTuNIeMa;p"
            };

            return View(customer1);
        }

        [HttpPost]
        public ActionResult Index(CustomerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //todo: save in the db

            Random rand = new Random();
            int random = rand.Next(0, 100);

            return RedirectToAction("SaveSuccess", new { reservationNumber = random, number2 = 5 });
        }

        [HttpGet]
        public ActionResult SaveSuccess(int reservationNumber, int number2)
        {
            return View(reservationNumber);
        }
    }
}