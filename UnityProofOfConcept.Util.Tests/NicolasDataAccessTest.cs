using System.Collections.Specialized;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Util.Tests
{
    [TestClass]
    public class NicolasDataAccessTest
    {
        [TestMethod]
        public void Create_query_string_setup()
        {
            var contextMock = new Mock<IHttpContextBaseWrapper>();
            var qs = new NameValueCollection {{"n", "10"}};
            contextMock.SetupGet(ctx => ctx.QueryString).Returns(qs);
            var sut = NicolasDataAccess.Create(contextMock.Object);
            sut.GetFromAccess(1).Should().StartWith("000010");
            sut.GetFromAccess(1).Should().EndWith(" - 1");
        }

        [TestMethod]
        public void Create_no_query_string()
        {
            var contextMock = new Mock<IHttpContextBaseWrapper>();
            var qs = new NameValueCollection();
            contextMock.SetupGet(ctx => ctx.QueryString).Returns(qs);
            var sut = NicolasDataAccess.Create(contextMock.Object);
            sut.GetFromAccess(9).Should().StartWith("000999");
            sut.GetFromAccess(9).Should().EndWith(" - 9");
        }

        [TestMethod]
        public void Constructor()
        {
            var sut = new NicolasDataAccess();
            sut.MaxItems.Should().Be(10);
            sut.Signature.Should().StartWith("000001");
            sut.GetFromAccess(99).Should().StartWith("000001");
            sut.GetFromAccess(99).Should().EndWith(" - 99");
        }
    }
}