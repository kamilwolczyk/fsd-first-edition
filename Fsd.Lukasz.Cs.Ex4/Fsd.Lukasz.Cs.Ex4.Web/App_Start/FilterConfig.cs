using System.Web;
using System.Web.Mvc;

namespace Fsd.Lukasz.Cs.Ex4.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
