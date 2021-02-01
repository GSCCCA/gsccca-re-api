using System.Xml.Serialization;

namespace PRIALibraryV24
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDING_ERROR_Type
    {

        private string _DescriptionField;

        private PRIA_RecordingErrorSeverityType_Enumerated _SeverityTypeField;

        private bool _SeverityTypeFieldSpecified;

        private string _SeverityTypeOtherDescriptionField;

        private PRIA_RecordingErrorType_Enumerated _TypeField;

        private string _TypeOtherDescriptionField;

        private string errorXPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Description
        {
            get
            {
                return this._DescriptionField;
            }
            set
            {
                this._DescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_RecordingErrorSeverityType_Enumerated _SeverityType
        {
            get
            {
                return this._SeverityTypeField;
            }
            set
            {
                this._SeverityTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _SeverityTypeSpecified
        {
            get
            {
                return this._SeverityTypeFieldSpecified;
            }
            set
            {
                this._SeverityTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SeverityTypeOtherDescription
        {
            get
            {
                return this._SeverityTypeOtherDescriptionField;
            }
            set
            {
                this._SeverityTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_RecordingErrorType_Enumerated _Type
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
        public string ErrorXPath
        {
            get
            {
                return this.errorXPathField;
            }
            set
            {
                this.errorXPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum PRIA_RecordingErrorSeverityType_Enumerated
    {

        /// <remarks/>
        Warning,

        /// <remarks/>
        NonFatal,

        /// <remarks/>
        Fatal,

        /// <remarks/>
        Other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    public enum PRIA_RecordingErrorType_Enumerated
    {

        /// <remarks/>
        DTDValidation,

        /// <remarks/>
        Signature,

        /// <remarks/>
        Image,

        /// <remarks/>
        BusinessRule,

        /// <remarks/>
        Other,
    }

}
