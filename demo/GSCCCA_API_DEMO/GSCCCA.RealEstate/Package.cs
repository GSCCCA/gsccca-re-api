using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Package information
    /// </summary>
    public class Package
    {
        /// <summary>
        /// Stores the GSCCCA ID of the package.
        /// </summary>
        private Guid gscccaID = Guid.Empty;

        /// <summary>
        /// Stores a collection of filings associated with this package
        /// </summary>
        private Filings filings = new Filings();

        /// <summary>
        /// Stores information about the filer of this Filing
        /// </summary>
        protected FilingParty originalFiler = new FilingParty();

        /// <summary>
        /// When a package is to be rejected, stores a collection of reasons for the rejection
        /// </summary>
        private RejectionReasons rejections = new RejectionReasons();

        /// <summary>
        /// Gets/sets a collection of reasons why the filng was rejected
        /// </summary>
        public RejectionReasons ReasonsForRejection
        {
            get { return this.rejections; }
            set { this.rejections = value; }
        }

        /// <summary>
        /// Gets/sets the Original Filer party information for this Filing
        /// </summary>
        public FilingParty OriginalFiler
        {
            get { return this.originalFiler; }
            set { this.originalFiler = value; }
        }

        /// <summary>
        /// Gets/sets the GSCCCA ID of the package
        /// </summary>
        public Guid GSCCCAID
        {
            get { return this.gscccaID; }
            set { this.gscccaID = value; }
        }

        /// <summary>
        /// Tries to set the GSCCCAID for this Package using a string rather than a GUID.  
        /// </summary>
        /// <param name="gscccaIDString">A string representation of a GUID</param>
        /// <returns>True if the GSCCCAID was set successfully.  False otherwise</returns>
        public bool SetGSCCCAID(string gscccaIDString)
        {
            return Guid.TryParse(gscccaIDString, out this.gscccaID);
        }

        /// <summary>
        /// Gets/sets a collection of filings associated with this package.
        /// </summary>
        public Filings Filings
        {
            get { return this.filings; }
            set { this.filings = value; }
        }

        /// <summary>
        /// Transforms a package instance into a PRIA Package instance
        /// </summary>
        /// <param name="p">A package to transform into a PRIA Pacakge</param>
        /// <returns>A Pria Package Object</returns>
        internal static Package FromPriaPackage(PRIALibraryV24.PRIA_PACKAGE_Type p)
        {
            Package package = new Package();
            try 
            {
                Guid g = Guid.Parse(p._Identifier);
                package.GSCCCAID = g;
                if (p.PRIA_DOCUMENT != null)
                {
                    foreach (PRIALibraryV24.PRIA_DOCUMENT_Type doc in p.PRIA_DOCUMENT)
                    {
                        Filing f = Filing.FromPriaDoc(doc);
                        package.Filings.Add(f);
                    }
                }

            }
            catch
            {
                package = null;
            }

            return package;
        }

        internal PRIALibraryV24.PRIA_PACKAGE_Type ToPriaPackage()
        {
            PRIALibraryV24.PRIA_PACKAGE_Type package = new PRIALibraryV24.PRIA_PACKAGE_Type();
            package._Identifier = this.gscccaID.ToString();
            package.PRIA_DOCUMENT = new List<PRIALibraryV24.PRIA_DOCUMENT_Type>();

            int seq = 1;

            foreach (Filing f in this.Filings)
            {
                package.PRIA_DOCUMENT.Add(f.ToPriaDocument(seq));
                seq++;
            }

            return package;
        }
    }
}
