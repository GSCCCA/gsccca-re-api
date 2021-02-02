using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSCCCA.RealEstate
{

    /// <summary>
    /// Defines a list of available docket types for recording
    /// </summary>
    public enum DOCKET_TYPES : int
    {
        /// <summary>
        /// Represents the DEED docket
        /// </summary>
        DEED, 
        
        /// <summary>
        /// Represents the LIEN docket
        /// </summary>
        LIEN, 
        
        /// <summary>
        /// Represents the PLAT docket
        /// </summary>
        PLAT,

        /// <summary>
        /// Reprensents an unassigned docket type value
        /// </summary>
        NON_ASSIGNED
    }


    /// <summary>
    /// Represents a recording endorsement for an accepted filing.  This class provides information about the book, page, docket, and recording date/time of a filing
    /// </summary>
    public class RecordingEndorsement
    {
        private string book = string.Empty;
        private string instrumentNumber = string.Empty;
        private string page = string.Empty;
        private DOCKET_TYPES docketType = DOCKET_TYPES.NON_ASSIGNED;
        private DateTime? fileDate = null;
        
        /// <summary>
        /// Creates an uninitialized RecordingEndorsement
        /// </summary>
        public RecordingEndorsement()
        {
            
        }


        /// <summary>
        /// Determines whether or not the RecordingEndorsement is fully populated and represents a valid endorsement
        /// </summary>
        /// <returns>True is the endorsement is valid, false otherwise</returns>
        public bool Validate()
        {
            bool isValid = false;

            //check fees
            if ((!string.IsNullOrEmpty(book) && !string.IsNullOrEmpty(page)
                && docketType != DOCKET_TYPES.NON_ASSIGNED
                && this.fileDate != null) || (!string.IsNullOrEmpty(this.instrumentNumber) && this.fileDate != null) )
            {
                isValid = true;
            }
            return isValid;

        }

        /// <summary>
        /// Gets / sets a nullable filing date value of the endorsement
        /// </summary>
        public DateTime? FileDate
        {
            get { return this.fileDate; }
            set { this.fileDate = value; }
        }

        /// <summary>
        /// Gets / sets the docketType value of the endorsement
        /// </summary>
        public DOCKET_TYPES DocketType
        {
            get { return this.docketType; }
            set { this.docketType = value; }
        }

        /// <summary>
        /// Gets/sets the instrument number assigned to a filing
        /// </summary>
        public string InstrumentNumber
        {
            get { return this.instrumentNumber; }
            set { this.instrumentNumber = value; }
        }

        /// <summary>
        /// Gets/sets the book value of the endorsement
        /// </summary>
        public string Book
        {
            get { return this.book; }
            set { this.book = value; }
        }
        /// <summary>
        /// Gets/sets the page value of the endorsement
        /// </summary>
        public string Page
        {
            get { return this.page; }
            set { this.page = value; }
        }

        



    }
}
