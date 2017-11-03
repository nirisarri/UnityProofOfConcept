using System.Net.Http;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using UnityProofOfConcept.App;

namespace UnityProofOfConcept
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            container
                .RegisterType<IValuesService, ValuesService>()
                .RegisterType<IValuesRepository, ValuesRepository>()
                .RegisterType<IDataAccess, DataAccess>(
                    new InjectionFactory(c => 
                        DataAccess.Create(c.Resolve<IHttpContextBaseWrapper>())))
                .RegisterType<IHttpContextBaseWrapper, HttpContextBaseWrapper>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}