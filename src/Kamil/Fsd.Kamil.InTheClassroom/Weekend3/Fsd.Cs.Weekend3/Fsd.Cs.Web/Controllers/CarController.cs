using Fsd.Cs.Services.Cars;
using Fsd.Cs.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController()
        {
            _carService = new MockCarService();
        }

        public ActionResult List()
        {
            var listModel = new CarListModel
            {
                Title = "This is my car list",
                Cars = _carService.GetCars().Select(entity =>
                    new CarModel
                    {
                        Mark = entity.Brand,
                        Model = entity.Model,
                        Power = entity.Power,
                        Price = entity.Price
                    })
            };

            return View(listModel);
        }
    }
}