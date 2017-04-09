using System;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class MathController : Controller
    {
        [ActionName("dodaj")]
        public int Add(int number1, int? number2)
        {
            if (!number2.HasValue)
                throw new ArgumentException("number2");

            return number1 + number2.Value;
        }

        [ActionName("odejmij")]
        public int Remove(int number1, int? number2)
        {
            if (!number2.HasValue)
                throw new ArgumentException("number2");

            return number1 + number2.Value;
        }

        [ActionName("razy-dwa")]
        public int Multiply(int number1)
        {
            return number1 * number1;
        }
    }
}