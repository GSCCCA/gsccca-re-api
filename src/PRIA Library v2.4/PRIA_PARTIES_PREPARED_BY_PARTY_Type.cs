using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PARTIES_PREPARED_BY_PARTY_Type
    {

        private PRIA_PREFERRED_RESPONSE_Type[] pREFERRED_RESPONSEField;

        private PRIA_NON_PERSON_ENTITY_DETAIL_Type nON_PERSON_ENTITY_DETAILField;

        private PRIA_CONTACT_DETAIL_Type cONTACT_DETAILField;

        private string _IDField;

        private string _UnparsedNameField;

        private string _StreetAddressField;

        private string _StreetAddress2Field;

        private string _CityField;

        private string _StateField;

        private string _PostalCodeField;

        private string _CountyField;

        private string _CountryField;

        private string _CountryCodeField;

        private string nonPersonEntityIndicatorField;

        private string _SequenceIdentifierField;

        private string _TitleDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PREFERRED_RESPONSE")]
        public PRIA_PREFERRED_RESPONSE_Type[] PREFERRED_RESPONSE
        {
            get
            {
                return this.pREFERRED_RESPONSEField;
            }
            set
            {
                this.pREFERRED_RESPONSEField = value;
            }
        }

        /// <remarks/>
        public PRIA_NON_PERSON_ENTITY_DETAIL_Type NON_PERSON_ENTITY_DETAIL
        {
            get
            {
                return this.nON_PERSON_ENTITY_DETAILField;
            }
            set
            {
                this.nON_PERSON_ENTITY_DETAILField = value;
            }
        }

        /// <remarks/>
        public PRIA_CONTACT_DETAIL_Type CONTACT_DETAIL
        {
            get
            {
                return this.cONTACT_DETAILField;
            }
            set
            {
                this.cONTACT_DETAILField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _StreetAddress
        {
            get
            {
                return this._StreetAddressField;
            }
            set
            {
                this._StreetAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _StreetAddress2
        {
            get
            {
                return this._StreetAddress2Field;
            }
            set
            {
                this._StreetAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _City
        {
            get
            {
                return this._CityField;
            }
            set
            {
                this._CityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _State
        {
            get
            {
                return this._StateField;
            }
            set
            {
                this._StateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PostalCode
        {
            get
            {
                return this._PostalCodeField;
            }
            set
            {
                this._PostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _County
        {
            get
            {
                return this._CountyField;
            }
            set
            {
                this._CountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Country
        {
            get
            {
                return this._CountryField;
            }
            set
            {
                this._CountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CountryCode
        {
            get
            {
                return this._CountryCodeField;
            }
            set
            {
                this._CountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonPersonEntityIndicator
        {
            get
            {
                return this.nonPersonEntityIndicatorField;
            }
            set
            {
                this.nonPersonEntityIndicatorField = value;
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
    }
}
