using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_SERVICE_PAYMENT_Type
    {

        private string _AccountIdentifierField;

        private string _AccountHolderNameField;

        private string _AccountHolderStreetAddressField;

        private string _AccountHolderStreetAddress2Field;

        private string _AccountHolderCityField;

        private string _AccountHolderStateField;

        private string _AccountHolderPostalCodeField;

        private string _AccountHolderTelephoneNumberField;

        private string _AccountExpirationDateField;

        private string _SecondaryAccountIdentifierField;

        private PRIA_ServicePaymentMethodTypeEnumerated _MethodTypeField;

        private bool _MethodTypeFieldSpecified;

        private string _MethodTypeOtherDescriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountIdentifier
        {
            get
            {
                return this._AccountIdentifierField;
            }
            set
            {
                this._AccountIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderName
        {
            get
            {
                return this._AccountHolderNameField;
            }
            set
            {
                this._AccountHolderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderStreetAddress
        {
            get
            {
                return this._AccountHolderStreetAddressField;
            }
            set
            {
                this._AccountHolderStreetAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderStreetAddress2
        {
            get
            {
                return this._AccountHolderStreetAddress2Field;
            }
            set
            {
                this._AccountHolderStreetAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderCity
        {
            get
            {
                return this._AccountHolderCityField;
            }
            set
            {
                this._AccountHolderCityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderState
        {
            get
            {
                return this._AccountHolderStateField;
            }
            set
            {
                this._AccountHolderStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderPostalCode
        {
            get
            {
                return this._AccountHolderPostalCodeField;
            }
            set
            {
                this._AccountHolderPostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountHolderTelephoneNumber
        {
            get
            {
                return this._AccountHolderTelephoneNumberField;
            }
            set
            {
                this._AccountHolderTelephoneNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountExpirationDate
        {
            get
            {
                return this._AccountExpirationDateField;
            }
            set
            {
                this._AccountExpirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SecondaryAccountIdentifier
        {
            get
            {
                return this._SecondaryAccountIdentifierField;
            }
            set
            {
                this._SecondaryAccountIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_ServicePaymentMethodTypeEnumerated _MethodType
        {
            get
            {
                return this._MethodTypeField;
            }
            set
            {
                this._MethodTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _MethodTypeSpecified
        {
            get
            {
                return this._MethodTypeFieldSpecified;
            }
            set
            {
                this._MethodTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MethodTypeOtherDescription
        {
            get
            {
                return this._MethodTypeOtherDescriptionField;
            }
            set
            {
                this._MethodTypeOtherDescriptionField = value;
            }
        }
    }
}
