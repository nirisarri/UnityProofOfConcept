using System;

namespace UnityProofOfConcept.App
{
    public class StampService : IStampService
    {
        private readonly IStampRepository _repos;

        public StampService(IStampRepository repos)
        {
            _repos = repos;
        }

        public string GetStamp(DateTime time)
        {
            return _repos.GetAll(time.ToString());
        }
    }
}