using System.Collections.Generic;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Services
{
    public class ValuesService : IValuesService
    {
        private readonly IValuesRepository _repos;

        public ValuesService(IValuesRepository repos)
        {
            _repos = repos;
        }
        public IEnumerable<string> GetValues()
        {
            return _repos.GetAll();
        }
    }
}