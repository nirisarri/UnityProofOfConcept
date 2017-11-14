using System.Collections.Generic;

namespace UnityProofOfConcept.Core.Data
{
    public interface IValuesRepository
    {
        IEnumerable<string> GetAll();
    }
}