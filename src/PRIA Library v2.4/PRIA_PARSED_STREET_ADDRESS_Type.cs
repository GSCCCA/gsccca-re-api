using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PARSED_STREET_ADDRESS_Type
    {

        private string _IDField;

        private string _StreetNameField;

        private string _DirectionPrefixField;

        private string _DirectionSuffixField;

        private string _StreetSuffixField;

        private string _HouseNumberField;

        private string _BuildingNumberField;

        private string _PostOfficeBoxField;

        private string _MilitaryAPO_FPOField;

        private string _ApartmentOrUnitField;

        private string _RuralRouteField;

        private string plusFourPostalCodeField;

        private string situsCarrierRouteIdentifierField;

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
        public string _StreetName
        {
            get
            {
                return this._StreetNameField;
            }
            set
            {
                this._StreetNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _DirectionPrefix
        {
            get
            {
                return this._DirectionPrefixField;
            }
            set
            {
                this._DirectionPrefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _DirectionSuffix
        {
            get
            {
                return this._DirectionSuffixField;
            }
            set
            {
                this._DirectionSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _StreetSuffix
        {
            get
            {
                return this._StreetSuffixField;
            }
            set
            {
                this._StreetSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _HouseNumber
        {
            get
            {
                return this._HouseNumberField;
            }
            set
            {
                this._HouseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _BuildingNumber
        {
            get
            {
                return this._BuildingNumberField;
            }
            set
            {
                this._BuildingNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PostOfficeBox
        {
            get
            {
                return this._PostOfficeBoxField;
            }
            set
            {
                this._PostOfficeBoxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MilitaryAPO_FPO
        {
            get
            {
                return this._MilitaryAPO_FPOField;
            }
            set
            {
                this._MilitaryAPO_FPOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _ApartmentOrUnit
        {
            get
            {
                return this._ApartmentOrUnitField;
            }
            set
            {
                this._ApartmentOrUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RuralRoute
        {
            get
            {
                return this._RuralRouteField;
            }
            set
            {
                this._RuralRouteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlusFourPostalCode
        {
            get
            {
                return this.plusFourPostalCodeField;
            }
            set
            {
                this.plusFourPostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SitusCarrierRouteIdentifier
        {
            get
            {
                return this.situsCarrierRouteIdentifierField;
            }
            set
            {
                this.situsCarrierRouteIdentifierField = value;
            }
        }
    }

}
