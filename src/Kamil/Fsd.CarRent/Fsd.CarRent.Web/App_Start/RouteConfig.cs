using System.Web.Mvc;
using System.Web.Routing;

namespace Fsd.CarRent.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("");

            routes.MapRoute("Public", "{controller}/{action}", new { controller = "Site", action = "PublicPage" });
        }
    }
}
