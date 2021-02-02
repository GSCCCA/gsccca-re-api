using System.Xml.Serialization;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_ORIGINATING_RECORDING_REQUEST_Type
    {

        private string _IdentifierField;

        private string digtialSignatureHashValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _Identifier
        {
            get
            {
                return this._IdentifierField;
            }
            set
            {
                this._IdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DigtialSignatureHashValue
        {
            get
            {
                return this.digtialSignatureHashValueField;
            }
            set
            {
                this.digtialSignatureHashValueField = value;
            }
        }
    }
}
