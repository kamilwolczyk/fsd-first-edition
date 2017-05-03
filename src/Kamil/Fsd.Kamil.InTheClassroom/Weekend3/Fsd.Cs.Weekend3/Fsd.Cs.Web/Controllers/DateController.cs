using Fsd.Cs.Services.Date;
using System;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class DateController : Controller
    {
        private DateTimeService _dateTimeService;

        public DateController()
        {
            _dateTimeService = new DateTimeService();
        }

        [ActionName("aktualna")]
        public string Current(string type)
        {
            string datePrefix = "Aktualnie jest:";

            switch (type)
            {
                case null:
                    return $"{datePrefix} {_dateTimeService.GetDateTimeString(DateTime.Now)}";
                case "data":
                    return $"{datePrefix} {_dateTimeService.GetDateString(DateTime.Now)}";
                case "godzina":
                    return $"{datePrefix} {_dateTimeService.GetTimeString(DateTime.Now)}";
                default:
                    return $"{datePrefix} {_dateTimeService.GetCustomString(DateTime.Now, type)}";
            }
        }
    }
}