using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PLATTED_LAND_Type
    {

        private string _IDField;

        private string _AdditionalParcelIdentifierField;

        private string _AdditionalParcelDescriptionField;

        private string _AppurtenanceDescriptionField;

        private string _AppurtenanceIdentifierField;

        private string _BuildingIdentifierField;

        private string _PlatCodeIdentifierField;

        private string _PlatInstrumentIdentifierField;

        private string _SequenceIdentifierField;

        private PRIA_PlattedLandTypeEnumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _UnitNumberIdentifierField;

        private string propertyLotIdentifierField;

        private string propertyBlockIdentifierField;

        private string propertySectionIdentifierField;

        private string propertySubdivisionIdentifierField;

        private string propertyTractIdentifierField;

        private string platNameField;

        private string recordedDocumentBookField;

        private string recordedDocumentPageField;

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
        public string _AdditionalParcelIdentifier
        {
            get
            {
                return this._AdditionalParcelIdentifierField;
            }
            set
            {
                this._AdditionalParcelIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AdditionalParcelDescription
        {
            get
            {
                return this._AdditionalParcelDescriptionField;
            }
            set
            {
                this._AdditionalParcelDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AppurtenanceDescription
        {
            get
            {
                return this._AppurtenanceDescriptionField;
            }
            set
            {
                this._AppurtenanceDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AppurtenanceIdentifier
        {
            get
            {
                return this._AppurtenanceIdentifierField;
            }
            set
            {
                this._AppurtenanceIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _BuildingIdentifier
        {
            get
            {
                return this._BuildingIdentifierField;
            }
            set
            {
                this._BuildingIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PlatCodeIdentifier
        {
            get
            {
                return this._PlatCodeIdentifierField;
            }
            set
            {
                this._PlatCodeIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PlatInstrumentIdentifier
        {
            get
            {
                return this._PlatInstrumentIdentifierField;
            }
            set
            {
                this._PlatInstrumentIdentifierField = value;
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
        public PRIA_PlattedLandTypeEnumerated _Type
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
        public string _UnitNumberIdentifier
        {
            get
            {
                return this._UnitNumberIdentifierField;
            }
            set
            {
                this._UnitNumberIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyLotIdentifier
        {
            get
            {
                return this.propertyLotIdentifierField;
            }
            set
            {
                this.propertyLotIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyBlockIdentifier
        {
            get
            {
                return this.propertyBlockIdentifierField;
            }
            set
            {
                this.propertyBlockIdentifierField = value;
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
        public string PropertySubdivisionIdentifier
        {
            get
            {
                return this.propertySubdivisionIdentifierField;
            }
            set
            {
                this.propertySubdivisionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyTractIdentifier
        {
            get
            {
                return this.propertyTractIdentifierField;
            }
            set
            {
                this.propertyTractIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlatName
        {
            get
            {
                return this.platNameField;
            }
            set
            {
                this.platNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordedDocumentBook
        {
            get
            {
                return this.recordedDocumentBookField;
            }
            set
            {
                this.recordedDocumentBookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordedDocumentPage
        {
            get
            {
                return this.recordedDocumentPageField;
            }
            set
            {
                this.recordedDocumentPageField = value;
            }
        }
    }
}
