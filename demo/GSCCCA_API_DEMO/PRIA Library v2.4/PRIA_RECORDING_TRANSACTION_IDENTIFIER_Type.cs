using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDING_TRANSACTION_IDENTIFIER_Type
    {

        private PRIA_RecordingTransactionIdentifierType_Enumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _ValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_RecordingTransactionIdentifierType_Enumerated _Type
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
        public string _Value
        {
            get
            {
                return this._ValueField;
            }
            set
            {
                this._ValueField = value;
            }
        }
    }
}
