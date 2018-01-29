using Fsd.CarRent.Web.Models.Cars;
using System.Collections.Generic;
using System.Web.Http;

namespace Fsd.CarRent.Web.Controllers.Api
{
    public class CarApiController : ApiController
    {
        [ActionName("summary-list")]
        public IEnumerable<CarSummary> GetCarSummaries()
        {
            return new List<CarSummary>
            {
                new CarSummary
                {
                    Id = 1,
                    Producer = "Audi",
                    Model = "A4",
                    Price= 960
                }
            };
        }
    }
}
