using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PRIALibraryV24
{
    public partial class PRIA_RESPONSE_GROUP_Type
    {
        public PRIA_RESPONSE_GROUP_Type()
        {
        }

        public string ToXmlString()
        {
            XmlSerializer xs;
            MemoryStream s = new MemoryStream();
            try
            {

                XmlWriter xw = new XmlTextWriter(s, Encoding.UTF8);
                xs = new XmlSerializer(typeof(PRIA_RESPONSE_GROUP_Type));
                xs.Serialize(xw, this);
            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIA_RESPONSE_GROUP_Type.ToXmlString()", se);
            }

            TextReader tr = new StreamReader(s);
            s.Seek(0, SeekOrigin.Begin);
            string xml = tr.ReadToEnd();
            return xml;

        }
    }

    public partial class PRIA_PACKAGE_Type
    {
        public PRIA_PACKAGE_Type()
        {
        }

        public PRIA_PACKAGE_Type(string priaXML)
        {
            StringReader sr;
            XmlReader reader;
            XmlSerializer xs;
            XmlReaderSettings settings;
            PRIA_PACKAGE_Type priaType = null;

            try
            {
                sr = new StringReader(priaXML);
                settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                
                reader = XmlReader.Create(sr, settings);
                xs = new XmlSerializer(typeof(PRIA_PACKAGE_Type));
                priaType = (PRIA_PACKAGE_Type)xs.Deserialize(reader);

                if (priaType._Identifier != null)
                    this._Identifier = priaType._Identifier;

                if (priaType._SequenceIdentifier!=null)
                    this._SequenceIdentifier = priaType._SequenceIdentifier;

                if (priaType.PAYMENT != null)
                    this.PAYMENT = priaType.PAYMENT;

                if (priaType.PRIA_DOCUMENT != null)
                    this.PRIA_DOCUMENT = priaType.PRIA_DOCUMENT;


            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIALibray24:EFilePartialClasses:PRIA_PACKAGE_Type ctor(xml)", se);
            }
        }
    }



    public partial class PRIA_REQUEST_GROUP_Type
    {
        

        public PRIA_REQUEST_GROUP_Type()
        {
        }

        public PRIA_REQUEST_GROUP_Type(string priaXML)
        {
            StringReader sr;
            XmlReader reader;
            XmlSerializer xs;
            XmlReaderSettings settings;
            PRIA_REQUEST_GROUP_Type priaType = null;

            try
            {
                sr = new StringReader(priaXML);
                settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                reader = XmlReader.Create(sr, settings);
                xs = new XmlSerializer(typeof(PRIA_REQUEST_GROUP_Type));
                priaType = (PRIA_REQUEST_GROUP_Type)xs.Deserialize(reader);

                this.PRIAVersionIdentifier = priaType.PRIAVersionIdentifier;

                if (priaType.ELECTRONIC_SIGNATURE != null)
                    this.ELECTRONIC_SIGNATURE = priaType.ELECTRONIC_SIGNATURE;

                if (priaType.RECEIVING_PARTY != null)
                    this.RECEIVING_PARTY = priaType.RECEIVING_PARTY;

                if (priaType.REQUEST != null)
                    this.REQUEST = priaType.REQUEST;

                if (priaType.REQUESTING_PARTY != null)
                    this.REQUESTING_PARTY = priaType.REQUESTING_PARTY;

                if (priaType.SUBMITTING_PARTY != null)
                    this.SUBMITTING_PARTY = priaType.SUBMITTING_PARTY;
            }
            catch (System.Exception se)
            {
                throw new System.Exception("PRIALibray24:EFilePartialClasses:PRIA_REQUEST_GROUP_Type ctor(xml)", se);
            }
        }
    }
}
