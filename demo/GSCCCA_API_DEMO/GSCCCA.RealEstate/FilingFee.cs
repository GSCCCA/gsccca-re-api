using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a Filing Fee associated with the recording of a Real Estate Document
    /// </summary>
    public class FilingFee
    {
        private string feeDescription = string.Empty;
        private double feeAmount = 0.0;

        /// <summary>
        /// Creates an empty filing fee
        /// </summary>
        public FilingFee() { }

        /// <summary>
        /// Creates a filing fee from the Amount and Description provided
        /// </summary>
        /// <param name="amount">The amount of the filing fee</param>
        /// <param name="description">A description of the fee</param>
        public FilingFee(double amount, string description)
        {
            this.feeAmount = amount;
            this.feeDescription = description;
        }

        /// <summary>
        /// Gets / sets the Fee Description
        /// </summary>
        public string FeeDescription
        {
            get { return this.feeDescription; }
            set { this.feeDescription = value; }
        }

        /// <summary>
        /// Gets/sets the Fee Amount
        /// </summary>
        public double FeeAmount
        {
            get { return this.feeAmount; }
            set { this.feeAmount = value; }
        }
    }
}
