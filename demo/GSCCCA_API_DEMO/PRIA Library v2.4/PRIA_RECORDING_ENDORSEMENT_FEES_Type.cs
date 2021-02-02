using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDING_ENDORSEMENT_FEES_Type
    {

        //private PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type[] _RECORDING_FEEField;
        private List<PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type> _RECORDING_FEEField;

        private string _IDField;

        private string _TotalAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_RECORDING_FEE")]
        public List<PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type> _RECORDING_FEE
        //public PRIA_RECORDING_ENDORSEMENT_FEES_RECORDING_FEE_Type[] _RECORDING_FEE
        {
            get
            {
                return this._RECORDING_FEEField;
            }
            set
            {
                this._RECORDING_FEEField = value;
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
        public string _TotalAmount
        {
            get
            {
                return this._TotalAmountField;
            }
            set
            {
                this._TotalAmountField = value;
            }
        }
    }
}
