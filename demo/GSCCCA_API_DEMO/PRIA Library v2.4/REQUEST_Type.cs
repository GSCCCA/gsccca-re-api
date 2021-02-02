using System.Xml.Serialization;
using System.Collections.Generic;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class REQUEST_Type
    {

        //private PRIA_KEY_Type[] kEYField;
        //private PRIA_REQUEST_Type[] pRIA_REQUESTField;
        private List<PRIA_KEY_Type> kEYField;
        private List<PRIA_REQUEST_Type> pRIA_REQUESTField;

        private string internalAccountIdentifierField;

        private string requestDateTimeField;

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
        [System.Xml.Serialization.XmlElementAttribute("PRIA_REQUEST")]
        public List<PRIA_REQUEST_Type> PRIA_REQUEST
        //public PRIA_REQUEST_Type[] PRIA_REQUEST
        {
            get
            {
                return this.pRIA_REQUESTField;
            }
            set
            {
                this.pRIA_REQUESTField = value;
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
        public string RequestDateTime
        {
            get
            {
                return this.requestDateTimeField;
            }
            set
            {
                this.requestDateTimeField = value;
            }
        }
    }
}
