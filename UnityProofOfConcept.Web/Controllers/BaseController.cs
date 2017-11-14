using System.Web.Http;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Web.Controllers
{
    public abstract class BaseController : ApiController
    {
        protected readonly ISecurityService _securityManager;

        public BaseController(ISecurityService securityManager)
        {
            _securityManager = securityManager;
        }
    }
}