using System;

namespace UnityProofOfConcept.Core.Services
{
    public interface IStampService
    {
        string GetStamp(DateTime time);
    }
}