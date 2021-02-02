using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_NOTARY_Type
    {

        private PRIA_NOTARY_CERTIFICATE_Type[] _CERTIFICATEField;

        private MISMO_SIGNATURE_TYPE[] sIGNATORYField;

        private string _IDField;

        private string _CommissionBondNumberIdentifierField;

        private string _CommissionNumberIdentifierField;

        private string _CommissionExpirationDateField;

        private string _CommissionStateField;

        private string _CommissionCountyField;

        private string _CommissionCityField;

        private string _PRIAVersionIdentifierField;

        private string _SequenceIdentifierField;

        private string _TitleDescriptionField;

        private string _UnparsedNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_CERTIFICATE")]
        public PRIA_NOTARY_CERTIFICATE_Type[] _CERTIFICATE
        {
            get
            {
                return this._CERTIFICATEField;
            }
            set
            {
                this._CERTIFICATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SIGNATORY")]
        public MISMO_SIGNATURE_TYPE[] SIGNATORY
        {
            get
            {
                return this.sIGNATORYField;
            }
            set
            {
                this.sIGNATORYField = value;
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
        public string _CommissionBondNumberIdentifier
        {
            get
            {
                return this._CommissionBondNumberIdentifierField;
            }
            set
            {
                this._CommissionBondNumberIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CommissionNumberIdentifier
        {
            get
            {
                return this._CommissionNumberIdentifierField;
            }
            set
            {
                this._CommissionNumberIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CommissionExpirationDate
        {
            get
            {
                return this._CommissionExpirationDateField;
            }
            set
            {
                this._CommissionExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CommissionState
        {
            get
            {
                return this._CommissionStateField;
            }
            set
            {
                this._CommissionStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CommissionCounty
        {
            get
            {
                return this._CommissionCountyField;
            }
            set
            {
                this._CommissionCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CommissionCity
        {
            get
            {
                return this._CommissionCityField;
            }
            set
            {
                this._CommissionCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PRIAVersionIdentifier
        {
            get
            {
                return this._PRIAVersionIdentifierField;
            }
            set
            {
                this._PRIAVersionIdentifierField = value;
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
        public string _TitleDescription
        {
            get
            {
                return this._TitleDescriptionField;
            }
            set
            {
                this._TitleDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _UnparsedName
        {
            get
            {
                return this._UnparsedNameField;
            }
            set
            {
                this._UnparsedNameField = value;
            }
        }
    }
}
