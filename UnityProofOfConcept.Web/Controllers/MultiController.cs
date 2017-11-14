using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Web.Controllers
{
    public class MultiController : BaseController
    {
        private readonly IValuesService _valuesService;
        private readonly IStampService _stampService;

        public MultiController(
            IValuesService valuesService, 
            IStampService stampService, 
            ISecurityService securityService) : base(securityService)
        {
            _valuesService = valuesService;
            _stampService = stampService;
        }

        public IHttpActionResult Get()
        {
            if (!_securityManager.Validate())
            {
                return  base.StatusCode(HttpStatusCode.Forbidden);
            }
            IList<string> result = new List<string> {_stampService.GetStamp(DateTime.Now).Name};
            result = result.Concat(_valuesService.GetValues().Select(x => x.Name)).ToList();
            result.Add(_stampService.GetStamp(DateTime.Now.AddMinutes(10)).Name);
            return Ok(result);
        }
    }
}