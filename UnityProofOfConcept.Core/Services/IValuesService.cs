using System.Collections.Generic;

namespace UnityProofOfConcept.Core.Services
{
    public interface IValuesService
    {
        IEnumerable<string> GetValues();
    }
}
