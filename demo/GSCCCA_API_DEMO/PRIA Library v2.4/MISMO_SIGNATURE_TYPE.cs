using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MISMO_SIGNATURE_TYPE
    {

        private MISMO_ELECTRONIC_SIGNATURE_Type eLECTRONIC_SIGNATUREField;

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string nameSuffixField;

        private string unparsedNameField;

        private string signingCapacityDescriptionField;

        private string organizationNameField;

        private string organizationPositionDescriptionField;

        private string signatureDateField;

        private string sequenceIdentifierField;

        private System.DateTime signatureTimeStampField;

        private bool signatureTimeStampFieldSpecified;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MISMO_ELECTRONIC_SIGNATURE_Type ELECTRONIC_SIGNATURE
        {
            get
            {
                return this.eLECTRONIC_SIGNATUREField;
            }
            set
            {
                this.eLECTRONIC_SIGNATUREField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnparsedName
        {
            get
            {
                return this.unparsedNameField;
            }
            set
            {
                this.unparsedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SigningCapacityDescription
        {
            get
            {
                return this.signingCapacityDescriptionField;
            }
            set
            {
                this.signingCapacityDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OrganizationPositionDescription
        {
            get
            {
                return this.organizationPositionDescriptionField;
            }
            set
            {
                this.organizationPositionDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SignatureDate
        {
            get
            {
                return this.signatureDateField;
            }
            set
            {
                this.signatureDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SequenceIdentifier
        {
            get
            {
                return this.sequenceIdentifierField;
            }
            set
            {
                this.sequenceIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime SignatureTimeStamp
        {
            get
            {
                return this.signatureTimeStampField;
            }
            set
            {
                this.signatureTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignatureTimeStampSpecified
        {
            get
            {
                return this.signatureTimeStampFieldSpecified;
            }
            set
            {
                this.signatureTimeStampFieldSpecified = value;
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
