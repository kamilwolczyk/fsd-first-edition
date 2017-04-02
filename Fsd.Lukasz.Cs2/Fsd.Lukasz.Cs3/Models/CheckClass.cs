using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Lukasz.Cs3.Models
{
    static class CheckClass
    {
        public static bool CheckDecision(string decision)
        {
            if (CheckInt(decision))
            {
                if (Enum.IsDefined(typeof(ShopAction), Convert.ToInt32(decision)))
                {
                    //Console.WriteLine("jest git");
                    return true;
                }
            }
            return false;
        }

        public static bool CheckInt(string input)
        {
            int i;
            if (int.TryParse(input, out i))
            {
                return true;
            }
            return false;
        }

        public static bool CheckDecimal(string input)
        {
            decimal i;
            if (decimal.TryParse(input, out i))
            {
                return true;
            }
            return false;
        }
    }
}
