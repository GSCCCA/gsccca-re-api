using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_NOTARY_CERTIFICATE_Type
    {

        private PRIA_NOTARY_CERTIFICATE_SIGNER_IDENTIFICATION_Type[] _SIGNER_IDENTIFICATIONField;

        private string _IDField;

        private string _SequenceIdentifierField;

        private string _SignerFirstNameField;

        private string _SignerMiddleNameField;

        private string _SignerLastNameField;

        private string _SignerNameSuffixField;

        private string _SignerUnparsedNameField;

        private string _SignerCompanyNameField;

        private string _SignerTitleDescriptionField;

        private string _SigningDateField;

        private string _SigningCountyField;

        private string _SigningStateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_SIGNER_IDENTIFICATION")]
        public PRIA_NOTARY_CERTIFICATE_SIGNER_IDENTIFICATION_Type[] _SIGNER_IDENTIFICATION
        {
            get
            {
                return this._SIGNER_IDENTIFICATIONField;
            }
            set
            {
                this._SIGNER_IDENTIFICATIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string _ID
        {
            get
            {
                return this._IDField;
            }
            set
            {
                this._IDField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerFirstName
        {
            get
            {
                return this._SignerFirstNameField;
            }
            set
            {
                this._SignerFirstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerMiddleName
        {
            get
            {
                return this._SignerMiddleNameField;
            }
            set
            {
                this._SignerMiddleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerLastName
        {
            get
            {
                return this._SignerLastNameField;
            }
            set
            {
                this._SignerLastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerNameSuffix
        {
            get
            {
                return this._SignerNameSuffixField;
            }
            set
            {
                this._SignerNameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerUnparsedName
        {
            get
            {
                return this._SignerUnparsedNameField;
            }
            set
            {
                this._SignerUnparsedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerCompanyName
        {
            get
            {
                return this._SignerCompanyNameField;
            }
            set
            {
                this._SignerCompanyNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SignerTitleDescription
        {
            get
            {
                return this._SignerTitleDescriptionField;
            }
            set
            {
                this._SignerTitleDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SigningDate
        {
            get
            {
                return this._SigningDateField;
            }
            set
            {
                this._SigningDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SigningCounty
        {
            get
            {
                return this._SigningCountyField;
            }
            set
            {
                this._SigningCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SigningState
        {
            get
            {
                return this._SigningStateField;
            }
            set
            {
                this._SigningStateField = value;
            }
        }
    }
}
