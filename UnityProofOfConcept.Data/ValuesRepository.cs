using System.Collections.Generic;
using UnityProofOfConcept.Core;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.DTO;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Data
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly IDataAccess _dataAccess;

        public ValuesRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public IEnumerable<ValueDTO> GetAll()
        {

            var result = new List<string>
            {
                "uno",
                "dos",
                "tres",
                "cuatro",
                "cinco",
                "seis",
                _dataAccess.Signature,
                _dataAccess.GetFromAccess(20)
            };
            foreach (var item in result)
            {
                yield return new ValueDTO(item);
            }
        }
    }
}