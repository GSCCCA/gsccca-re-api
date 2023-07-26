using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRIALibraryV24;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a Real Estate filing that has not yet been accepted or rejected.  This is the base class for the AcceptedFiling and RejectedFiling classes.
    /// </summary>
    public class Filing
    {
        /// <summary>
        /// Stores the value of the GSCCCAID assigned to this filing
        /// </summary>
        protected Guid gscccaID = Guid.Empty;

        /// <summary>
        /// Stores a list of grantors associated with this filing
        /// </summary>
        protected List<FilingParty> grantors = new List<FilingParty>();

        /// <summary>
        /// Stores a list of grantees associated with this filing
        /// </summary>
        protected List<FilingParty> grantees = new List<FilingParty>();

        /// <summary>
        /// Stores a collection of document images associated with this filing
        /// </summary>
        protected DocumentImages documents = new DocumentImages();


        /// <summary>
        /// Indicates whether or not this document should be recorded.
        /// </summary>
        protected bool recordable = true;

        /// <summary>
        /// Stores information about the document type represented by this filing.
        /// </summary>
        protected string documentTypeName = "";

        /// <summary>
        /// Stores information about the document description represented by this filing.
        /// </summary>
        protected string documentOtherTypeDescription = "";

        /// <summary>
        /// Endorsement information
        /// </summary>
        protected RecordingEndorsement endorsement = new RecordingEndorsement();

        /// <summary>
        /// Fee information
        /// </summary>
        protected FilingFees fees = new FilingFees();

        /// <summary>
        /// Adds a DocumentImage to this Filing
        /// </summary>
        /// <param name="type">The DocumentImage type of the image being added</param>
        /// <param name="data">The binary data of the image being added</param>
        public void AddDocumentImage(IMAGE_FILE_TYPE type, byte[] data)
        {
            DocumentImage file = new DocumentImage(type, data);
            this.documents.Add(file);
        }

        /// <summary>
        /// The GSCCCA Filing GUID associated with this filing.  The Filing GUID is used to uniquely identify a filing and
        /// is used when retrieving, accepting, or rejecting a filing frm the GSCCCA eFiling system
        /// </summary>
        public Guid GSCCCAID
        {
            get { return this.gscccaID; }
            set { this.gscccaID = value; }
        }


        /// <summary>
        /// Gets or sets the recording Endorsement for the Filing.  The endorsement contains
        /// information about the recordation of the filing, such as book, page, recordation date, etc
        /// </summary>
        public RecordingEndorsement Endorsement
        {
            get { return this.endorsement; }
            set { this.endorsement = value; }
        }


        /// <summary>
        /// Creates a PRIA Endorsement object from the endorsement infromation contained within this AcceptedFiling object
        /// </summary>
        /// <returns>A Pria Endorsement object</returns>
        private PRIA_RECORDING_ENDORSEMENT_Type getPriaEndorsement()
        {
            //create endorsement
            PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_Type endorse = new PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_Type();

            //set book, page, dockemt
            endorse._Volume = this.Endorsement.Book;
            endorse._VOLUME_PAGE = new PRIALibraryV24.PRIA_VOLUME_PAGE_Type[1];
            endorse._VOLUME_PAGE[0] = new PRIALibraryV24.PRIA_VOLUME_PAGE_Type();
            endorse._VOLUME_PAGE[0]._NumberIdentifier = this.Endorsement.Page;
            endorse._VolumeTypeValue = getPriaDocType(this.Endorsement.DocketType);
            endorse._InstrumentNumberIdentifier = this.Endorsement.InstrumentNumber;

            //Set the recording date.
            DateTime recordedDate = (DateTime)this.Endorsement.FileDate;
            string sDate = recordedDate.ToString("M/d/yyyy h:mm tt");
            endorse._RecordedDateTime = sDate;

            //Create Fees
            endorse._FEES = new PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_FEES_Type();
            endorse._FEES._RECORDING_FEE = new List<PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type>();

            int feeSequence = 1;
            foreach (FilingFee fee in this.Fees)
            {
                PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type priaFee = new PRIALibraryV24.PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type();
                priaFee.RecordingEndorsementFeeAmount = fee.FeeAmount.ToString();
                priaFee.RecordingEndorsementFeeDescription = fee.FeeDescription;
                priaFee.RecordingEndorsementFeeSequenceIdentifier = feeSequence.ToString();

                endorse._FEES._RECORDING_FEE.Add(priaFee);
                feeSequence++;
            }
            endorse._FEES._TotalAmount = this.TotalFeeAmount.ToString();


            return endorse;
        }

        private static IEnumerable<FilingFee> GetEstimatedFees(PRIALibraryV24.PRIA_CONSIDERATION_Type[] considerations)
        {
            if (considerations is null) yield break;

            var estimates = considerations.Where(p => p._Type == PRIA_ConsiderationTypeEnumerated.Other
                                                   && !string.IsNullOrEmpty(p._TypeOtherDescription)
                                                   && FeeEstimateTypes.Keys.ToList().Contains(p._TypeOtherDescription)
                                                   && double.TryParse(p._Amount, out double _));

            foreach (var estimate in estimates)
            {
                yield return new FilingFee(double.Parse(estimate._Amount), estimate._TypeOtherDescription);
            }
        }

        /// <summary>
        /// Maps a GSCCCA docket type to a PRIA Volume Type
        /// </summary>
        /// <param name="type">The GSCCCA docket type to be translated to a Pria Volume Type</param>
        /// <returns>A Pria Volume type</returns>
        private PRIA_RecordingEndorsementVolumeTypeEnumerated getPriaDocType(DOCKET_TYPES type)
        {
            PRIA_RecordingEndorsementVolumeTypeEnumerated newType = PRIA_RecordingEndorsementVolumeTypeEnumerated.Deed;
            switch (type)
            {
                case DOCKET_TYPES.LIEN:
                    newType = PRIA_RecordingEndorsementVolumeTypeEnumerated.Other;
                    break;
                case DOCKET_TYPES.PLAT:
                    newType = PRIA_RecordingEndorsementVolumeTypeEnumerated.Plat;
                    break;
            }
            return newType;
        }

        /// <summary>
        /// Tries to set the GSCCCAID for this Filing using a string rather than a GUID.  
        /// </summary>
        /// <param name="gscccaIDString">A string representation of a GUID</param>
        /// <returns>True if the GSCCCAID was set successfully.  False otherwise</returns>
        public bool SetGSCCCAID(string gscccaIDString)
        {
            return Guid.TryParse(gscccaIDString, out this.gscccaID);
        }

        /// <summary>
        /// Gets/sets the DocumentImages for the Filing
        /// </summary>
        public DocumentImages Images
        {
            get { return this.documents; }
            set { this.documents = value; }
        }

        /// <summary>
        /// Creates a PRIA document object from the filing object and uses "1" as the document sequence number
        /// </summary>
        /// <returns>A fully populated Pria Document</returns>
        internal virtual PRIA_DOCUMENT_Type ToPriaDocument()
        {
            return this.ToPriaDocument(1);
        }

        /// <summary>
        /// Gets / Sets a collection of estimated fees associated with this Filing
        /// </summary>
        public List<FilingFee> FeeEstimates
        {
            get;
            set;
        }

        /// <summary>
        /// There is a set list of allowed estimated fees.
        /// This is provided for programmatic usage of estimates.
        /// </summary>
        public enum FeeEstimateType
        {
            /// <summary>
            /// Estimated Base Filing Fee
            /// </summary>
            Base = 0,
            /// <summary>
            /// Estimated Assigned Fees
            /// </summary>
            Assigned,
            /// <summary>
            /// Estimated Documents Being Cancelled Fees
            /// </summary>
            Cancelled,
            /// <summary>
            /// Estimated Cross Index Fees
            /// </summary>
            Xref,
            /// <summary>
            /// Estimated PT-61 Tax
            /// </summary>
            TransferTax,
            /// <summary>
            /// Estimated Intangible Tax
            /// </summary>
            IntangibleTax,
            /// <summary>
            /// Estimated Page Fees
            /// </summary>
            Pages,
            /// <summary>
            /// Estimated Penalties
            /// </summary>
            Penalties,
            /// <summary>
            /// Estimated Interest
            /// </summary>
            Interest,
        }

        /// <summary>
        /// Convert the XML string to an enumerated value for programmatic use
        /// </summary>
        public static Dictionary<string, FeeEstimateType> FeeEstimateTypes
        {
            get => new Dictionary<string, FeeEstimateType>()
            {
                {"Estimated Base Filing Fee", FeeEstimateType.Base },
                {"Estimated Assigned Fees", FeeEstimateType.Assigned },
                {"Estimated Documents Being Cancelled Fees", FeeEstimateType.Cancelled },
                {"Estimated Cross Index Fees", FeeEstimateType.Xref },
                {"Estimated PT-61 Tax", FeeEstimateType.TransferTax },
                {"Estimated Intangible Tax", FeeEstimateType.IntangibleTax },
                {"Estimated Page Fees", FeeEstimateType.Pages },
                {"Estimated Penalties", FeeEstimateType.Penalties },
                {"Estimated Interest", FeeEstimateType.Interest },
            };
        }

        /// <summary>
        /// Gets / Sets a collection of recording fees associated with this AcceptedFiling
        /// </summary>
        public FilingFees Fees
        {
            get { return this.fees; }
            set { this.fees = value; }
        }


        /// <summary>
        /// Gets a sum of the total recording fees for this AcceptedFiling
        /// </summary>
        public double TotalFeeAmount
        {
            get
            {
                double totalFees = 0.0;
                foreach (FilingFee f in this.fees)
                {
                    totalFees += f.FeeAmount;
                }
                return totalFees;
            }
        }


        /// <summary>
        /// Creates a PRIA document object from the filing object
        /// </summary>
        /// <returns>A fully populated Pria Document</returns>
        internal virtual PRIA_DOCUMENT_Type ToPriaDocument(int sequence)
        {
            var doc = new PRIA_DOCUMENT_Type
            {
                _UniqueIdentifier = gscccaID.ToString(),
                RecordableDocumentTypeCode = (PRIA_RecordableDocumentTypeEnumerated)Enum.Parse(typeof(PRIA_RecordableDocumentTypeEnumerated), documentTypeName),
                RecordableDocumentTypeOtherDescription = DocumentTypeOtherDescription
            };

            if (!this.recordable)
                doc.DocumentNonRecordableIndicator = "Y";

            doc.RecordableDocumentSequenceIdentifier = sequence.ToString();
            doc.PRIAVersionIdentifier = "2.4.2";

            // ADD GRANTEES //
            int indexer = 0;
            if (this.grantees.Count > 0)
            {
                doc.GRANTEE = new PRIA_GRANTEE_Type[grantees.Count];
                foreach (FilingParty p in this.grantees)
                {
                    doc.GRANTEE[indexer++] = p.ToPriaGrantee();
                }
            }
            else
            {
                //pria specs requires a grantee element
                doc.GRANTEE = new PRIA_GRANTEE_Type[1];
                doc.GRANTEE[0] = new PRIA_GRANTEE_Type();
            }

            // ADD GRANTORS //
            if (this.grantors.Count > 0)
            {
                indexer = 0;
                doc.GRANTOR = new PRIA_GRANTOR_Type[grantors.Count];
                foreach (FilingParty p in this.grantors)
                {
                    doc.GRANTOR[indexer++] = p.ToPriaGrantor();
                }
            }
            else
            {
                //pria specs requires a grantee element
                doc.GRANTOR = new PRIA_GRANTOR_Type[1];
                doc.GRANTOR[0] = new PRIA_GRANTOR_Type();
            }

            int fileCount = this.documents.Count;
            if (fileCount > 0)
            {
                doc.EMBEDDED_FILE = new PRIA_EMBEDDED_FILE_Type[fileCount];

                int fileSequence = 0;
                foreach (DocumentImage file in this.documents)
                {
                    PRIA_EMBEDDED_FILE_Type f = new PRIA_EMBEDDED_FILE_Type();
                    f.DOCUMENT = new PRIA_DOCUMENT_DATA_TYPE();
                    f.DOCUMENT.DATA = file.Data;
                    if (!file.Recordable)
                        f.DOCUMENT.DocumentNonRecordableIndicator = "Y";

                    
                    switch (file.FileType)
                    {
                        case IMAGE_FILE_TYPE.TIFF:
                            f.EmbeddedFileType = "TIF";
                            f.MIMEType = "image/tiff";
                            break;
                        case IMAGE_FILE_TYPE.PDF:
                            f.EmbeddedFileType = "PDF";
                            f.MIMEType = "application/pdf";
                            break;
                    }
                    f.FileEncodingType = "Base64";
                    f.ID = fileSequence.ToString();
                    doc.EMBEDDED_FILE[fileSequence++] = f;

                }
            }
            if (this.recordable)
                doc.RECORDING_ENDORSEMENT = this.getPriaEndorsement();
            return doc;

        }



        /// <summary>
        /// Gets/sets the list of grantees associate with this filing
        /// </summary>
        public List<FilingParty> Grantees
        {
            get { return this.grantees; }
            set { this.grantees = value; }
        }

        /// <summary>
        /// Gets/sets the list of grantors associate with this filing
        /// </summary>
        public List<FilingParty> Grantors
        {
            get { return this.grantors; }
            set { this.grantors = value; }
        }

        /// <summary>
        /// Gets/sets a flag to indicate whether or not this document is recordable.
        /// </summary>
        public bool Recordable
        {
            get { return this.recordable; }
            set { this.recordable = value; }
        }

        /// <summary>
        /// Gets/set the document type of this filing. 
        /// </summary>
        public string DocumentTypeName
        {
            get { return this.documentTypeName; }
            set { this.documentTypeName = value; }
        }

        /// <summary>
        /// Gets/set the description of the document type. 
        /// </summary>
        public string DocumentTypeOtherDescription
        {
            get => string.IsNullOrEmpty(documentOtherTypeDescription) ? documentTypeName : documentOtherTypeDescription;
            set => documentOtherTypeDescription = value;
        }

        /// <summary>
        /// Creates a strongly typed Filing object from a Pria Document
        /// </summary>
        /// <param name="doc">The Pria document containing the filing for which a Filing object is to be created</param>
        /// <returns>A Filing object</returns>
        internal static Filing FromPriaDoc(PRIALibraryV24.PRIA_DOCUMENT_Type doc)
        {
            Filing f = null;
            try
            {
                f = new Filing();

                //mark the document recordable attribute
                if (doc.DocumentNonRecordableIndicator != null)
                {
                    switch (doc.DocumentNonRecordableIndicator.ToUpper().Trim())
                    {
                        case "Y":
                        case "YES":
                        case "1":
                        case "T":
                        case "TRUE":
                            f.Recordable = false;
                            break;
                    }
                }

                //set the document type name
                try
                {
                    f.DocumentTypeName = doc.RecordableDocumentTypeCode.ToString();
                }
                catch { }

                f.GSCCCAID = Guid.Parse(doc._UniqueIdentifier);
                if (doc.EMBEDDED_FILE != null
                    && doc.EMBEDDED_FILE.Length > 0)
                {
                    foreach (PRIALibraryV24.PRIA_EMBEDDED_FILE_Type file in doc.EMBEDDED_FILE)
                    {
                        //temp fix -- don't add embedded if null
                        if (file.DOCUMENT != null && file.DOCUMENT.DATA!=null)
                        {
                            
                            IMAGE_FILE_TYPE type = IMAGE_FILE_TYPE.TIFF;
                            if (file.MIMEType.ToUpper().Contains("PDF"))
                                type = IMAGE_FILE_TYPE.PDF;

                            DocumentImage image = new DocumentImage(type, file.DOCUMENT.DATA);
                            if (file.DOCUMENT.DocumentNonRecordableIndicator == "Y")
                                image.Recordable = false;

                            f.Images.Add(image);
                        }
                    }
                }

                //add all the grantees
                if (doc.GRANTEE != null && doc.GRANTEE.Length>0)
                {
                    foreach (PRIALibraryV24.PRIA_GRANTEE_Type g in doc.GRANTEE)
                    {
                        f.Grantees.Add(FilingParty.FromPriaGrantee(g));
                    }
                }

                //add all the grantors
                if (doc.GRANTOR != null && doc.GRANTOR.Length > 0)
                {
                    foreach (PRIALibraryV24.PRIA_GRANTOR_Type g in doc.GRANTOR)
                    {
                        f.Grantors.Add(FilingParty.FromPriaGrantor(g));
                    }
                }

                f.FeeEstimates = GetEstimatedFees(doc.CONSIDERATION).ToList();

                //get the endorsement
                if (doc.RECORDING_ENDORSEMENT != null)
                {
                    PRIA_RECORDING_ENDORSEMENT_Type endorsement = doc.RECORDING_ENDORSEMENT;
                    DOCKET_TYPES newType = DOCKET_TYPES.NON_ASSIGNED;
                    switch (endorsement._VolumeTypeValue)
                    {
                        case PRIA_RecordingEndorsementVolumeTypeEnumerated.Deed:
                            newType = DOCKET_TYPES.DEED;
                            break;
                        case PRIA_RecordingEndorsementVolumeTypeEnumerated.Plat:
                            newType = DOCKET_TYPES.PLAT;
                            break;
                        case PRIA_RecordingEndorsementVolumeTypeEnumerated.Other:
                            newType = DOCKET_TYPES.LIEN;
                            break;
                    }

                    f.Endorsement.DocketType = newType;
                    f.Endorsement.Book = endorsement._Volume;

                    if (endorsement._VOLUME_PAGE !=null && endorsement._VOLUME_PAGE.Length>0)
                        f.Endorsement.Page = endorsement._VOLUME_PAGE[0]._NumberIdentifier;
                    if (!string.IsNullOrEmpty(endorsement._RecordedDateTime))
                        f.Endorsement.FileDate = Convert.ToDateTime(endorsement._RecordedDateTime);

                    if (endorsement._FEES != null && endorsement._FEES._RECORDING_FEE != null)
                    {
                        foreach (PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type fee in endorsement._FEES._RECORDING_FEE)
                        {
                            FilingFee filingFee = new FilingFee(Convert.ToDouble(fee.RecordingEndorsementFeeAmount), fee.RecordingEndorsementFeeDescription);
                            f.Fees.Add(filingFee);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                f = null;
            }
            return f;

        }

        
        
    }
}
