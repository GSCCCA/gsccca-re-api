using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PREFERRED_RESPONSE_Type
    {

        private string _IDField;

        private PRIA_PreferredResponseFormatEnumerated _FormatField;

        private bool _FormatFieldSpecified;

        private PRIA_PreferredResponseMethodEnumerated _MethodField;

        private bool _MethodFieldSpecified;

        private string _DestinationField;

        private string _FormatOtherDescriptionField;

        private string _MethodOtherField;

        private string _UseEmbeddedFileIndicatorField;

        private string mIMETypeField;

        private string _VersionIdentifierField;

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
        public PRIA_PreferredResponseFormatEnumerated _Format
        {
            get
            {
                return this._FormatField;
            }
            set
            {
                this._FormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _FormatSpecified
        {
            get
            {
                return this._FormatFieldSpecified;
            }
            set
            {
                this._FormatFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PreferredResponseMethodEnumerated _Method
        {
            get
            {
                return this._MethodField;
            }
            set
            {
                this._MethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _MethodSpecified
        {
            get
            {
                return this._MethodFieldSpecified;
            }
            set
            {
                this._MethodFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Destination
        {
            get
            {
                return this._DestinationField;
            }
            set
            {
                this._DestinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _FormatOtherDescription
        {
            get
            {
                return this._FormatOtherDescriptionField;
            }
            set
            {
                this._FormatOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MethodOther
        {
            get
            {
                return this._MethodOtherField;
            }
            set
            {
                this._MethodOtherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _UseEmbeddedFileIndicator
        {
            get
            {
                return this._UseEmbeddedFileIndicatorField;
            }
            set
            {
                this._UseEmbeddedFileIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MIMEType
        {
            get
            {
                return this.mIMETypeField;
            }
            set
            {
                this.mIMETypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _VersionIdentifier
        {
            get
            {
                return this._VersionIdentifierField;
            }
            set
            {
                this._VersionIdentifierField = value;
            }
        }
    }
}
