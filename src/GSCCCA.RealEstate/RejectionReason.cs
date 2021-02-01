using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a reason a filing was rejected by a clerk
    /// </summary>
    public class RejectionReason
    {
        private string reasonText = string.Empty;
        private int reasonCode = 0;

        /// <summary>
        /// Creates an uninitialized RejectionReason
        /// </summary>
        public RejectionReason(){}

        /// <summary>
        /// Creates a RejectionReason with the Reason Text set
        /// </summary>
        /// <param name="reason">The reason text of the rejection</param>
        public RejectionReason(string reason)
        {
            this.reasonText = reason;
        }

        /// <summary>
        /// Creates a RejectionReason with the reason text and reason code set
        /// </summary>
        /// <param name="reason">The reason text of the rejection</param>
        /// <param name="reasonCode">A numeric code associated with the rejection</param>
        public RejectionReason(string reason, int reasonCode)
        {
            this.reasonText = reason;
            this.reasonCode = reasonCode;
        }

        /// <summary>
        /// Gets/sets the reason text for the rejection
        /// </summary>
        public string Reason
        {
            get { return this.reasonText; }
            set { this.reasonText = value; }
        }

        /// <summary>
        /// Gets/sets a numeric code associated with the rejection
        /// </summary>
        public string Code
        {
            get { return this.Code; }
            set { this.Code = value; }
        }
    }
}
