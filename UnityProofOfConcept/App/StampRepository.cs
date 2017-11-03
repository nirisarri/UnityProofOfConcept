namespace UnityProofOfConcept.App
{
    public class StampRepository : IStampRepository
    {
        private readonly IDataAccess _dataAccess;

        public StampRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string GetAll(string initialStamp)
        {
            return $"~~~~{_dataAccess.Signature}~~{initialStamp}~~~~";
        }
    }
}