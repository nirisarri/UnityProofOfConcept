using System;
using UnityProofOfConcept.Core.Data;
using UnityProofOfConcept.Core.DTO;
using UnityProofOfConcept.Core.Services;

namespace UnityProofOfConcept.Services
{
    public class StampService : IStampService
    {
        private readonly IStampRepository _repos;

        public StampService(IStampRepository repos)
        {
            _repos = repos;
        }

        public StampDTO GetStamp(DateTime time)
        {
            return _repos.GetAll(time.ToString());
        }
    }
}