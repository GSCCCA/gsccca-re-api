using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_RECORDABLE_DOCUMENT_Type
    {

        private PRIA_RECORDABLE_DOCUMENT_ASSOCIATED_DOCUMENT_Type[] _ASSOCIATED_DOCUMENTField;

        private string _IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("_ASSOCIATED_DOCUMENT")]
        public PRIA_RECORDABLE_DOCUMENT_ASSOCIATED_DOCUMENT_Type[] _ASSOCIATED_DOCUMENT
        {
            get
            {
                return this._ASSOCIATED_DOCUMENTField;
            }
            set
            {
                this._ASSOCIATED_DOCUMENTField = value;
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
