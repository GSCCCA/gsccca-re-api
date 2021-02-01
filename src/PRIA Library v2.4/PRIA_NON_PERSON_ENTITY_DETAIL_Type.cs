using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_NON_PERSON_ENTITY_DETAIL_Type
    {

        private PRIA_AUTHORIZED_REPRESENTATIVE_Type[] aUTHORIZED_REPRESENTATIVEField;

        private string _IDField;

        private PRIA_NonPersonEntityDetailOrganizationTypeEnumerated _OrganizationTypeField;

        private bool _OrganizationTypeFieldSpecified;

        private string _OrganizationTypeOtherDescriptionField;

        private string _OrganizedUnderTheLawsOfJurisdictionNameField;

        private string _SuccessorClauseTextDescriptionField;

        private string _TaxIdentificationNumberIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AUTHORIZED_REPRESENTATIVE")]
        public PRIA_AUTHORIZED_REPRESENTATIVE_Type[] AUTHORIZED_REPRESENTATIVE
        {
            get
            {
                return this.aUTHORIZED_REPRESENTATIVEField;
            }
            set
            {
                this.aUTHORIZED_REPRESENTATIVEField = value;
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
        public PRIA_NonPersonEntityDetailOrganizationTypeEnumerated _OrganizationType
        {
            get
            {
                return this._OrganizationTypeField;
            }
            set
            {
                this._OrganizationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _OrganizationTypeSpecified
        {
            get
            {
                return this._OrganizationTypeFieldSpecified;
            }
            set
            {
                this._OrganizationTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _OrganizationTypeOtherDescription
        {
            get
            {
                return this._OrganizationTypeOtherDescriptionField;
            }
            set
            {
                this._OrganizationTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _OrganizedUnderTheLawsOfJurisdictionName
        {
            get
            {
                return this._OrganizedUnderTheLawsOfJurisdictionNameField;
            }
            set
            {
                this._OrganizedUnderTheLawsOfJurisdictionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _SuccessorClauseTextDescription
        {
            get
            {
                return this._SuccessorClauseTextDescriptionField;
            }
            set
            {
                this._SuccessorClauseTextDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _TaxIdentificationNumberIdentifier
        {
            get
            {
                return this._TaxIdentificationNumberIdentifierField;
            }
            set
            {
                this._TaxIdentificationNumberIdentifierField = value;
            }
        }
    }
}
