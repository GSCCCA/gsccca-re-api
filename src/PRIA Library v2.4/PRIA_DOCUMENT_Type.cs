using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Text;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("PRIA_DOCUMENT", Namespace = "", IsNullable = false)]
    public partial class PRIA_DOCUMENT_Type
    {

        private PRIA_GRANTOR_Type[] gRANTORField;

        private PRIA_GRANTEE_Type[] gRANTEEField;

        private PRIA_PROPERTY_Type[] pROPERTYField;

        private PRIA_PARTIES_Type pARTIESField;

        private PRIA_EXECUTION_Type eXECUTIONField;

        private PRIA_MORTGAGE_CONSIDERATION_Type mORTGAGE_CONSIDERATIONField;

        private PRIA_CONSIDERATION_Type[] cONSIDERATIONField;

        private PRIA_RECORDABLE_DOCUMENT_Type[] rECORDABLE_DOCUMENTField;

        private MISMO_SIGNATURE_TYPE[] sIGNATORYField;

        private PRIA_NOTARY_Type[] nOTARYField;

        private PRIA_RECORDING_ENDORSEMENT_Type rECORDING_ENDORSEMENTField;

        private PRIA_EMBEDDED_FILE_Type[] eMBEDDED_FILEField;

        private string _IDField;

        private string _CodeField;

        private string documentNonRecordableIndicatorField;

        private string pRIAVersionIdentifierField;

        private string _UniqueIdentifierField;

        private string recordableDocumentSequenceIdentifierField;

        private PRIA_RecordableDocumentTypeEnumerated recordableDocumentTypeField = PRIA_RecordableDocumentTypeEnumerated.Other;

        private bool recordableDocumentTypeFieldSpecified;

        private string recordableDocumentTypeOtherDescriptionField;

        public static PRIA_DOCUMENT_Type FromXML(string priaXML)
        {
            StringReader sr;
            XmlReader reader;
            XmlSerializer xs;
            XmlReaderSettings settings;
            PRIA_DOCUMENT_Type priaType = null;
            
            sr = new StringReader(priaXML);
            settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            reader = XmlReader.Create(sr, settings);
            xs = new XmlSerializer(typeof(PRIA_DOCUMENT_Type));
            priaType = (PRIA_DOCUMENT_Type)xs.Deserialize(reader);

            return priaType;
        }





        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GRANTOR")]
        public PRIA_GRANTOR_Type[] GRANTOR
        {
            get
            {
                return this.gRANTORField;
            }
            set
            {
                this.gRANTORField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GRANTEE")]
        public PRIA_GRANTEE_Type[] GRANTEE
        {
            get
            {
                return this.gRANTEEField;
            }
            set
            {
                this.gRANTEEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PROPERTY")]
        public PRIA_PROPERTY_Type[] PROPERTY
        {
            get
            {
                return this.pROPERTYField;
            }
            set
            {
                this.pROPERTYField = value;
            }
        }

        /// <remarks/>
        public PRIA_PARTIES_Type PARTIES
        {
            get
            {
                return this.pARTIESField;
            }
            set
            {
                this.pARTIESField = value;
            }
        }

        /// <remarks/>
        public PRIA_EXECUTION_Type EXECUTION
        {
            get
            {
                return this.eXECUTIONField;
            }
            set
            {
                this.eXECUTIONField = value;
            }
        }

        /// <remarks/>
        public PRIA_MORTGAGE_CONSIDERATION_Type MORTGAGE_CONSIDERATION
        {
            get
            {
                return this.mORTGAGE_CONSIDERATIONField;
            }
            set
            {
                this.mORTGAGE_CONSIDERATIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CONSIDERATION")]
        public PRIA_CONSIDERATION_Type[] CONSIDERATION
        {
            get
            {
                return this.cONSIDERATIONField;
            }
            set
            {
                this.cONSIDERATIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECORDABLE_DOCUMENT")]
        public PRIA_RECORDABLE_DOCUMENT_Type[] RECORDABLE_DOCUMENT
        {
            get
            {
                return this.rECORDABLE_DOCUMENTField;
            }
            set
            {
                this.rECORDABLE_DOCUMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SIGNATORY")]
        public MISMO_SIGNATURE_TYPE[] SIGNATORY
        {
            get
            {
                return this.sIGNATORYField;
            }
            set
            {
                this.sIGNATORYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NOTARY")]
        public PRIA_NOTARY_Type[] NOTARY
        {
            get
            {
                return this.nOTARYField;
            }
            set
            {
                this.nOTARYField = value;
            }
        }

        /// <remarks/>
        public PRIA_RECORDING_ENDORSEMENT_Type RECORDING_ENDORSEMENT
        {
            get
            {
                return this.rECORDING_ENDORSEMENTField;
            }
            set
            {
                this.rECORDING_ENDORSEMENTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EMBEDDED_FILE")]
        public PRIA_EMBEDDED_FILE_Type[] EMBEDDED_FILE
        {
            get
            {
                return this.eMBEDDED_FILEField;
            }
            set
            {
                this.eMBEDDED_FILEField = value;
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
        public string DocumentNonRecordableIndicator
        {
            get
            {
                return this.documentNonRecordableIndicatorField;
            }
            set
            {
                this.documentNonRecordableIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PRIAVersionIdentifier
        {
            get
            {
                return this.pRIAVersionIdentifierField;
            }
            set
            {
                this.pRIAVersionIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string _UniqueIdentifier
        {
            get
            {
                return this._UniqueIdentifierField;
            }
            set
            {
                this._UniqueIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordableDocumentSequenceIdentifier
        {
            get
            {
                return this.recordableDocumentSequenceIdentifierField;
            }
            set
            {
                this.recordableDocumentSequenceIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="RecordableDocumentType")]
        public PRIA_RecordableDocumentTypeEnumerated RecordableDocumentTypeCode
        {
            get
            {
                return this.recordableDocumentTypeField;
            }
            set
            {
                this.recordableDocumentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecordableDocumentTypeSpecified
        {
            get
            {
                return this.recordableDocumentTypeFieldSpecified;
            }
            set
            {
                this.recordableDocumentTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RecordableDocumentTypeOtherDescription
        {
            get
            {
                return this.recordableDocumentTypeOtherDescriptionField;
            }
            set
            {
                this.recordableDocumentTypeOtherDescriptionField = value;
            }
        }

        public string ToXmlString()
        {

            XmlSerializer xs;
            MemoryStream s = new MemoryStream();
            try
            {

                XmlWriter xw = new XmlTextWriter(s, Encoding.UTF8);
                xs = new XmlSerializer(typeof(PRIA_DOCUMENT_Type));
                xs.Serialize(xw, this);
            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIA_DOCUMENT_Type.ToXmlString()", se);
            }

            TextReader tr = new StreamReader(s);
            s.Seek(0, SeekOrigin.Begin);
            string xml = tr.ReadToEnd();
            return xml;


        }
    }
}
