using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnityProofOfConcept.App
{
    public interface IValuesService
    {
        IEnumerable<string> GetValues();
    }
}
