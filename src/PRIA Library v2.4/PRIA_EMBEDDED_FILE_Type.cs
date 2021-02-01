using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_EMBEDDED_FILE_Type
    {

        //private PRIA_DOCUMENT_Type dOCUMENTField;
        //private byte[] dOCUMENTField;
        private PRIA_DOCUMENT_DATA_TYPE documentData;

        private string idField;

        private string embeddedFileTypeField;

        private string embeddedFileVersionField;

        private string embeddedFileNameField;

        private string fileEncodingTypeField;

        private string fileDescriptionField;

        private string mIMETypeField;

        /// <remarks/>
        //public PRIA_DOCUMENT_Type DOCUMENT
        //{
        //    get
        //    {
        //        return this.dOCUMENTField;
        //    }
        //    set
        //    {
        //        this.dOCUMENTField = value;
        //    }
        //}

        //public byte[] DOCUMENT
        //{
        //    get
        //    {
        //        return this.dOCUMENTField;
        //    }
        //    set
        //    {
        //        this.dOCUMENTField = value;
        //    }
        //}

        [System.Xml.Serialization.XmlElementAttribute()]
        public PRIA_DOCUMENT_DATA_TYPE DOCUMENT
        {
            get
            {
                return this.documentData;
            }
            set { this.documentData = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }
}
