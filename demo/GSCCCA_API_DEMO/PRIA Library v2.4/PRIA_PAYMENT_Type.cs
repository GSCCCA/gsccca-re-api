using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PAYMENT_Type
    {

        private PRIA_SERVICE_PAYMENT_Type sERVICE_PAYMENTField;

        private PRIA_PaymentMethodType_Enumerated _MethodTypeField;

        private bool _MethodTypeFieldSpecified;

        private string _MethodTypeOtherDescriptionField;

        private string _AmountField;

        private string _RecorderOnAccountIdentifierField;

        private string _RecorderOnAccountMaximumDebitAmountField;

        private string _RecorderOnAccountMinimumBalanceAmountField;

        private string _AccountIdentifierField;

        private string _ReferenceIdentifierField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        public PRIA_SERVICE_PAYMENT_Type SERVICE_PAYMENT
        {
            get
            {
                return this.sERVICE_PAYMENTField;
            }
            set
            {
                this.sERVICE_PAYMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PRIA_PaymentMethodType_Enumerated _MethodType
        {
            get
            {
                return this._MethodTypeField;
            }
            set
            {
                this._MethodTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool _MethodTypeSpecified
        {
            get
            {
                return this._MethodTypeFieldSpecified;
            }
            set
            {
                this._MethodTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _MethodTypeOtherDescription
        {
            get
            {
                return this._MethodTypeOtherDescriptionField;
            }
            set
            {
                this._MethodTypeOtherDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Amount
        {
            get
            {
                return this._AmountField;
            }
            set
            {
                this._AmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecorderOnAccountIdentifier
        {
            get
            {
                return this._RecorderOnAccountIdentifierField;
            }
            set
            {
                this._RecorderOnAccountIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecorderOnAccountMaximumDebitAmount
        {
            get
            {
                return this._RecorderOnAccountMaximumDebitAmountField;
            }
            set
            {
                this._RecorderOnAccountMaximumDebitAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _RecorderOnAccountMinimumBalanceAmount
        {
            get
            {
                return this._RecorderOnAccountMinimumBalanceAmountField;
            }
            set
            {
                this._RecorderOnAccountMinimumBalanceAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _AccountIdentifier
        {
            get
            {
                return this._AccountIdentifierField;
            }
            set
            {
                this._AccountIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _ReferenceIdentifier
        {
            get
            {
                return this._ReferenceIdentifierField;
            }
            set
            {
                this._ReferenceIdentifierField = value;
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
