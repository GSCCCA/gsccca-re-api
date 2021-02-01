using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_STATUS_Type
    {

        //private PRIA_RECORDING_ERROR_Type[] rECORDING_ERRORField;
        private List<PRIA_RECORDING_ERROR_Type> rECORDING_ERRORField;

        private string _CodeField;

        private string _ConditionField;

        private string _DescriptionField;

        private string _NameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECORDING_ERROR")]
        public List<PRIA_RECORDING_ERROR_Type> RECORDING_ERROR
        //public PRIA_RECORDING_ERROR_Type[] RECORDING_ERROR
        {
            get
            {
                return this.rECORDING_ERRORField;
            }
            set
            {
                this.rECORDING_ERRORField = value;
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
        public string _Condition
        {
            get
            {
                return this._ConditionField;
            }
            set
            {
                this._ConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Description
        {
            get
            {
                return this._DescriptionField;
            }
            set
            {
                this._DescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Name
        {
            get
            {
                return this._NameField;
            }
            set
            {
                this._NameField = value;
            }
        }
    }
}
