using System;
using System.Diagnostics;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Util
{
    public class NicolasDataAccess : IDataAccess
    {
        private static int _instanceId;
        public static IDataAccess Create(IHttpContextBaseWrapper context)
        {
            return int.TryParse(context.QueryString["n"], out var s) ? new NicolasDataAccess(s) : new NicolasDataAccess(999);
        }

        public NicolasDataAccess() : this(1)
        {
        }
        private NicolasDataAccess(int numberForSignature)
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