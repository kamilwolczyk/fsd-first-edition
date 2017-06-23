using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Slawek.Cs.Ex4.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Welcome", "welcome", new { controller = "Home", action = "Index" });
            routes.MapRoute("Results", "result", new { controller = "Result", action = "Success" });
            routes.MapRoute("About", "about", new { controller = "Home", action = "About" });
            routes.MapRoute("Single", "single", new { controller = "SingleProduct", action = "Index" });
            routes.MapRoute("Product", "products", new { controller = "Product", action = "Index" });
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
