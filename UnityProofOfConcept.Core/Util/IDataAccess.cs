namespace UnityProofOfConcept.Core.Util
{
    public interface IDataAccess
    {
        int MaxItems { get; }

        string  Signature { get; }

        string GetFromAccess(int x);
    }
}