using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_CONTACT_DETAIL_Type
    {

        private PRIA_CONTACT_POINT_Type[] cONTACT_POINTField;

        private string _IDField;

        private string _NameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONTACT_POINT")]
        public PRIA_CONTACT_POINT_Type[] CONTACT_POINT
        {
            get
            {
                return this.cONTACT_POINTField;
            }
            set
            {
                this.cONTACT_POINTField = value;
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
