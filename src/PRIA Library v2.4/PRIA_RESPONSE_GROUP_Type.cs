using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Text;

namespace PRIALibraryV24
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("RESPONSE_GROUP", Namespace = "", IsNullable = false)]
    public partial class PRIA_RESPONSE_GROUP_Type
    {

        private PRIA_RESPONDING_PARTY_Type rESPONDING_PARTYField;
        private List<PRIA_SUBMITTING_PARTY_Type> sUBMITTING_PARTYField;
        private PRIA_RESPOND_TO_PARTY_Type rESPOND_TO_PARTYField;
        private List<RESPONSE_Type> rESPONSEField;
        private MISMO_SIGNATURE_TYPE eLECTRONIC_SIGNATUREField;

        private string pRIAVersionIdentifierField;

        /// <remarks/>
        public PRIA_RESPONDING_PARTY_Type RESPONDING_PARTY
        {
            get
            {
                return this.rESPONDING_PARTYField;
            }
            set
            {
                this.rESPONDING_PARTYField = value;
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
        public PRIA_RESPOND_TO_PARTY_Type RESPOND_TO_PARTY
        {
            get
            {
                return this.rESPOND_TO_PARTYField;
            }
            set
            {
                this.rESPOND_TO_PARTYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RESPONSE")]
        public List<RESPONSE_Type> RESPONSE
        {
            get
            {
                return this.rESPONSEField;
            }
            set
            {
                this.rESPONSEField = value;
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

        
    }
}
