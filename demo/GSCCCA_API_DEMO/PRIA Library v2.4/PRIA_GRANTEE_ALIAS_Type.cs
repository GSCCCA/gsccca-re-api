using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_GRANTEE_ALIAS_Type
    {

        private string _IDField;

        private string _FirstNameField;

        private string _MiddleNameField;

        private string _LastNameField;

        private string _NameSuffixField;

        private string _UnparsedNameField;

        private string _SequenceIdentifierField;

        private PRIA_AliasTypeEnumerated aliasTypeField;

        private bool aliasTypeFieldSpecified;

        private string aliasTypeOtherDescriptionField;

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
        public string _FirstName
        {
            get
            {
                return this._FirstNameField;
            }
            set
            {
                this._FirstNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MiddleName
        {
            get
            {
                return this._MiddleNameField;
            }
            set
            {
                this._MiddleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _LastName
        {
            get
            {
                return this._LastNameField;
            }
            set
            {
                this._LastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _NameSuffix
        {
            get
            {
                return this._NameSuffixField;
            }
            set
            {
                this._NameSuffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _UnparsedName
        {
            get
            {
                return this._UnparsedNameField;
            }
            set
            {
                this._UnparsedNameField = value;
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
        public PRIA_AliasTypeEnumerated AliasType
        {
            get
            {
                return this.aliasTypeField;
            }
            set
            {
                this.aliasTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AliasTypeSpecified
        {
            get
            {
                return this.aliasTypeFieldSpecified;
            }
            set
            {
                this.aliasTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AliasTypeOtherDescription
        {
            get
            {
                return this.aliasTypeOtherDescriptionField;
            }
            set
            {
                this.aliasTypeOtherDescriptionField = value;
            }
        }
    }
}
