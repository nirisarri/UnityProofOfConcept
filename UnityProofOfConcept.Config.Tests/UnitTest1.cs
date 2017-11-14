using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using FluentAssertions;
using UnityProofOfConcept.Util;

namespace UnityProofOfConcept.Config.Tests
{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod0()
//        {
//            var w = new NicolasDataAccess();
//            w.Should().NotBeNull();
//            var sut = UnityConfig.ClassesFromLoadedAssemblies().ToList();
//            IEnumerable<string> assemblies = sut
//                .Select(x => x.Namespace)
//                .Where(x=>x.Contains("UnityProofOfConcept"))
//                .Distinct()
//                .ToList();
//            assemblies.Should().HaveCount(5);
//            IEnumerable<string> classes = sut
//                .Where(x=> x.Namespace.Contains("UnityProofOfConcept"))
//                .Select(x => x.Name);
//            classes.Should().Contain(x => x.Contains("StampService"));
//        }
//
//        [TestMethod]
//        public void TestMethod1()
//        {
//            var container = new UnityContainer();
//            UnityConfig.RegisterComponents(container);
//
//            container.Registrations.FirstOrDefault(x => x.RegisteredType.Name == "IStampService").Should().NotBeNull();
//        }
//    }
}
