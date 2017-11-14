using System;
using UnityProofOfConcept.Core.DTO;

namespace UnityProofOfConcept.Core.Services
{
    public interface IStampService
    {
        StampDTO GetStamp(DateTime time);
    }
}