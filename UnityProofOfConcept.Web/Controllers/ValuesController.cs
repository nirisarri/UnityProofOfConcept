using System.Collections.Generic;
using System.Web.Http;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Web.Controllers
{
    public class ValuesController : BaseController
    {
        private readonly IValuesService _service;

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _service.GetValues();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public ValuesController(IValuesService service)
        {
            _service = service;
        }
    }
}
