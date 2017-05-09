using Autofac;
using Autofac.Integration.Mvc;
using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.App_Start
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SqlProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<TypeService<GraphicCard>>().As<ITypesService<GraphicCard>>().InstancePerLifetimeScope();
            builder.RegisterType<TypeService<Monitor>>().As<ITypesService<Monitor>>().InstancePerLifetimeScope();
            builder.RegisterType<TypeService<Motherboard>>().As<ITypesService<Motherboard>>().InstancePerLifetimeScope();
            builder.RegisterType<TypeService<Processor>>().As<ITypesService<Processor>>().InstancePerLifetimeScope();
            builder.RegisterType<TypeService<SoundCard>>().As<ITypesService<SoundCard>>().InstancePerLifetimeScope();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}