using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RESPONSE_Type
    {

        private PRIA_PACKAGE_Type pACKAGEField;

        private PRIA_RECORDING_TRANSACTION_IDENTIFIER_Type rECORDING_TRANSACTION_IDENTIFIERField;

        //private PRIA_ORIGINATING_RECORDING_REQUEST_Type[] oRIGINATING_RECORDING_REQUESTField;
        private List<PRIA_ORIGINATING_RECORDING_REQUEST_Type> oRIGINATING_RECORDING_REQUESTField;

        private string _RelatedDocumentsIndicatorField;

        private PRIA_PRIAResponseType_Enumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        public PRIA_PACKAGE_Type PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }

        /// <remarks/>
        public PRIA_RECORDING_TRANSACTION_IDENTIFIER_Type RECORDING_TRANSACTION_IDENTIFIER
        {
            get
            {
                return this.rECORDING_TRANSACTION_IDENTIFIERField;
            }
            set
            {
                this.rECORDING_TRANSACTION_IDENTIFIERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ORIGINATING_RECORDING_REQUEST")]
        public List<PRIA_ORIGINATING_RECORDING_REQUEST_Type> ORIGINATING_RECORDING_REQUEST
        //public PRIA_ORIGINATING_RECORDING_REQUEST_Type[] ORIGINATING_RECORDING_REQUEST
        {
            get
            {
                return this.oRIGINATING_RECORDING_REQUESTField;
            }
            set
            {
                this.oRIGINATING_RECORDING_REQUESTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RelatedDocumentsIndicator
        {
            get
            {
                return this._RelatedDocumentsIndicatorField;
            }
            set
            {
                this._RelatedDocumentsIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("_Type")]
        public PRIA_PRIAResponseType_Enumerated ResponseType
        {
            get
            {
                return this._TypeField;
            }
            set
            {
                this._TypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _TypeSpecified
        {
            get
            {
                return this._TypeFieldSpecified;
            }
            set
            {
                this._TypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _TypeOtherDescription
        {
            get
            {
                return this._TypeOtherDescriptionField;
            }
            set
            {
                this._TypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SequenceIdentifier
        {
            get
            {
                return this._SequenceIdentifierField;
            }
            set
            {
                this._SequenceIdentifierField = value;
            }
        }
    }
}
