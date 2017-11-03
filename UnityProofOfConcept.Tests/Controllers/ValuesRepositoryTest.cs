﻿using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.App;

namespace UnityProofOfConcept.Tests.Controllers
{
    [TestClass]
    public class ValuesRepositoryTest
    {
        [TestMethod]
        public void GetAll()
        {
            var dataAccessMock = new Mock<IDataAccess>();
            var sut = new ValuesRepository(dataAccessMock.Object);
            List<string> result = sut.GetAll().ToList();
            result.Should().HaveCount(8);
            result[5].Should().NotBeNullOrWhiteSpace();
            result[6].Should().BeNullOrWhiteSpace();
            result[7].Should().BeNullOrWhiteSpace();
        }
    }
}