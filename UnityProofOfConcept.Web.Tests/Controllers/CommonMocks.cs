using Moq;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Web.Tests.Controllers
{
    public static class CommonMocks
    {
        public static Mock<ISecurityService> SecurityMock => new Mock<ISecurityService>(); 
    }
}