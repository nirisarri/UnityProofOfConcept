using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.RegistrationByConvention;
using UnityProofOfConcept.Core.Util;
using UnityProofOfConcept.Util;
using UnityProofOfConcept.Web.Util;

namespace UnityProofOfConcept.Web.CompositionRoot
{
    public static class UnityConfig
    {
        public static void RegisterComponents(IUnityContainer container)
        {
            container.RegisterTypes( 
                    AllClasses.FromLoadedAssemblies(),
                    WithMappings.FromMatchingInterface,
                    WithName.Default,
                    WithLifetime.Transient,
                    null,
                    true)
                .RegisterType<IHttpContextBaseWrapper, HttpContextBaseWrapper>(
                    new ContainerControlledLifetimeManager())
                .RegisterType<IDataAccess, NicolasDataAccess>(null, new PerResolveLifetimeManager(),
                    new InjectionFactory(c =>
                        {
                            Debug.WriteLine("Calling the InjectionFactory");
                            return NicolasDataAccess.Create(c.Resolve<IHttpContextBaseWrapper>());
                        }
                    ));
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

//        private static Assembly _coreAssembly;
//        private static IEnumerable<Type> GetInterface(Type type)
//        {
//            var i = _coreAssembly.DefinedTypes;
//        }
    }
}