using System;
using System.Diagnostics;

namespace UnityProofOfConcept.App
{
    public class DataAccess : IDataAccess
    {
        private static int _instanceId;
        public static IDataAccess Create(IHttpContextBaseWrapper context)
        {
            return int.TryParse(context.QueryString["n"], out var s) ? new DataAccess(s) : new DataAccess(999);
        }

        public DataAccess() : this(1)
        {
        }
        private DataAccess(int numberForSignature)
        {
            _instanceId = new Random().Next();
            Debug.WriteLine($"Creating DataAccess Object! ({_instanceId} instanceId)");
            Signature = $"{numberForSignature:000000}[{_instanceId} DataAccess instance ID]";
        }

        public int MaxItems => 10;
        public string Signature { get; }
        public string GetFromAccess(int x)
        {
            return $"{Signature} - {x}";
        }
    }
}