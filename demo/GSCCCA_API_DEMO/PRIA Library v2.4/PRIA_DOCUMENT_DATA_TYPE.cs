using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;


namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DOCUMENT", Namespace = "", IsNullable = false)]

    public class PRIA_DOCUMENT_DATA_TYPE
    {
        private byte[] _data;

        private string _IDField;

        private string _CodeField;

        private string documentNonRecordableIndicatorField;

        private string pRIAVersionIdentifierField;

        private string _UniqueIdentifierField;

        private string recordableDocumentSequenceIdentifierField;

        private PRIA_RecordableDocumentTypeEnumerated recordableDocumentTypeField = PRIA_RecordableDocumentTypeEnumerated.Other;

        private bool recordableDocumentTypeFieldSpecified;

        private string recordableDocumentTypeOtherDescriptionField;

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

        [System.Xml.Serialization.XmlTextAttribute()]
        public byte[] DATA
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Code
        {
            get
            {
                return this._CodeField;
            }
            set
            {
                this._CodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DocumentNonRecordableIndicator
        {
            get
            {
                return this.documentNonRecordableIndicatorField;
            }
            set
            {
                this.documentNonRecordableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PRIAVersionIdentifier
        {
            get
            {
                return this.pRIAVersionIdentifierField;
            }
            set
            {
                this.pRIAVersionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _UniqueIdentifier
        {
            get
            {
                return this._UniqueIdentifierField;
            }
            set
            {
                this._UniqueIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordableDocumentSequenceIdentifier
        {
            get
            {
                return this.recordableDocumentSequenceIdentifierField;
            }
            set
            {
                this.recordableDocumentSequenceIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "RecordableDocumentType")]
        public PRIA_RecordableDocumentTypeEnumerated RecordableDocumentTypeCode
        {
            get
            {
                return this.recordableDocumentTypeField;
            }
            set
            {
                this.recordableDocumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecordableDocumentTypeSpecified
        {
            get
            {
                return this.recordableDocumentTypeFieldSpecified;
            }
            set
            {
                this.recordableDocumentTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordableDocumentTypeOtherDescription
        {
            get
            {
                return this.recordableDocumentTypeOtherDescriptionField;
            }
            set
            {
                this.recordableDocumentTypeOtherDescriptionField = value;
            }
        }
    }
}
