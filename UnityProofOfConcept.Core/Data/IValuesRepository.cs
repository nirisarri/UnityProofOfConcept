using System.Collections.Generic;
using UnityProofOfConcept.Core.DTO;

namespace UnityProofOfConcept.Core.Data
{
    public interface IValuesRepository
    {
        IEnumerable<ValueDTO> GetAll();
    }
}