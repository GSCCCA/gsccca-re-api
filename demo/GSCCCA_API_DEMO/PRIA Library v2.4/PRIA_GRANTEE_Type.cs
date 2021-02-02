using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_GRANTEE_Type
    {

        private PRIA_GRANTEE_ALIAS_Type[] _ALIASField;

        private string _IDField;

        private string _StreetAddressField;

        private string _StreetAddress2Field;

        private string _CityField;

        private string _StateField;

        private string _PostalCodeField;

        private string _CountyField;

        private string _CountryField;

        private string _FirstNameField;

        private string _MiddleNameField;

        private string _LastNameField;

        private string _NameSuffixField;

        private string _UnparsedNameField;

        private string _CapacityDescriptionField;

        private PRIA_MaritalStatusTypeEnumerated maritalStatusTypeField;

        private bool maritalStatusTypeFieldSpecified;

        private string nonPersonEntityIndicatorField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_ALIAS")]
        public PRIA_GRANTEE_ALIAS_Type[] _ALIAS
        {
            get
            {
                return this._ALIASField;
            }
            set
            {
                this._ALIASField = value;
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
        public string _FirstName
        {
            get
            {
                return this._FirstNameField;
            }
            set
            {
                this._FirstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MiddleName
        {
            get
            {
                return this._MiddleNameField;
            }
            set
            {
                this._MiddleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _LastName
        {
            get
            {
                return this._LastNameField;
            }
            set
            {
                this._LastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _NameSuffix
        {
            get
            {
                return this._NameSuffixField;
            }
            set
            {
                this._NameSuffixField = value;
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
        public string _CapacityDescription
        {
            get
            {
                return this._CapacityDescriptionField;
            }
            set
            {
                this._CapacityDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_MaritalStatusTypeEnumerated MaritalStatusType
        {
            get
            {
                return this.maritalStatusTypeField;
            }
            set
            {
                this.maritalStatusTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaritalStatusTypeSpecified
        {
            get
            {
                return this.maritalStatusTypeFieldSpecified;
            }
            set
            {
                this.maritalStatusTypeFieldSpecified = value;
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
    }
}
