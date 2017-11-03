using System.Collections.Generic;
using System.Linq;

namespace UnityProofOfConcept.App
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