using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_MORTGAGE_CONSIDERATION_Type
    {

        private string _IDField;

        private string hELOCInitialAdvanceAmountField;

        private string originalLoanAmountField;

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
        public string HELOCInitialAdvanceAmount
        {
            get
            {
                return this.hELOCInitialAdvanceAmountField;
            }
            set
            {
                this.hELOCInitialAdvanceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalLoanAmount
        {
            get
            {
                return this.originalLoanAmountField;
            }
            set
            {
                this.originalLoanAmountField = value;
            }
        }
    }
}
