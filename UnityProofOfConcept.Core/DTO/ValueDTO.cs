using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityProofOfConcept.Core.DTO
{
    public class ValueDTO
    {

        public ValueDTO(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
