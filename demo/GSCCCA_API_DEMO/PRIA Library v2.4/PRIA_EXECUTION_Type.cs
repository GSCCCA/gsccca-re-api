using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_EXECUTION_Type
    {

        private string _IDField;

        private string _DateField;

        private string _CityField;

        private string _CountyField;

        private string _StateField;

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
        public string _Date
        {
            get
            {
                return this._DateField;
            }
            set
            {
                this._DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _City
        {
            get
            {
                return this._CityField;
            }
            set
            {
                this._CityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _County
        {
            get
            {
                return this._CountyField;
            }
            set
            {
                this._CountyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _State
        {
            get
            {
                return this._StateField;
            }
            set
            {
                this._StateField = value;
            }
        }
    }
}
