namespace UnityProofOfConcept.App
{
    public interface IDataAccess
    {
        int MaxItems { get; }
        string  Signature { get; }

        string GetFromAccess(int x);
    }
}