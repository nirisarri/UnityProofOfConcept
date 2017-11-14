using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.DTO;

namespace UnityProofOfConcept.Services.Tests
{
    [TestClass]
    public class ValuesServiceTest
    {
        [TestMethod]
        public void GetValues()
        {
            var reposMock = new Mock<IValuesRepository>();
            reposMock.Setup(repos => repos.GetAll()).Returns(new List<ValueDTO> {new ValueDTO("value")});
            var sut = new ValuesService(reposMock.Object);

            var result = sut.GetValues();
            result.Should().HaveCount(1);
        }
    }
}