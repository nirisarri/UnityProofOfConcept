using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnityProofOfConcept;
using UnityProofOfConcept.App;
using UnityProofOfConcept.Controllers;

namespace UnityProofOfConcept.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            var controller = GetValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        private static ValuesController GetValuesController()
        {
// Arrange
            var da = new DataAccess();
            ValuesController controller = new ValuesController( new ValuesService(new ValuesRepository(da)));
            return controller;
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = GetValuesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = GetValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = GetValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = GetValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
