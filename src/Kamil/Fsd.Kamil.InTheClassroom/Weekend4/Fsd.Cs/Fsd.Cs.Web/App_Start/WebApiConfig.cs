using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Fsd.Cs.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("team list", "api/teams", new { controller = "TeamApi", action = "List" });

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}");
        }
    }
}
