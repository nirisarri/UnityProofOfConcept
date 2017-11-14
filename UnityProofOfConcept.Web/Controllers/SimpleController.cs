using System.Web.Http;

namespace UnityProofOfConcept.Web.Controllers
{
    public class SimpleController : ApiController
    {
        public string GetAll()
        {
            return "Hey!";
        }
    }
}
