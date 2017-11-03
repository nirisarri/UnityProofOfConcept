namespace UnityProofOfConcept.App
{
    public class DataAccess : IDataAccess
    {

        public static IDataAccess Create(IHttpContextBaseWrapper context)
        {
            return int.TryParse(context.Request.QueryString["n"], out var s) ? new DataAccess(s) : new DataAccess(999);
        }

        public DataAccess() : this(1)
        {
        }
        private DataAccess(int numberForSignature)
        {
            Signature = $"{numberForSignature:000000}";
        }

        public int MaxItems => 10;
        public string Signature { get; }
        public string GetFromAccess(int x)
        {
            return $"{Signature} - {x}";
        }
    }
}