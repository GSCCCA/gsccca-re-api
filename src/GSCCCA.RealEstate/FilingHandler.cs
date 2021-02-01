using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRIALibraryV24;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GSCCCA.RealEstate
{
    /// <summary>
    /// A convenience class for performing several Real Estate eFiling actions against the GSCCCA eFiling engine without the need
    /// to fully understand and implement the PRIA standard
    /// </summary>
    public class FilingHandler
    {
        private OnlineServiceProxy proxy = null;
        private string webServiceURL = String.Empty;
        private int requestTimeout = 6000;
        private string userid = string.Empty;
        private string password = string.Empty;
        private string status = string.Empty;
        private string rawrequest = string.Empty;
        private string rawresponse = string.Empty;

        /// <summary>
        /// Creates an uninitialized FilingHandler
        /// <note type="caution">
        /// Before the FilingHandler can be used, the UserID, Password, and ServiceURL must be set 
        /// </note>
        /// </summary>
        public FilingHandler() { }

        /// <summary>
        /// Creates a FilingHandler using the userID and password provided
        ///  <note type="caution">
        ///     Before the FilingHandler can be used, the ServiceURL must also be set 
        /// </note>
        /// </summary>
        /// <param name="userid">The userID of the eFiling user</param>
        /// <param name="password">The password of the eFiling user</param>
        public FilingHandler(string userid, string password)
        {
            this.userid = userid;
            this.password = password;
        }

        /// <summary>
        /// Creates a FilingHandler using the userID, password, and service url provided
        /// </summary>
        /// <param name="userid">The userID of the eFiling user</param>
        /// <param name="password">The password of the eFiling user</param>
        /// <param name="url">The url of the GSCCCA Real Estate eFiling web service</param>
        public FilingHandler(string userid, string password, string url)
        {
            this.userid = userid;
            this.password = password;
            this.webServiceURL = url;
        }

        /// <summary>
        /// Creates a fully configured gsccca web service proxy based on the FilingHandler attributes
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
        /// Creates a strongly typed PRIA_RESPONSE_GROUP object from the xml provided
        /// </summary>
        /// <param name="xml">XML string representing a pria response</param>
        /// <returns>A strongly typed PRIA_RESPONSE_GROUP object if the xml was parsable, null otherwise</returns>
        private PRIA_RESPONSE_GROUP_Type createPriaResponse(string xml)
        {
            PRIA_RESPONSE_GROUP_Type priaResponse = null;
            try
            {
                StringReader sr;
                XmlReader reader;
                XmlSerializer xs;
                XmlReaderSettings settings;

                sr = new StringReader(xml);
                settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                reader = XmlReader.Create(sr, settings);
                xs = new XmlSerializer(typeof(PRIA_RESPONSE_GROUP_Type));
                priaResponse = (PRIA_RESPONSE_GROUP_Type)xs.Deserialize(reader);
            }
            catch { }
            return priaResponse;
        }

        /// <summary>
        /// Given an xml pria response, checks the status string of the response and compares it to a user provided desired response.  The status text of the
        /// status document can be found in the Status property of this object after this method is called.
        /// </summary>
        /// <param name="xml">The xml of a pria response document</param>
        /// <param name="desiredResponse">The status description used to compare against the status actually contained with the status document</param>
        /// <returns>True if the response matches the user specified desired response, false otherwise</returns>
        private bool processResponse(string xml, string desiredResponse)
        {
            bool okResponse = false;
            
            PRIA_RESPONSE_GROUP_Type response = createPriaResponse(xml);
            if (response == null)
            {
                status = "Error parsing response from GSCCCA. Please review the XML returned from GSCCCA.";
            }
            else
            {
                string description = "";
                if (response.RESPONSE != null && response.RESPONSE.Count > 0
                    && response.RESPONSE[0] != null  && response.RESPONSE[0].STATUS != null
                    && response.RESPONSE[0].STATUS.Count > 0 && response.RESPONSE[0].STATUS[0] != null)
                {
                    description = response.RESPONSE[0].STATUS[0]._Description.Trim().ToUpper();
                    status = description;
                    if (description == desiredResponse.Trim().ToUpper())
                    {
                        okResponse = true;
                    }
                }

            }
            return okResponse;
        }

        /// <summary>
        /// Convenience method to initialize the values of the raw request, raw response, and status Properties.
        /// </summary>
        private void clearStatus()
        {
            this.status = "";
            this.rawrequest = "";
            this.rawresponse = "";
        }

        /// <summary>
        /// Rejects a Real Estate Package in the GSCCCA eFiling System
        /// </summary>
        /// <param name="package">A package to be rejected which contains the GSCCCAID of the package as well as a list of rejection reasons</param>
        /// <returns>True if the package was successfully rejected.  If false, the package was NOT marked rejected in the GSCCCA system.  Check the
        /// Status Property of the FilingHandler for more information, as well as the RawXMLResponse Property</returns>
        public bool RejectPackage(Package package)
        {
            //reset variables
            clearStatus();
            this.rawrequest = "<rejectPackage>" + package.GSCCCAID.ToString() + " </rejectPackage>";

            List<string> reasons = new List<string>();
            foreach (RejectionReason reason in package.ReasonsForRejection)
            {
                reasons.Add(reason.Reason);
            }

            //Send the request and receive a response.
            string responseXML = PRIARejectPackage(package.GSCCCAID.ToString(), reasons);
            this.rawresponse = responseXML;

            //Analyze the response
            return processResponse(responseXML, "REJECTED");
        }


        /// <summary>
        /// Creates a List of strings representing GSCCCAIDs of all pending packages on the GSCCCA real estate eFiling portal
        /// </summary>
        /// <param name="xml">The xml of the pria response containing the document list</param>
        /// <returns>A List of strings of GSCCCAIDs of all pending packages</returns>
        private List<string> createPackageList(string xml)
        {
            List<string> filings = null;
            bool responseExpected = processResponse(xml, "RECEIVED");
            if (responseExpected)
            {
                filings = new List<string>();
                PRIA_RESPONSE_GROUP_Type response = createPriaResponse(xml);
                if (response.RESPONSE[0].RESPONSE_DATA != null && response.RESPONSE[0].RESPONSE_DATA.Count > 0)
                {
                    foreach (PRIA_RESPONSE_Type priaResponse in response.RESPONSE[0].RESPONSE_DATA)
                    {
                        if (priaResponse.PACKAGE != null)
                            filings.Add(priaResponse.PACKAGE._Identifier);
                    }
                }

            }
            return filings;
        }

        /// <summary>
        /// Retrieves a pending Real estate package from the GSCCCA eFiling system.
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the package being requested.</param>
        /// <returns>A Package object that contains infromation about the pending filings including document images.  If the package
        /// could not be retrieved or does not exist, a NULL Package Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetPendingPackage(string gscccaID)
        {
            Guid g = Guid.Parse(gscccaID);
            return GetPendingPackage(g);
        }

        /// <summary>
        /// Retrieves a pending Real estate package from the GSCCCA eFiling system.
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the package being requested.</param>
        /// <returns>A Package object that contains infromation about the pending filings including document images.  If the package
        /// could not be retrieved or does not exist, a NULL Package Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetPendingPackage(Guid gscccaID)
        {
            //reset variables
            clearStatus();
            this.rawrequest = "<getPendingPackage>" + gscccaID.ToString() + "</getPendingPackage>";

            //make the request and record the reponse
            string xml = PRIAGetPendingPackage(gscccaID.ToString());
            this.rawresponse = xml;

            //process the response.
            Package p = null;
            bool responseOK = processResponse(xml, "RECEIVED");
            if (responseOK)
            {
                PRIA_RESPONSE_GROUP_Type response = createPriaResponse(xml);
                if (response.RESPONSE[0].RESPONSE_DATA != null &&
                    response.RESPONSE[0].RESPONSE_DATA.Count > 0 &&
                    response.RESPONSE[0].RESPONSE_DATA[0] != null &&
                    response.RESPONSE[0].RESPONSE_DATA[0].PACKAGE != null)
                {
                    p = Package.FromPriaPackage(response.RESPONSE[0].RESPONSE_DATA[0].PACKAGE);
                    if (p == null)
                    {
                        this.status = "Error in response package.  Please check the xml that was returned";
                    }
                    else
                    {
                        //set the filer informatoin
                        if (response.RESPOND_TO_PARTY != null)
                        {
                            FilingParty filer = FilingParty.FromPriaRespondToParty(response.RESPOND_TO_PARTY);
                            p.OriginalFiler = filer;
                        }
                    }
                }
                else
                {
                    this.status = "Error in response package.  Please check the xml that was returned";
                }

            }

            return p ;

        }

        /// <summary>
        /// Retrieve a previously rejected package from the GSCCCA Real Estate eFiling systme
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the rejected package being requested</param>
        /// <returns>A Package object that contains information about the rejected package.  THe package object will NOT contain
        /// filings, rather only the reasons provided for rejected.  If the package
        /// could not be retrieved, does not exist, or is not rejected, a NULL package Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetRejectedPackage(string gscccaID)
        {
            Guid g = Guid.Parse(gscccaID);
            return GetRejectedPackage(g);
        }

        /// <summary>
        /// Retrieve a previously rejected package from the GSCCCA Real Estate eFiling systme
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the rejected package being requested</param>
        /// <returns>A Package object that contains information about the rejected package.  THe package object will NOT contain
        /// filings, rather only the reasons provided for rejected.  If the package
        /// could not be retrieved, does not exist, or is not rejected, a NULL package Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetRejectedPackage(Guid gscccaID)
        {
            //reset variables
            clearStatus();
            this.rawrequest = "<getRejectedPackage>" + gscccaID.ToString() + "</getRejectedPackage>";

            //make the request and record the reponse
            string xml = PRIARetrieveRejectedPackage(gscccaID.ToString());
            this.rawresponse = xml;

            //process the response.
            Package p = null;
            
            bool responseOK = processResponse(xml, "REJECTED");
            if (responseOK)
            {
                p = new Package();
                p.GSCCCAID = gscccaID;

                PRIA_RESPONSE_GROUP_Type response = createPriaResponse(xml);
                if (response.RESPONSE[0].STATUS[0].RECORDING_ERROR!=null) {
                    foreach (PRIA_RECORDING_ERROR_Type err in response.RESPONSE[0].STATUS[0].RECORDING_ERROR) 
                    {
                        RejectionReason r = new RejectionReason(err._Description);
                        p.ReasonsForRejection.Add(r);
                    }
                }

            }

            return p;
        }

        /// <summary>
        /// Retrieve a previously accepted Package from the GSCCCA Real Estate eFiling system
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the Accepted package being requested</param>
        /// <returns>A Package object that contains infromation about the Accepted package including filings
        /// and recording informations.  If the Package
        /// could not be retrieved, does not exist, or is not Accepted, a NULL package  Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetAcceptedPackage(string gscccaID)
        {
            Guid g = Guid.Parse(gscccaID);
            return GetAcceptedPackage(g);
        }
        /// <summary>
        /// Retrieve a previously accepted Package from the GSCCCA Real Estate eFiling system
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the Accepted package being requested</param>
        /// <returns>A Package object that contains infromation about the Accepted package including filings
        /// and recording informations.  If the Package
        /// could not be retrieved, does not exist, or is not Accepted, a NULL package  Object is returned.  Check the Status property of the FilingHandler
        /// and the RawXMLResponse Property for more information</returns>
        public Package GetAcceptedPackage(Guid gscccaID)
        {
            //reset variables
            clearStatus();
            this.rawrequest = "<getAcceptedPackage>" + gscccaID.ToString() + "</getAcceptedPackage>";

            //make the request and record the reponse
            string xml = PRIARetrieveRecordedPackage(gscccaID.ToString());
            this.rawresponse = xml;

            //process the response.
            Package p = null;
            bool responseOK = processResponse(xml, "RECORDED");
            if (responseOK)
            {
                PRIA_RESPONSE_GROUP_Type response = createPriaResponse(xml);
                if (response.RESPONSE[0].RESPONSE_DATA != null &&
                    response.RESPONSE[0].RESPONSE_DATA.Count > 0 &&
                    response.RESPONSE[0].RESPONSE_DATA[0] != null &&
                    response.RESPONSE[0].RESPONSE_DATA[0].PACKAGE != null)
                {
                    p = Package.FromPriaPackage(response.RESPONSE[0].RESPONSE_DATA[0].PACKAGE);
                }
                else
                {
                    this.status = "Error in response package.  Please check the xml that was returned";
                }

            }

            return p;
        }

        /// <summary>
        /// Returns a list of strings containing GSCCCAIDs of pending packages on the GSCCCA Real estate eFiling system
        /// </summary>
        /// <returns>A list of GSCCCAIDs cooresponding to pending packages</returns>
        public List<string> GetPendingPackages()
        {
            //reset variables
            clearStatus();
            this.rawrequest = "<getPendingFilings/>";

            //make the request and store response
            string xml = this.PRIAGetPendingPackages();
            this.rawresponse = xml;

            return createPackageList(xml);
        }

        /// <summary>
        /// Accepts a package on the GSCCCA Real Estate eFiling System
        /// </summary>
        /// <param name="package">A package object that contains the accepted document images, recording endorsement, and fee information</param>
        /// <returns>Returns true if the package was successfully accepted by the GSCCCA eFiling system.  False if not.  If the package could not be
        /// accepted, check the Status property of the FilingHandler object as well as the RawXMLResponse Property for additional information</returns>
        public bool AcceptPackage(Package package)
        {
            //reset variables
            clearStatus();
            
            //transform the accepted filing into a pria package and request.
            PRIA_REQUEST_GROUP_Type request = createPriaRequest();
            PRIA_PACKAGE_Type priaPackage = package.ToPriaPackage();
            request.REQUEST[0].PRIA_REQUEST[0].PACKAGE.Add(priaPackage);
            
            //Serialize the request and package
            string requestXML = request.ToXmlString();
            this.rawrequest = requestXML;

            //Send the request and receive a response.
            string responseXML = PRIAAcceptPackage(requestXML);
            this.rawresponse = responseXML;

            //Analyze the response
            return processResponse(responseXML, "RECORDED");
        }


        /// <summary>
        /// Creates an initialized PRIA_REQUEST_GROUP object used for making requests against the GSCCCA REal Estate eFiling service
        /// </summary>
        /// <returns>A PRIA_REQUEST_GROUP object</returns>
        private PRIA_REQUEST_GROUP_Type createPriaRequest()
        {
            PRIA_REQUEST_GROUP_Type request = new PRIA_REQUEST_GROUP_Type();
            request.PRIAVersionIdentifier = "2.4.1";
            request.REQUEST = new List<REQUEST_Type>();
            request.REQUEST.Add(new REQUEST_Type());
            request.REQUEST[0].RequestDateTime = DateTime.Now.ToString("M/d/yyyy h:mm tt");
            request.REQUEST[0].PRIA_REQUEST = new List<PRIA_REQUEST_Type>();
            request.REQUEST[0].PRIA_REQUEST.Add(new PRIA_REQUEST_Type());
            request.REQUEST[0].PRIA_REQUEST[0]._SequenceIdentifier = "1";
            request.REQUEST[0].PRIA_REQUEST[0]._Type = PRIA_PRIARequestType_Enumerated.RecordDocuments;
            request.REQUEST[0].PRIA_REQUEST[0].PACKAGE = new List<PRIA_PACKAGE_Type>();
            return request;
        }


        ///////////////////////////PRIA SPECIFIC METHODS FOLLOW  ////////////////////////

        /// <summary>
        /// Submits a test filing.  ONLY TO BE USED FOR TESTING AS PART OF THIS API
        /// </summary>
        /// <param name="priaXML">The PRIA 2.4.1 Request xml document containing the filing to be submitted </param>
        /// <returns>A PRIA Response xml document containing the status of the Request submitted</returns>
        public string PRIATestSubmit(string priaXML)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.Submit(this.userid, this.password, priaXML);
        }


        /// <summary>
        /// Accepts a filing on the GSCCCA eFiling system using strictly PRIA xml documents
        /// </summary>
        /// <param name="priaXML">The PRIA 2.4.1 Request xml document containing the filing to be marked accepted </param>
        /// <returns>A PRIA Response xml document containing the status of the Request submitted</returns>
        public string PRIAAcceptPackage(string priaXML)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.AcceptPackage(this.userid, this.password, priaXML);   
        }

        /// <summary>
        /// Rejects a filing on the GSCCCA eFiling system wiht the status provided in a PRIA Response xml document
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the document which is to be marked rejected</param>
        /// <param name="rejectionReasons">A list of reasons why the filing could not be recorded</param>
        /// <returns>A PRIA Response xml document containing the status of the rejection request</returns>
        public string PRIARejectPackage(string gscccaID, List<string> rejectionReasons)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.RejectPackage(this.userid, this.password, gscccaID, rejectionReasons.ToArray());
        }

        /// <summary>
        /// Retrieves a previously accepted filing from the GSCCCA eFiling system with status provided in a PRIA Response xml document
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the accepted filing that is to be returned</param>
        /// <returns>A PRIA REsponse xml document containing the status of the request and a Pria PACKAGE, if the accepted filing was found</returns>
        public string PRIARetrieveRecordedPackage(string gscccaID)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.RetrieveRecordedPackage(this.userid, this.password, gscccaID);
        }


        /// <summary>
        /// Retrieves a previously rejected filing from the GSCCCA eFiling system with status provided in a PRIA Response xml document
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the rejected filing that is to be returned</param>
        /// <returns>A PRIA Response xml document containing the status of the request and a list of recording errors, if found.</returns>
        public string PRIARetrieveRejectedPackage(string gscccaID)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.RetrieveRejectedPackage(this.userid, this.password, gscccaID);
        }


        /// <summary>
        /// Retrieves a list of pending filings from the GSCCCA eFiling system provided in a PRIA Response XML document
        /// </summary>
        /// <returns>A PRIA Response xml document containing the status of the request and a list of pending filings, if any</returns>
        public string PRIAGetPendingPackages()
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.GetPendingPackages(this.userid, this.password);
        }

        /// <summary>
        /// Retrieve a pending filing from the GSCCCA eFiling system provided in a PRIA Response xml Document
        /// </summary>
        /// <param name="gscccaID">The GSCCCAID of the pending filing being requested</param>
        /// <returns>A PRIA Response xml document containing the pending filing being requested, if found</returns>
        public string PRIAGetPendingPackage(string gscccaID)
        {
            OnlineServiceProxy proxy = getConfiguredProxy();
            return proxy.GetPendingPackage(this.userid, this.password, gscccaID);
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
        /// Gets/sets the User ID of the eFiling user associated with this FilingHandler
        /// </summary>
        public string UserID
        {
            get { return this.userid; }
            set { this.userid = value; }
        }

        /// <summary>
        /// Gets/sets the Password of the eFiling user associated with this FilingHandler
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        /// <summary>
        /// Gets the raw xml request generated by this FilingHandler when invoking one of the non-PRIA convenience methods
        /// for accessing the GSCCCA eFiling system.  This property provides the actual XML sent to the GSCCCA web service
        /// whenever the specific request requires PRIA compliant XML to be sent.  If no PRIA XML was required, this property will
        /// still contain an xml representation of the request being made, though such XML would not actually be transmitted.
        /// </summary>
        public string RawXMLReqest
        {
            get { return this.rawrequest; }
        }

        /// <summary>
        /// Gets the raw xml response received by this FilingHandler after invoking one of the non-PRIA convenience methods
        /// for accessing the GSCCCA eFiling system.  This property provides the actual XML received from the GSCCCA web service
        /// which is compliant with PRIA specifications.
        /// </summary>
        public string RawXMLResponse
        {
            get { return this.rawresponse; }
        }
    }
}
