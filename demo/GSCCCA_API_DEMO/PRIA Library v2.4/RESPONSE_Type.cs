using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRIALibraryV24
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RESPONSE_Type
    {

        //private PRIA_KEY_Type[] kEYField;
        //private PRIA_RESPONSE_Type[][] rESPONSE_DATAField;
        //private PRIA_STATUS_Type[] sTATUSField;

        private List<PRIA_KEY_Type> kEYField;
        private List<PRIA_RESPONSE_Type> rESPONSE_DATAField;
        private List<PRIA_STATUS_Type> sTATUSField;

        private string internalAccountIdentifierField;

        private string responseDateTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KEY")]
        public List<PRIA_KEY_Type> KEY
        //public PRIA_KEY_Type[] KEY
        {
            get
            {
                return this.kEYField;
            }
            set
            {
                this.kEYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PRIA_RESPONSE", typeof(PRIA_RESPONSE_Type), IsNullable = false)]
        public List<PRIA_RESPONSE_Type> RESPONSE_DATA
        //public PRIA_RESPONSE_Type[][] RESPONSE_DATA
        {
            get
            {
                return this.rESPONSE_DATAField;
            }
            set
            {
                this.rESPONSE_DATAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("STATUS")]
        public List<PRIA_STATUS_Type> STATUS
        //public PRIA_STATUS_Type[] STATUS
        {
            get
            {
                return this.sTATUSField;
            }
            set
            {
                this.sTATUSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InternalAccountIdentifier
        {
            get
            {
                return this.internalAccountIdentifierField;
            }
            set
            {
                this.internalAccountIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResponseDateTime
        {
            get
            {
                return this.responseDateTimeField;
            }
            set
            {
                this.responseDateTimeField = value;
            }
        }
    }
}
