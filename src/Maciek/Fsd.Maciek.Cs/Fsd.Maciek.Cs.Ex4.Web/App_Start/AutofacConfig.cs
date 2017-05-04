using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Maciek.Cs.Ex4.Services;
using Fsd.Maciek.Cs.Ex4.Services.Interfaces;

namespace Fsd.Maciek.Cs.Ex4.Web
{
    public class AutofacConfig
    {
        public static void Application_Start()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<MockProductService>().As<IProductService>().InstancePerLifetimeScope();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}