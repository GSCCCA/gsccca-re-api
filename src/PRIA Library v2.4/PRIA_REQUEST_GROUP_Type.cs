using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.IO;
using System.Linq;

namespace PRIALibraryV24
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("REQUEST_GROUP", Namespace = "", IsNullable = false)]
    public partial class PRIA_REQUEST_GROUP_Type
    {
        //private PRIA_REQUESTING_PARTY_Type[] rEQUESTING_PARTYField;
        //private PRIA_RECEIVING_PARTY_Type[] rECEIVING_PARTYField;
        //private PRIA_SUBMITTING_PARTY_Type[] sUBMITTING_PARTYField;
        //private REQUEST_Type[] rEQUESTField;

        private List<PRIA_REQUESTING_PARTY_Type> rEQUESTING_PARTYField;
        private List<PRIA_RECEIVING_PARTY_Type> rECEIVING_PARTYField;
        private List<PRIA_SUBMITTING_PARTY_Type> sUBMITTING_PARTYField;
        private List<REQUEST_Type> rEQUESTField;

        private MISMO_SIGNATURE_TYPE eLECTRONIC_SIGNATUREField;

        private string pRIAVersionIdentifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("REQUESTING_PARTY")]
        public List<PRIA_REQUESTING_PARTY_Type> REQUESTING_PARTY
        //public PRIA_REQUESTING_PARTY_Type[] REQUESTING_PARTY
        {
            get
            {
                return this.rEQUESTING_PARTYField;
            }
            set
            {
                this.rEQUESTING_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RECEIVING_PARTY")]
        public List<PRIA_RECEIVING_PARTY_Type> RECEIVING_PARTY
        //public PRIA_RECEIVING_PARTY_Type[] RECEIVING_PARTY
        {
            get
            {
                return this.rECEIVING_PARTYField;
            }
            set
            {
                this.rECEIVING_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SUBMITTING_PARTY")]
        public List<PRIA_SUBMITTING_PARTY_Type> SUBMITTING_PARTY
        {
            get
            {
                return this.sUBMITTING_PARTYField;
            }
            set
            {
                this.sUBMITTING_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("REQUEST")]
        public List<REQUEST_Type> REQUEST
        //public REQUEST_Type[] REQUEST
        {
            get
            {
                return this.rEQUESTField;
            }
            set
            {
                this.rEQUESTField = value;
            }
        }

        /// <remarks/>
        public MISMO_SIGNATURE_TYPE ELECTRONIC_SIGNATURE
        {
            get
            {
                return this.eLECTRONIC_SIGNATUREField;
            }
            set
            {
                this.eLECTRONIC_SIGNATUREField = value;
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

        ///WHAT FOLLOWS ARE NON-SYSTEM GENERATED CONVENIENCE METHODS
        ///

        public PRIA_PACKAGE_Type GetFirstPackage() 
        {
            return REQUEST?.FirstOrDefault()
                          ?.PRIA_REQUEST?.FirstOrDefault()
                          ?.PACKAGE?.FirstOrDefault();
        }

        public string ToXmlString()
        {
            //XmlWriter xw;
            //XmlWriterSettings settings;
            XmlSerializer xs;
            //StringBuilder sb;

            MemoryStream s = new MemoryStream();
            try
            {
                //sb = new StringBuilder();
                //settings = new XmlWriterSettings();
                //settings.Encoding = Encoding.UTF8;

                //Stream s = new MemoryStream();
                XmlWriter xw = new XmlTextWriter(s, Encoding.UTF8);

                //xw = XmlWriter.Create(sb, settings);

                xs = new XmlSerializer(typeof(PRIA_REQUEST_GROUP_Type));
                xs.Serialize(xw, this);
            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIA_Request_GROUP_Type.ToXmlString()", se);
            }

            TextReader tr = new StreamReader(s);
            s.Seek(0, SeekOrigin.Begin);
            string xml = tr.ReadToEnd();
            return xml;
        }
    }
}
