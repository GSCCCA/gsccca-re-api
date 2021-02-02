using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCCCA.RealEstate
{
    public class PT61ValidationResult
    {
        public bool Valid { get; set; }
        public string CallStatus { get; set; }
        public string NewPT61Number { get; set; }
        public string RawXML { get; set; }

    }
}
