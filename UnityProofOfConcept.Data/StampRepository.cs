using System;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Data
{
    public class StampRepository : IStampRepository
    {
        private readonly IDataAccess _dataAccess;

        public StampRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess ?? throw new ArgumentNullException(nameof(dataAccess));
        }

        public string GetAll(string initialStamp)
        {
            return $"~~~~{_dataAccess.Signature}~~{initialStamp}~~~~";
        }
    }
}