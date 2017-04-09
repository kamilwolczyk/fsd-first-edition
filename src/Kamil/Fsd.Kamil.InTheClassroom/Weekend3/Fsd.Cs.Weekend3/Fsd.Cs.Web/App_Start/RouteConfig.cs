using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Cs.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Start", "", new { controller="HelloWorld", action="Start"});
            routes.MapRoute("Date", "data/{action}/{type}", new { controller="Date", type=UrlParameter.Optional});
            routes.MapRoute("Math", "{action}/{number1}/{number2}", new { controller = "Math", number2 = UrlParameter.Optional });
            routes.MapRoute("TestCtrlActions", "akcje/{action}", new { controller= "MyActionTest" });
            routes.MapRoute("Test1", "moja/aplikacja/{controller}/{action}/{name}", new { name=UrlParameter.Optional });
        }
    }
}
