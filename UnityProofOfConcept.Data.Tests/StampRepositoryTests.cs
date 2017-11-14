using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Data.Tests
{
    [TestClass]
    public class StampRepositoryTests
    {
        private readonly Mock<IDataAccess> _dataAccessMock;

        public StampRepositoryTests()
        {
            _dataAccessMock = new Mock<IDataAccess>();
        }

        [TestMethod]
        public void GetAll_InitialStamp_Valid()
        {
            _dataAccessMock.SetupGet(x => x.Signature).Returns("Prefix");
            var sut = new StampRepository(_dataAccessMock.Object);

            var result = sut.GetAll("Suffix").Name;

            result.Should().StartWith("~~~~Prefix");
            result.Should().EndWith("Suffix~~~~");
        }

        [TestMethod]
        public void GetAll_InitialStamp_IsNull()
        {
            _dataAccessMock.SetupGet(x => x.Signature).Returns("Prefix");
            var sut = new StampRepository(_dataAccessMock.Object);

            var result = sut.GetAll(null).Name;

            result.Should().StartWith("~~~~Prefix");
            result.Should().EndWith("~~~~~~");
        }

        [TestMethod]
        public void StampRepos_DataAccess_null()
        {
            Action sut = () => new StampRepository(null);

            sut.ShouldThrow<ArgumentNullException>()
                .Where(x => x.ParamName.Equals("dataAccess"));
        }

    }
}