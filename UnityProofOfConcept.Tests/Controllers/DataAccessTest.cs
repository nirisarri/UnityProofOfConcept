using System.Collections.Specialized;
using System.Dynamic;
using System.Web;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.App;

namespace UnityProofOfConcept.Tests.Controllers
{
    [TestClass]
    public class DataAccessTest
    {
        [TestMethod]
        public void Create_query_string_setup()
        {
            var contextMock = new Mock<IHttpContextBaseWrapper>();
            var qs = new NameValueCollection {{"n", "10"}};
            contextMock.SetupGet(ctx => ctx.QueryString).Returns(qs);
            var sut = DataAccess.Create(contextMock.Object);
            sut.GetFromAccess(1).Should().Be("000010 - 1");
        }

        [TestMethod]
        public void Create_no_query_string()
        {
            var contextMock = new Mock<IHttpContextBaseWrapper>();
            var qs = new NameValueCollection();
            contextMock.SetupGet(ctx => ctx.QueryString).Returns(qs);
            var sut = DataAccess.Create(contextMock.Object);
            sut.GetFromAccess(9).Should().Be("000999 - 9");
        }

        [TestMethod]
        public void Constructor()
        {
            var sut = new DataAccess();
            sut.MaxItems.Should().Be(10);
            sut.Signature.Should().Be("000001");
            sut.GetFromAccess(99).Should().Be("000001 - 99");
        }
    }
}