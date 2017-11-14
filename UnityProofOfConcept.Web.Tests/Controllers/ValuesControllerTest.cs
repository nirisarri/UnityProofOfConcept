using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.Core.DTO;
using UnityProofOfConcept.Core.Services;
using UnityProofOfConcept.Web.Controllers;

namespace UnityProofOfConcept.Web.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest 
    {
        private static ValuesController GetValuesController()
        {
            // Arrange
            var mock = new Mock<IValuesService>();
            mock.Setup(s => s.GetValues()).Returns(new List<ValueDTO>
            {
                new ValueDTO("value1"),
                new ValueDTO("value2")
            });
            ValuesController controller = new ValuesController(mock.Object, CommonMocks.SecurityMock.Object);
            return controller;
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            var controller = GetValuesController();

            // Act
            var result = controller.Get() as OkNegotiatedContentResult<IEnumerable<string>>;
            // Assert
            Assert.IsNotNull(result);
            var r = result.Content.ToList();
            Assert.AreEqual(2, r.Count);
            Assert.AreEqual("value1", r.ElementAt(0));
            Assert.AreEqual("value2", r.ElementAt(1));
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
