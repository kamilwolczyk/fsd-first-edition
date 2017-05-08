using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Fsd.Cs.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace Fsd.Cs.Web
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ContentService>().As<IContentService>().InstancePerLifetimeScope();
            builder.RegisterType<TeamService>().As<ITeamService>().InstancePerLifetimeScope();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            var container = builder.Build();
            
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}