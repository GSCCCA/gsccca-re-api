using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_AUTHORIZED_REPRESENTATIVE_Type
    {

        private PRIA_CONTACT_DETAIL_Type cONTACT_DETAILField;

        private string _IDField;

        private string _UnparsedNameField;

        private string _TitleDescriptionField;

        private string authorizedToSignIndicatorField;

        /// <remarks/>
        public PRIA_CONTACT_DETAIL_Type CONTACT_DETAIL
        {
            get
            {
                return this.cONTACT_DETAILField;
            }
            set
            {
                this.cONTACT_DETAILField = value;
            }
        }

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
        public string _TitleDescription
        {
            get
            {
                return this._TitleDescriptionField;
            }
            set
            {
                this._TitleDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AuthorizedToSignIndicator
        {
            get
            {
                return this.authorizedToSignIndicatorField;
            }
            set
            {
                this.authorizedToSignIndicatorField = value;
            }
        }
    }
}
