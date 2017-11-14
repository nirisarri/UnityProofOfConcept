using System.Collections.Generic;
using UnityProofOfConcept.Core.DTO;

namespace UnityProofOfConcept.Core.Services
{
    public interface IValuesService
    {
        IEnumerable<ValueDTO> GetValues();
    }
}
