using Microsoft.Practices.Unity;
using MvcIOC.Models;
using System.Web.Configuration;
using System.Web.Mvc;
using Unity.Mvc5;

namespace MvcIOC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterTypes(AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);
            //container.RegisterType<IProteinRepository, ProteinRepository>(new InjectionConstructor("test data source"));
            container.RegisterInstance(typeof(IProteinRepository), new ProteinRepository("data source 123"));

            container.RegisterType<IProteinRepository, ProteinRepository>("Standard Repository",
                new InjectionConstructor("test"));

            container.RegisterType<IProteinRepository, DebugProteinRepository>("Debug Repository");

            var repoType = WebConfigurationManager.AppSettings["RepositoryType"];
            container.RegisterType<IProteinTrackerService, ProteinTrackerService>(
                new InjectionConstructor(container.Resolve<IProteinRepository>(repoType)));


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}