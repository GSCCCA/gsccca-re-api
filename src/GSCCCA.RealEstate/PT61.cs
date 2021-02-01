using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// Represents a Real Estate PT-61.  This is the base class for checking the validation status of a PT-61.
    /// </summary>
    public class PT61
    {
        private OnlineServiceProxy proxy = null;
        private string webServiceURL = String.Empty;
        private int requestTimeout = 6000;
        private string userid = string.Empty;
        private string password = string.Empty;
        private string status = string.Empty;

        /// <summary>
        /// Creates an uninitialized PT-61
        /// <note type="caution">
        /// Before the PT61 can be used, the UserID, Password, and ServiceURL must be set 
        /// </note>
        /// </summary>
        public PT61() { }

        /// <summary>
        /// Creates a PT-61 using the userID and password provided
        ///  <note type="caution">
        ///     Before the PT-61 can be used, the ServiceURL must also be set 
        /// </note>
        /// </summary>
        /// <param name="userid">The userID of the eFiling user</param>
        /// <param name="password">The password of the eFiling user</param>
        public PT61(string userid, string password)
        {
            this.userid = userid;
            this.password = password;
        }

        /// <summary>
        /// Creates a PT61 using the userID, password, and service url provided
        /// </summary>
        /// <param name="userid">The userID of the eFiling user</param>
        /// <param name="password">The password of the eFiling user</param>
        /// <param name="url">The url of the GSCCCA Real Estate eFiling web service</param>
        public PT61(string userid, string password, string url)
        {
            this.userid = userid;
            this.password = password;
            this.webServiceURL = url;
        }

        /// <summary>
        /// Creates a fully configured gsccca web service proxy based on the PT-61 attributes
        /// </summary>
        /// <returns>A fully configured OnlineServiceProxy</returns>
        private OnlineServiceProxy getConfiguredProxy()
        {
            this.proxy = new OnlineServiceProxy();
            this.proxy.Url = this.webServiceURL;
            this.proxy.Timeout = this.requestTimeout;
            return proxy;
        }

        /// <summary>
        /// Method that checks the validity of the PT-61
        /// </summary>
        /// <param name="pt61Number">The filing number of the PT-61.</param>
        /// <returns>A PT61ValidationResult object </returns>
        public PT61ValidationResult ValidatePT61Status(string pt61Number)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();

            //get response xml
            var response = proxy.ValidatePT61Status(pt61Number);

            //Serialize
            XmlSerializer serializer = new XmlSerializer(typeof(PT61ValidationResult), new XmlRootAttribute("GSCCCA"));
            StringReader reader = new StringReader(response);
            PT61ValidationResult validationResult = (PT61ValidationResult)serializer.Deserialize(reader);

            //append raw xml to object
            validationResult.RawXML = response;

            return validationResult;
        }

        /// <summary>
        /// Gets the detailed status of the results from the last operation.
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Gets/sets the web service URL for the GSCCCA eFIling system
        /// </summary>
        public string ServiceURL
        {
            get { return this.webServiceURL; }
            set { this.webServiceURL = value; }
        }

        /// <summary>
        /// Gets/sets the Request timeout for actions against the GSCCCA eFiling System
        /// </summary>
        public int TimeoutInSeconds
        {
            get { return this.requestTimeout / 1000; }
            set { this.requestTimeout = value * 1000; }
        }

        /// <summary>
        /// Gets/sets the User ID of the eFiling user associated with this PT61
        /// </summary>
        public string UserID
        {
            get { return this.userid; }
            set { this.userid = value; }
        }

        /// <summary>
        /// Gets/sets the Password of the eFiling user associated with this PT61
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
    }
}
