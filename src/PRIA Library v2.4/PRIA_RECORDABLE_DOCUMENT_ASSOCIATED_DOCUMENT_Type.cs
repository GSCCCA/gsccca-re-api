using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDABLE_DOCUMENT_ASSOCIATED_DOCUMENT_Type
    {

        private string _IDField;

        private string _BookNumberField;

        private PRIA_RecordableDocumentAssociatedDocumentBookTypeEnumerated _BookTypeField;

        private bool _BookTypeFieldSpecified;

        private string _BookTypeOtherDescriptionField;

        private string _CodeField;

        private string _CountyOfRecordationNameField;

        private string _TitleField;

        private string _InstrumentNumberField;

        private string _NumberField;

        private string _OfficeOfRecordationNameField;

        private string _PageNumberField;

        private string _RecordingDateField;

        private string _RecordingJurisdictionNameField;

        private string _SequenceIdentifierField;

        private string _StateOfRecordationNameField;

        private PRIA_RecordableDocumentAssociatedDocumentTypeEnumerated _TypeField;

        private bool _TypeFieldSpecified;

        private string _TypeOtherDescriptionField;

        private string _VolumeNumberField;

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
        public string _BookNumber
        {
            get
            {
                return this._BookNumberField;
            }
            set
            {
                this._BookNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_RecordableDocumentAssociatedDocumentBookTypeEnumerated _BookType
        {
            get
            {
                return this._BookTypeField;
            }
            set
            {
                this._BookTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _BookTypeSpecified
        {
            get
            {
                return this._BookTypeFieldSpecified;
            }
            set
            {
                this._BookTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _BookTypeOtherDescription
        {
            get
            {
                return this._BookTypeOtherDescriptionField;
            }
            set
            {
                this._BookTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Code
        {
            get
            {
                return this._CodeField;
            }
            set
            {
                this._CodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _CountyOfRecordationName
        {
            get
            {
                return this._CountyOfRecordationNameField;
            }
            set
            {
                this._CountyOfRecordationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Title
        {
            get
            {
                return this._TitleField;
            }
            set
            {
                this._TitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _InstrumentNumber
        {
            get
            {
                return this._InstrumentNumberField;
            }
            set
            {
                this._InstrumentNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Number
        {
            get
            {
                return this._NumberField;
            }
            set
            {
                this._NumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _OfficeOfRecordationName
        {
            get
            {
                return this._OfficeOfRecordationNameField;
            }
            set
            {
                this._OfficeOfRecordationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PageNumber
        {
            get
            {
                return this._PageNumberField;
            }
            set
            {
                this._PageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecordingDate
        {
            get
            {
                return this._RecordingDateField;
            }
            set
            {
                this._RecordingDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecordingJurisdictionName
        {
            get
            {
                return this._RecordingJurisdictionNameField;
            }
            set
            {
                this._RecordingJurisdictionNameField = value;
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
        public string _StateOfRecordationName
        {
            get
            {
                return this._StateOfRecordationNameField;
            }
            set
            {
                this._StateOfRecordationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_RecordableDocumentAssociatedDocumentTypeEnumerated _Type
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
        public string _VolumeNumber
        {
            get
            {
                return this._VolumeNumberField;
            }
            set
            {
                this._VolumeNumberField = value;
            }
        }
    }
}
