using UnityProofOfConcept.Core.DTO;

namespace UnityProofOfConcept.Core.Data
{
    public interface IStampRepository
    {
        StampDTO GetAll(string initialStamp);
    }
}