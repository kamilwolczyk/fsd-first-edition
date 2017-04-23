using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Cs.Services;
using System.Web.Mvc;

namespace Fsd.Cs.Web
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ContentService>().As<IContentService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerLifetimeScope();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}