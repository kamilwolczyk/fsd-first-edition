using Fsd.Cs.Data.Entities;
using Fsd.Cs.Services;
using Fsd.Cs.Web.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public ActionResult List()
        {
            CustomerListModel model = new CustomerListModel
            {
                Customers = _customerService.GetAllCustomers().Select(MapCustomerToModel)
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int customerId)
        {
            CustomerModel customerModel = MapCustomerToModel(_customerService.GetById(customerId));
            return View(customerModel);
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //todo: save in the db

            Random rand = new Random();
            int random = rand.Next(0, 100);

            return RedirectToAction("SaveSuccess", new { reservationNumber = random });
        }

        [HttpGet]
        public ActionResult SaveSuccess(int reservationNumber)
        {
            return View(reservationNumber);
        }

        private CustomerModel MapCustomerToModel(Customer entity)
        {
            return new CustomerModel
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Age = entity.Age,
                Email = entity.Email,
                Password = entity.Password,
            };
        }
    }
}