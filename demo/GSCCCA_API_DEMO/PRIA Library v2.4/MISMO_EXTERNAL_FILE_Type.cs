using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MISMO_EXTERNAL_FILE_Type
    {

        private string idField;

        private string fileEncodingTypeField;

        private string fileDescriptionField;

        private string mIMETypeField;

        private string uRIField;

        private string pageCountField;

        private string signatureSequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileEncodingType
        {
            get
            {
                return this.fileEncodingTypeField;
            }
            set
            {
                this.fileEncodingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileDescription
        {
            get
            {
                return this.fileDescriptionField;
            }
            set
            {
                this.fileDescriptionField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PageCount
        {
            get
            {
                return this.pageCountField;
            }
            set
            {
                this.pageCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SignatureSequenceIdentifier
        {
            get
            {
                return this.signatureSequenceIdentifierField;
            }
            set
            {
                this.signatureSequenceIdentifierField = value;
            }
        }
    }
}
