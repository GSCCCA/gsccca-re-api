using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type
    {

        private string _IDField;

        private string recordingEndorsementFeeAmountField;

        private string recordingEndorsementFeeDescriptionField;

        private string recordingEndorsementFeeSequenceIdentifierField;

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
        public string RecordingEndorsementFeeAmount
        {
            get
            {
                return this.recordingEndorsementFeeAmountField;
            }
            set
            {
                this.recordingEndorsementFeeAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordingEndorsementFeeDescription
        {
            get
            {
                return this.recordingEndorsementFeeDescriptionField;
            }
            set
            {
                this.recordingEndorsementFeeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordingEndorsementFeeSequenceIdentifier
        {
            get
            {
                return this.recordingEndorsementFeeSequenceIdentifierField;
            }
            set
            {
                this.recordingEndorsementFeeSequenceIdentifierField = value;
            }
        }
    }
}
