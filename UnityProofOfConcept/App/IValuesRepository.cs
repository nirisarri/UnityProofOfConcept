using System.Collections.Generic;

namespace UnityProofOfConcept.App
{
    public interface IValuesRepository
    {
        IEnumerable<string> GetAll();
    }
}