using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Text;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PRIA_PACKAGE_Type
    {

        //private PRIA_DOCUMENT_Type[] pRIA_DOCUMENTField;
        //private PRIA_PAYMENT_Type[] pAYMENTField;
        private List<PRIA_DOCUMENT_Type> pRIA_DOCUMENTField;
        private List<PRIA_PAYMENT_Type> pAYMENTField;

        private string _IdentifierField;

        private string _SequenceIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PRIA_DOCUMENT")]
        public List<PRIA_DOCUMENT_Type> PRIA_DOCUMENT
        //public PRIA_DOCUMENT_Type[] PRIA_DOCUMENT
        {
            get
            {
                return this.pRIA_DOCUMENTField;
            }
            set
            {
                this.pRIA_DOCUMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PAYMENT")]
        public List<PRIA_PAYMENT_Type> PAYMENT
        //public PRIA_PAYMENT_Type[] PAYMENT
        {
            get
            {
                return this.pAYMENTField;
            }
            set
            {
                this.pAYMENTField = value;
            }
        }

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


        public string ToXmlString()
        {
            XmlSerializer xs;
            MemoryStream s = new MemoryStream();
            try
            {

                XmlWriter xw = new XmlTextWriter(s, Encoding.UTF8);
                xs = new XmlSerializer(typeof(PRIA_PACKAGE_Type));
                xs.Serialize(xw, this);
            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIA_PACKAGE_Type.ToXmlString()", se);
            }

            TextReader tr = new StreamReader(s);
            s.Seek(0, SeekOrigin.Begin);
            string xml = tr.ReadToEnd();
            return xml;

        }
    }
}
