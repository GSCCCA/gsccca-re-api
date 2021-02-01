using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_CONTACT_POINT_Type
    {

        private string _IDField;

        private string _PreferenceIndicatorField;

        private PRIA_ContactPointRoleTypeEnumerated _RoleTypeField;

        private bool _RoleTypeFieldSpecified;

        private PRIA_ContactPointTypeEnumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _ValueField;

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
        public string _PreferenceIndicator
        {
            get
            {
                return this._PreferenceIndicatorField;
            }
            set
            {
                this._PreferenceIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_ContactPointRoleTypeEnumerated _RoleType
        {
            get
            {
                return this._RoleTypeField;
            }
            set
            {
                this._RoleTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _RoleTypeSpecified
        {
            get
            {
                return this._RoleTypeFieldSpecified;
            }
            set
            {
                this._RoleTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_ContactPointTypeEnumerated _Type
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
