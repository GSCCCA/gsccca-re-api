using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PROPERTY_IDENTIFICATION_Type
    {

        private string _IDField;

        private string countyFIPSCodeField;

        private string stateFIPSCodeField;

        private string censusTractIdentifierField;

        private string mSAIdentifierField;

        private string municipalityNameField;

        private string schoolDistrictNameField;

        private string longitudeNumberField;

        private string latitudeNumberField;

        private string mapReferenceIdentifierField;

        private string mapReferenceSecondIdentifierField;

        private string assessorsParcelIdentifierField;

        private string assessorsSecondParcelIdentifierField;

        private string assessorsParcelIdentiferSequenceIdentifierField;

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
        public string CountyFIPSCode
        {
            get
            {
                return this.countyFIPSCodeField;
            }
            set
            {
                this.countyFIPSCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StateFIPSCode
        {
            get
            {
                return this.stateFIPSCodeField;
            }
            set
            {
                this.stateFIPSCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CensusTractIdentifier
        {
            get
            {
                return this.censusTractIdentifierField;
            }
            set
            {
                this.censusTractIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MSAIdentifier
        {
            get
            {
                return this.mSAIdentifierField;
            }
            set
            {
                this.mSAIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MunicipalityName
        {
            get
            {
                return this.municipalityNameField;
            }
            set
            {
                this.municipalityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchoolDistrictName
        {
            get
            {
                return this.schoolDistrictNameField;
            }
            set
            {
                this.schoolDistrictNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LongitudeNumber
        {
            get
            {
                return this.longitudeNumberField;
            }
            set
            {
                this.longitudeNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatitudeNumber
        {
            get
            {
                return this.latitudeNumberField;
            }
            set
            {
                this.latitudeNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MapReferenceIdentifier
        {
            get
            {
                return this.mapReferenceIdentifierField;
            }
            set
            {
                this.mapReferenceIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MapReferenceSecondIdentifier
        {
            get
            {
                return this.mapReferenceSecondIdentifierField;
            }
            set
            {
                this.mapReferenceSecondIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssessorsParcelIdentifier
        {
            get
            {
                return this.assessorsParcelIdentifierField;
            }
            set
            {
                this.assessorsParcelIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssessorsSecondParcelIdentifier
        {
            get
            {
                return this.assessorsSecondParcelIdentifierField;
            }
            set
            {
                this.assessorsSecondParcelIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AssessorsParcelIdentiferSequenceIdentifier
        {
            get
            {
                return this.assessorsParcelIdentiferSequenceIdentifierField;
            }
            set
            {
                this.assessorsParcelIdentiferSequenceIdentifierField = value;
            }
        }
    }
}
