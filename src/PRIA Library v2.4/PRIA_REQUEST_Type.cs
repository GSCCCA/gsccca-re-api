using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_REQUEST_Type
    {

        //private PRIA_PACKAGE_Type[] pACKAGEField;
        private List<PRIA_PACKAGE_Type> pACKAGEField;

        private PRIA_RECORDING_TRANSACTION_IDENTIFIER_Type rECORDING_TRANSACTION_IDENTIFIERField;

        private string _RelatedDocumentsIndicatorField;

        private PRIA_PRIARequestType_Enumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PACKAGE")]
        public List<PRIA_PACKAGE_Type> PACKAGE
        //public PRIA_PACKAGE_Type[] PACKAGE
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PRIARequestType_Enumerated _Type
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
