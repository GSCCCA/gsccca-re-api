using System;
using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PROPERTY_Type
    {

        private PRIA_PROPERTY_IDENTIFICATION_Type _IDENTIFICATIONField;

        private PRIA_PARSED_STREET_ADDRESS_Type pARSED_STREET_ADDRESSField;

        private PRIA_PROPERTY_LEGAL_DESCRIPTION_Type[] _LEGAL_DESCRIPTIONField;

        private string _IDField;

        private string mISMOVersionIdField;

        private string _StreetAddressField;

        private string _StreetAddress2Field;

        private string _CityField;

        private string _StateField;

        private string _PostalCodeField;

        private string _CountyField;

        private string _CountryField;

        private PRIA_BuildingStatusTypeEnumerated buildingStatusTypeField;

        private bool buildingStatusTypeFieldSpecified;

        private PRIA_LandUseTypeEnumerated landUseTypeField;

        private bool landUseTypeFieldSpecified;

        private string landUseTypeOtherDescriptionField;

        private string landUseCommentField;

        private PRIA_PropertyCurrentOccupancyTypeEnumerated _CurrentOccupancyTypeField;

        private bool _CurrentOccupancyTypeFieldSpecified;

        private string _CurrentOccupantUnparsedNameField;

        private string _GatedCommunityIndicatorField;

        private PRIA_PropertyRightsTypeEnumerated _RightsTypeField;

        private bool _RightsTypeFieldSpecified;

        private string _TaxDelinquentIndicatorField;

        private PRIA_PropertyTitleCategoryTypeEnumerated _TitleCategoryTypeField;

        private bool _TitleCategoryTypeFieldSpecified;

        private string _TitleCategoryTypeOtherDescriptionField;

        /// <remarks/>
        public PRIA_PROPERTY_IDENTIFICATION_Type _IDENTIFICATION
        {
            get
            {
                return this._IDENTIFICATIONField;
            }
            set
            {
                this._IDENTIFICATIONField = value;
            }
        }

        /// <remarks/>
        public PRIA_PARSED_STREET_ADDRESS_Type PARSED_STREET_ADDRESS
        {
            get
            {
                return this.pARSED_STREET_ADDRESSField;
            }
            set
            {
                this.pARSED_STREET_ADDRESSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_LEGAL_DESCRIPTION")]
        public PRIA_PROPERTY_LEGAL_DESCRIPTION_Type[] _LEGAL_DESCRIPTION
        {
            get
            {
                return this._LEGAL_DESCRIPTIONField;
            }
            set
            {
                this._LEGAL_DESCRIPTIONField = value;
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
        public string MISMOVersionId
        {
            get
            {
                return this.mISMOVersionIdField;
            }
            set
            {
                this.mISMOVersionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _StreetAddress
        {
            get
            {
                return this._StreetAddressField;
            }
            set
            {
                this._StreetAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _StreetAddress2
        {
            get
            {
                return this._StreetAddress2Field;
            }
            set
            {
                this._StreetAddress2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _City
        {
            get
            {
                return this._CityField;
            }
            set
            {
                this._CityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _State
        {
            get
            {
                return this._StateField;
            }
            set
            {
                this._StateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PostalCode
        {
            get
            {
                return this._PostalCodeField;
            }
            set
            {
                this._PostalCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _County
        {
            get
            {
                return this._CountyField;
            }
            set
            {
                this._CountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Country
        {
            get
            {
                return this._CountryField;
            }
            set
            {
                this._CountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_BuildingStatusTypeEnumerated BuildingStatusType
        {
            get
            {
                return this.buildingStatusTypeField;
            }
            set
            {
                this.buildingStatusTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BuildingStatusTypeSpecified
        {
            get
            {
                return this.buildingStatusTypeFieldSpecified;
            }
            set
            {
                this.buildingStatusTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_LandUseTypeEnumerated LandUseType
        {
            get
            {
                return this.landUseTypeField;
            }
            set
            {
                this.landUseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LandUseTypeSpecified
        {
            get
            {
                return this.landUseTypeFieldSpecified;
            }
            set
            {
                this.landUseTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LandUseTypeOtherDescription
        {
            get
            {
                return this.landUseTypeOtherDescriptionField;
            }
            set
            {
                this.landUseTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LandUseComment
        {
            get
            {
                return this.landUseCommentField;
            }
            set
            {
                this.landUseCommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PropertyCurrentOccupancyTypeEnumerated _CurrentOccupancyType
        {
            get
            {
                return this._CurrentOccupancyTypeField;
            }
            set
            {
                this._CurrentOccupancyTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _CurrentOccupancyTypeSpecified
        {
            get
            {
                return this._CurrentOccupancyTypeFieldSpecified;
            }
            set
            {
                this._CurrentOccupancyTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CurrentOccupantUnparsedName
        {
            get
            {
                return this._CurrentOccupantUnparsedNameField;
            }
            set
            {
                this._CurrentOccupantUnparsedNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _GatedCommunityIndicator
        {
            get
            {
                return this._GatedCommunityIndicatorField;
            }
            set
            {
                this._GatedCommunityIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PropertyRightsTypeEnumerated _RightsType
        {
            get
            {
                return this._RightsTypeField;
            }
            set
            {
                this._RightsTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _RightsTypeSpecified
        {
            get
            {
                return this._RightsTypeFieldSpecified;
            }
            set
            {
                this._RightsTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _TaxDelinquentIndicator
        {
            get
            {
                return this._TaxDelinquentIndicatorField;
            }
            set
            {
                this._TaxDelinquentIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PropertyTitleCategoryTypeEnumerated _TitleCategoryType
        {
            get
            {
                return this._TitleCategoryTypeField;
            }
            set
            {
                this._TitleCategoryTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _TitleCategoryTypeSpecified
        {
            get
            {
                return this._TitleCategoryTypeFieldSpecified;
            }
            set
            {
                this._TitleCategoryTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _TitleCategoryTypeOtherDescription
        {
            get
            {
                return this._TitleCategoryTypeOtherDescriptionField;
            }
            set
            {
                this._TitleCategoryTypeOtherDescriptionField = value;
            }
        }
    }
}
