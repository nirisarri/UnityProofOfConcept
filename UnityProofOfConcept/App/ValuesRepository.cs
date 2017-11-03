using System;
using System.Collections.Generic;

namespace UnityProofOfConcept.App
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly IDataAccess _dataAccess;

        public ValuesRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public IEnumerable<string> GetAll()
        {

            var result = new List<string>{"uno", "dos", "tres", "cuatro", "cinco", "seis"};
            result.Add(_dataAccess.Signature);
            result.Add(_dataAccess.GetFromAccess(20));
            return result;
        }
    }
}