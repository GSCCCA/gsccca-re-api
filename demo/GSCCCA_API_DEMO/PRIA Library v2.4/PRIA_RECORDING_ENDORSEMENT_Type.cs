using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDING_ENDORSEMENT_Type
    {

        private PRIA_VOLUME_PAGE_Type[] _VOLUME_PAGEField;

        private PRIA_RECORDING_ENDORSEMENT_FEES_Type _FEESField;

        private PRIA_RECORDING_ENDORSEMENT_EXEMPTIONS_Type[] _EXEMPTIONSField;

        private MISMO_SIGNATURE_TYPE _SIGNATUREField;

        private string _IDField;

        private string _IdentifierField;

        private string _OfficersNameField;

        private string _InstrumentNumberIdentifierField;

        private string _PagesCountField;

        private string _VolumeField;

        private PRIA_RecordingEndorsementVolumeTypeEnumerated _VolumeTypeField;

        private bool _VolumeTypeFieldSpecified;

        private string _VolumeTypeOtherDescriptionField;

        private string _RecordedDateTimeField;

        private string _RecordedCountyField;

        private string _RecordedStateField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_VOLUME_PAGE")]
        public PRIA_VOLUME_PAGE_Type[] _VOLUME_PAGE
        {
            get
            {
                return this._VOLUME_PAGEField;
            }
            set
            {
                this._VOLUME_PAGEField = value;
            }
        }

        /// <remarks/>
        public PRIA_RECORDING_ENDORSEMENT_FEES_Type _FEES
        {
            get
            {
                return this._FEESField;
            }
            set
            {
                this._FEESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_EXEMPTIONS")]
        public PRIA_RECORDING_ENDORSEMENT_EXEMPTIONS_Type[] _EXEMPTIONS
        {
            get
            {
                return this._EXEMPTIONSField;
            }
            set
            {
                this._EXEMPTIONSField = value;
            }
        }

        /// <remarks/>
        public MISMO_SIGNATURE_TYPE _SIGNATURE
        {
            get
            {
                return this._SIGNATUREField;
            }
            set
            {
                this._SIGNATUREField = value;
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
        public string _Identifier
        {
            get
            {
                return this._IdentifierField;
            }
            set
            {
                this._IdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _OfficersName
        {
            get
            {
                return this._OfficersNameField;
            }
            set
            {
                this._OfficersNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _InstrumentNumberIdentifier
        {
            get
            {
                return this._InstrumentNumberIdentifierField;
            }
            set
            {
                this._InstrumentNumberIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _PagesCount
        {
            get
            {
                return this._PagesCountField;
            }
            set
            {
                this._PagesCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Volume
        {
            get
            {
                return this._VolumeField;
            }
            set
            {
                this._VolumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("_VolumeType")]
        public PRIA_RecordingEndorsementVolumeTypeEnumerated _VolumeTypeValue
        {
            get
            {
                return this._VolumeTypeField;
            }
            set
            {
                this._VolumeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _VolumeTypeSpecified
        {
            get
            {
                return this._VolumeTypeFieldSpecified;
            }
            set
            {
                this._VolumeTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _VolumeTypeOtherDescription
        {
            get
            {
                return this._VolumeTypeOtherDescriptionField;
            }
            set
            {
                this._VolumeTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecordedDateTime
        {
            get
            {
                return this._RecordedDateTimeField;
            }
            set
            {
                this._RecordedDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecordedCounty
        {
            get
            {
                return this._RecordedCountyField;
            }
            set
            {
                this._RecordedCountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecordedState
        {
            get
            {
                return this._RecordedStateField;
            }
            set
            {
                this._RecordedStateField = value;
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
    }
}
