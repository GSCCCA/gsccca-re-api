using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MISMO_ELECTRONIC_SIGNATURE_Type
    {

        private object itemField;

        private ElectronicSignatureTypeEnumerated electronicSignatureTypeField;

        private bool electronicSignatureTypeFieldSpecified;

        private string electronicSignatureTypeOtherDescriptionField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EMBEDED_SIGNATURE_FILE", typeof(MISMO_EMBEDDED_FILE_Type), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("EXTERNAL_SIGNATURE_FILE", typeof(MISMO_EXTERNAL_FILE_Type), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("OTHER_SIGNATURE", typeof(MISMO_ELECTRONIC_SIGNATURE_TypeOTHER_SIGNATURE), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SIGNATURE_TEXT", typeof(SIGNATURE_TEXT_Type), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", typeof(Signature_Type), Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ElectronicSignatureTypeEnumerated ElectronicSignatureType
        {
            get
            {
                return this.electronicSignatureTypeField;
            }
            set
            {
                this.electronicSignatureTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ElectronicSignatureTypeSpecified
        {
            get
            {
                return this.electronicSignatureTypeFieldSpecified;
            }
            set
            {
                this.electronicSignatureTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ElectronicSignatureTypeOtherDescription
        {
            get
            {
                return this.electronicSignatureTypeOtherDescriptionField;
            }
            set
            {
                this.electronicSignatureTypeOtherDescriptionField = value;
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
    }
}
