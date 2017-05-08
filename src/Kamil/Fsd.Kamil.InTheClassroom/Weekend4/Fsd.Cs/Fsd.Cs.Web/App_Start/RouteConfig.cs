using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.Cs.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Team", "team/{action}", new { controller = "Team", action = "List" });
            routes.MapRoute("Default", "", new { controller = "Team", action = "List" });
        }
    }
}
