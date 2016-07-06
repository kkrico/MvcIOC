using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MvcIOC.Models;
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
		    //container.RegisterType<IProteinTrackerService, ProteinTrackerService>();
		    //container.RegisterType<IProteinRepository, ProteinRepository>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}