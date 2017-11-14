using System;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.DTO;
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

        public StampDTO GetAll(string initialStamp)
        {
            return new StampDTO($"~~~~{_dataAccess.Signature}~~{initialStamp}~~~~");
        }
    }
}