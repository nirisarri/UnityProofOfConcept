using System.Net.Http;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using UnityProofOfConcept.App;
using System.Diagnostics;
namespace UnityProofOfConcept
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            container
                .RegisterTypes(
                    AllClasses.FromLoadedAssemblies(),
                    WithMappings.FromMatchingInterface,
                    WithName.Default,
                    WithLifetime.Transient)
                .RegisterType<IDataAccess, DataAccess>(null, new ContainerControlledLifetimeManager(),
                    new InjectionFactory(c =>
                        {
                            Debug.WriteLine("Calling the InjectionFactory");
                            return DataAccess.Create(c.Resolve<IHttpContextBaseWrapper>());
                    }
                    ))
                .RegisterType<IHttpContextBaseWrapper, HttpContextBaseWrapper>(new ContainerControlledLifetimeManager());
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}