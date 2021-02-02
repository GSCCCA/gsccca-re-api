﻿using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECEIVING_PARTY_Type
    {

        private PRIA_CONTACT_DETAIL_Type[] cONTACT_DETAILField;

        private string _NameField;

        private string _StreetAddressField;

        private string _StreetAddress2Field;

        private string _CityField;

        private string _StateField;

        private string _PostalCodeField;

        private string _IdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONTACT_DETAIL")]
        public PRIA_CONTACT_DETAIL_Type[] CONTACT_DETAIL
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Name
        {
            get
            {
                return this._NameField;
            }
            set
            {
                this._NameField = value;
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
        public string _Identifier
        {
            get
            {
                return this._IdentifierField;
            }
            set
            {
                this._IdentifierField = value;
            }
        }
    }
}
