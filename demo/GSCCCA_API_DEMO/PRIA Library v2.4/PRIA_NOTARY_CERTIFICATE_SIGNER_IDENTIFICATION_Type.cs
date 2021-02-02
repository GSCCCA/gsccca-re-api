using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_NOTARY_CERTIFICATE_SIGNER_IDENTIFICATION_Type
    {

        private string _IDField;

        private string _DescriptionField;

        private string _SequenceIdentifierField;

        private PRIA_NotaryCertificateSignerIdentificationTypeEnumerated _TypeField;

        private bool _TypeFieldSpecified;

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
        public PRIA_NotaryCertificateSignerIdentificationTypeEnumerated _Type
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
    }
}
