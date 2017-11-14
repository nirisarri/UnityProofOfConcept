using System;
using System.Collections.Generic;
using System.Linq;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Web.Controllers
{
    public class MultiController : BaseController
    {
        private readonly IValuesService _valuesService;
        private readonly IStampService _stampService;

        public MultiController(IValuesService valuesService, IStampService stampService)
        {
            _valuesService = valuesService;
            _stampService = stampService;
        }

        public IEnumerable<string> Get()
        {
            IList<string> result = new List<string> {_stampService.GetStamp(DateTime.Now)};
            result = result.Concat(_valuesService.GetValues()).ToList();
            result.Add(_stampService.GetStamp(DateTime.Now.AddMinutes(10)));
            return result;
        }
    }
}