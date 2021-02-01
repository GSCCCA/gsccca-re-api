using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a Validation result returned from the ValidatePT61Status Method. This class is used to display important information from the method.
    /// </summary>
    public class PT61ValidationResult
    {
        public bool Valid { get; set; }
        public string CallStatus { get; set; }
        public string NewPT61Number { get; set; }
        public string RawXML { get; set; }

    }
}
