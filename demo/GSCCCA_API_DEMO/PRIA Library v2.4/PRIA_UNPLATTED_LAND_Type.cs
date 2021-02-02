using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_UNPLATTED_LAND_Type
    {

        private string _IDField;

        private string _AbstractNumberIdentifierField;

        private string _BaseIdentifierField;

        private string _LandGrantIdentifierField;

        private string _MeridianIdentifierField;

        private string _MetesAndBoundsRemainingDescriptionField;

        private string _QuarterSectionIdentifierField;

        private string _SequenceIdentifierField;

        private PRIA_UnplattedLandDescriptionTypeEnumerated _DescriptionTypeField;

        private bool _DescriptionTypeFieldSpecified;

        private string _DescriptionTypeOtherDescriptionField;

        private string propertyRangeIdentifierField;

        private string propertySectionIdentifierField;

        private string propertyTownshipIdentifierField;

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
        public string _AbstractNumberIdentifier
        {
            get
            {
                return this._AbstractNumberIdentifierField;
            }
            set
            {
                this._AbstractNumberIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _BaseIdentifier
        {
            get
            {
                return this._BaseIdentifierField;
            }
            set
            {
                this._BaseIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _LandGrantIdentifier
        {
            get
            {
                return this._LandGrantIdentifierField;
            }
            set
            {
                this._LandGrantIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MeridianIdentifier
        {
            get
            {
                return this._MeridianIdentifierField;
            }
            set
            {
                this._MeridianIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MetesAndBoundsRemainingDescription
        {
            get
            {
                return this._MetesAndBoundsRemainingDescriptionField;
            }
            set
            {
                this._MetesAndBoundsRemainingDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _QuarterSectionIdentifier
        {
            get
            {
                return this._QuarterSectionIdentifierField;
            }
            set
            {
                this._QuarterSectionIdentifierField = value;
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
        public PRIA_UnplattedLandDescriptionTypeEnumerated _DescriptionType
        {
            get
            {
                return this._DescriptionTypeField;
            }
            set
            {
                this._DescriptionTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _DescriptionTypeSpecified
        {
            get
            {
                return this._DescriptionTypeFieldSpecified;
            }
            set
            {
                this._DescriptionTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _DescriptionTypeOtherDescription
        {
            get
            {
                return this._DescriptionTypeOtherDescriptionField;
            }
            set
            {
                this._DescriptionTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyRangeIdentifier
        {
            get
            {
                return this.propertyRangeIdentifierField;
            }
            set
            {
                this.propertyRangeIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertySectionIdentifier
        {
            get
            {
                return this.propertySectionIdentifierField;
            }
            set
            {
                this.propertySectionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyTownshipIdentifier
        {
            get
            {
                return this.propertyTownshipIdentifierField;
            }
            set
            {
                this.propertyTownshipIdentifierField = value;
            }
        }
    }
}
