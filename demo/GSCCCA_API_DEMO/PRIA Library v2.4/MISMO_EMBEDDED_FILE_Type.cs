using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MISMO_EMBEDDED_FILE_Type
    {

        private MISMO_DOCUMENT_Type dOCUMENTField;

        private string idField;

        private string embeddedFileTypeField;

        private string embeddedFileVersionField;

        private string embeddedFileNameField;

        private string fileEncodingTypeField;

        private string embeddedFileDescriptionField;

        private string mIMETypeField;

        private string pageCountField;

        private string signatureSequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MISMO_DOCUMENT_Type DOCUMENT
        {
            get
            {
                return this.dOCUMENTField;
            }
            set
            {
                this.dOCUMENTField = value;
            }
        }

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
        public string EmbeddedFileType
        {
            get
            {
                return this.embeddedFileTypeField;
            }
            set
            {
                this.embeddedFileTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmbeddedFileVersion
        {
            get
            {
                return this.embeddedFileVersionField;
            }
            set
            {
                this.embeddedFileVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmbeddedFileName
        {
            get
            {
                return this.embeddedFileNameField;
            }
            set
            {
                this.embeddedFileNameField = value;
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
        public string EmbeddedFileDescription
        {
            get
            {
                return this.embeddedFileDescriptionField;
            }
            set
            {
                this.embeddedFileDescriptionField = value;
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
