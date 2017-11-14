using System.Web.Http;
using Microsoft.Practices.Unity;
using Unity;
using Unity.Lifetime;
using Unity.RegistrationByConvention;
using Unity.WebApi;
using UnityProofOfConcept.Core.Util;
using UnityProofOfConcept.Web.CompositionRoot;
using UnityProofOfConcept.Web.Util;

namespace UnityProofOfConcept.Web
{
    public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
            HttpConfiguration config = new HttpConfiguration();
            // Web API configuration and services
            var container = new UnityContainer();

            UnityConfig.RegisterComponents(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.DependencyResolver = new UnityDependencyResolver(container);
            return config;
        }
    }
}
