using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PROPERTY_LEGAL_DESCRIPTION_Type
    {

        private PRIA_PARCEL_IDENTIFICATION_Type pARCEL_IDENTIFICATIONField;

        private PRIA_PLATTED_LAND_Type pLATTED_LANDField;

        private PRIA_UNPLATTED_LAND_Type uNPLATTED_LANDField;

        private string _IDField;

        private string _TextDescriptionField;

        private PRIA_PropertyLegalDescriptionTypeEnumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        /// <remarks/>
        public PRIA_PARCEL_IDENTIFICATION_Type PARCEL_IDENTIFICATION
        {
            get
            {
                return this.pARCEL_IDENTIFICATIONField;
            }
            set
            {
                this.pARCEL_IDENTIFICATIONField = value;
            }
        }

        /// <remarks/>
        public PRIA_PLATTED_LAND_Type PLATTED_LAND
        {
            get
            {
                return this.pLATTED_LANDField;
            }
            set
            {
                this.pLATTED_LANDField = value;
            }
        }

        /// <remarks/>
        public PRIA_UNPLATTED_LAND_Type UNPLATTED_LAND
        {
            get
            {
                return this.uNPLATTED_LANDField;
            }
            set
            {
                this.uNPLATTED_LANDField = value;
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
        public string _TextDescription
        {
            get
            {
                return this._TextDescriptionField;
            }
            set
            {
                this._TextDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PropertyLegalDescriptionTypeEnumerated _Type
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
    }
}
