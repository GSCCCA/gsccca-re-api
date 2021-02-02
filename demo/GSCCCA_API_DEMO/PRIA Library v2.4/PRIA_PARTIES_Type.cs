using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PARTIES_Type
    {

        //private PRIA_PARTIES_RETURN_TO_PARTY_Type[] _RETURN_TO_PARTYField;
        //private PRIA_PARTIES_PREPARED_BY_PARTY_Type[] _PREPARED_BY_PARTYField;
        //private PRIA_TAXABLE_PARTY_Type[] tAXABLE_PARTYField;
        //private PRIA_BILL_TO_PARTY_Type[] bILL_TO_PARTYField;
        //private PRIA_WITNESS_Type[] wITNESSField;

        private List<PRIA_PARTIES_RETURN_TO_PARTY_Type> _RETURN_TO_PARTYField;
        private List<PRIA_PARTIES_PREPARED_BY_PARTY_Type> _PREPARED_BY_PARTYField;
        private List<PRIA_TAXABLE_PARTY_Type> tAXABLE_PARTYField;
        private List<PRIA_BILL_TO_PARTY_Type> bILL_TO_PARTYField;
        private List<PRIA_WITNESS_Type> wITNESSField;

        private string _IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_RETURN_TO_PARTY")]
        public List<PRIA_PARTIES_RETURN_TO_PARTY_Type> _RETURN_TO_PARTY
        //public PRIA_PARTIES_RETURN_TO_PARTY_Type[] _RETURN_TO_PARTY
        {
            get
            {
                return this._RETURN_TO_PARTYField;
            }
            set
            {
                this._RETURN_TO_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_PREPARED_BY_PARTY")]
        public List<PRIA_PARTIES_PREPARED_BY_PARTY_Type> _PREPARED_BY_PARTY
        //public PRIA_PARTIES_PREPARED_BY_PARTY_Type[] _PREPARED_BY_PARTY
        {
            get
            {
                return this._PREPARED_BY_PARTYField;
            }
            set
            {
                this._PREPARED_BY_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TAXABLE_PARTY")]
        public List<PRIA_TAXABLE_PARTY_Type> TAXABLE_PARTY
        //public PRIA_TAXABLE_PARTY_Type[] TAXABLE_PARTY
        {
            get
            {
                return this.tAXABLE_PARTYField;
            }
            set
            {
                this.tAXABLE_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BILL_TO_PARTY")]
        public List<PRIA_BILL_TO_PARTY_Type> BILL_TO_PARTY
        //public PRIA_BILL_TO_PARTY_Type[] BILL_TO_PARTY
        {
            get
            {
                return this.bILL_TO_PARTYField;
            }
            set
            {
                this.bILL_TO_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WITNESS")]
        public List<PRIA_WITNESS_Type> WITNESS
        //public PRIA_WITNESS_Type[] WITNESS
        {
            get
            {
                return this.wITNESSField;
            }
            set
            {
                this.wITNESSField = value;
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
    }
}
