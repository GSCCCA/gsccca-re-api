using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


// ADD A USING DIRECTIVE FOR CONVENIENCE IN ACCESSING THE GSCCCA.RealEstate NAMESPACE
using GSCCCA.RealEstate;


namespace GSCCCA_API_DEMO
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Many of the demostrated actions will create or retrieve a package.  To maximize code reuse we keep a pacakge object at the 
        /// form scope for convenicence
        /// </summary>
        private Package mainPackage = null;
        

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Convenience method for creating a FilingHandler object using the account values on the form
        /// </summary>
        /// <returns> A configured FilingHandler</returns>
        private FilingHandler getConfiguedFilingHandler()
        {
            // Create the filingHandler using a convenience constructor.  
            // USERNAME, PASSWORD, and URL **MUST** be set
            FilingHandler fileManager = new FilingHandler(this.txtUser.Text, this.txtPassword.Text, this.txtURL.Text);

            // On slow networks, it may be a good idea to increase the service request timeout.  Packages
            // have at least 1 image but could have several.
            if (!string.IsNullOrEmpty(this.txtTimeout.Text))
            {
                int timeout = 30;
                Int32.TryParse(this.txtTimeout.Text, out timeout);
                fileManager.TimeoutInSeconds = timeout;
            }

            return fileManager;
            
        }

        /// <summary>
        /// Uses the API to retrieve a list of pending packages from the server and loads the list
        /// into the ListBox specified
        /// </summary>
        /// <param name="l">A listBox that will contain the list of pending packages</param>
        private void LoadPendingPackages(ListBox l)
        {
            // Get a Configured filinghandler using the form values
            FilingHandler filingManager = this.getConfiguedFilingHandler();


            try
            {
                //Request a list of pending packages.  This can return null if there was an issue.
                List<string> packageGUIDS = filingManager.GetPendingPackages();

                //the list returned is a list of the ids of all the pending packages.  The ids are just guids,
                //and will be used for all subsequent actions on a filing.

                //check to see if any guids were returned.  If the object is null, there was a business rule
                //error.  A non-null object with a count of zero in its collection simply means there are no
                //pending filings.
                if (packageGUIDS != null)
                {

                    //Lets load the listbox with the filing guids.
                    l.Items.Clear();
                    foreach (string guid in packageGUIDS)
                    {
                        l.Items.Add(guid);
                    }
                    showSuccess();
                }

                else
                {
                    // Part of the response is a status
                    // element, which can contain additional information if there were errors.  We don't anticipate errors here,
                    // but if one occurred (or the list returned null and we KNOW there are pending packages) it might be meaningful
                    // to check the status.  Try not setting the username for an example.
                    string status = filingManager.Status;
                    MessageBox.Show(status);
                    Console.WriteLine(status);

                    // ADDITIONAL INFO----
                    // If you can manipulate pria responses directly, you can simply invoke the raw webservice using the API
                    // as a proxy.  This gives you the response as a well formed pria response xml document.
                    string priaResponse = filingManager.PRIAGetPendingPackages();
                    Console.WriteLine(priaResponse);

                }

                // ADDITIONAL INFO----  
                // The request to the server did not require actual pria xml but if it did and we wanted to get at the
                // raw XML we would do something like:
                string theRawRequest = filingManager.RawXMLReqest;
                Console.WriteLine(theRawRequest);

                // ADDITIONAL INFO----
                //The response from the server was a well formed pria respone.  To see it:
                string theRawResponse = filingManager.RawXMLResponse;
                Console.WriteLine(theRawResponse);


            }
            catch (Exception ex)
            {
                showError(ex);
            }
        }


        private void btnGetPendingPackages_Click(object sender, EventArgs e)
        {
            LoadPendingPackages(lstGetPendingPackages);
        }


        private void showSuccess()
        {
            MessageBox.Show("The operation completed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void showError(Exception ex)
        {
            MessageBox.Show("Oops - something went wrong.  The error is:\r\n" + ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPendingPackages(lstGetPendingPackage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstGetPendingPackage.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a package ID before retrieiving the pending filing", "Select a package", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            GetPendingPackage((string)lstGetPendingPackage.SelectedItem);
        }


        private void GetPendingPackage(string guid)
        {
            // Get a Configured filinghandler using the form values
            FilingHandler filingManager = this.getConfiguedFilingHandler();


            try
            {
                filingManager.TimeoutInSeconds = Int32.MaxValue;
                //Retrieve the package from the GSCCCA server.
                Package package = filingManager.GetPendingPackage(guid);
                
                //package may be null if there was an issue, so be sure to check
                if (package != null)
                {

                    // the package object contains information about the filing package including the filer, 
                    // filings, etc...  Explore the API documentation to get a full list of data that is contained in a package
                    
                    //Lets save the package on the form so it can be generally used by other demos.
                    this.mainPackage = package;

                    // ADDITIONAL INFO----
                    // To get the filer...
                    FilingParty filer = package.OriginalFiler;
                    Console.WriteLine(filer.Name);

                    // ADDITIONAL INFO----
                    // Every pending package is guaranteed to have at least one filing, but may have more.
                    foreach (Filing f in package.Filings)
                    {
                        foreach (var doc in f.Images)
                        {

                            // ADDITIONAL INFO----
                            // EACH filing has a unique ID associated with it.  THIS IS IMPORTANT.
                            // ACCEPTING / REJECTING is performed on the entire package.  HOWEVER, when accepting a package,
                            // each filing in the package must be accounted for and this is tracked by the Filing.GSCCCAID
                            // property.  Do keep up with the GSCCCAID of the filing.
                            Guid thisFilingID = f.GSCCCAID;


                            // ADDITIONAL INFO----
                            // Packages may include documents that do not need to be recorded.  It is important to pay attention 
                            // to such flags.
                            bool recordDocument = f.Recordable;

                            // ADDITIONAL INFO----
                            // When accepting a package, each filing in the pacakge THAT IS RECORDABLE must contain an endoresement and fee
                            // information.  More on this in the ACCEPTPACAKGE demo...


                            // ADDITIONAL INFO----
                            // Each filing contains at least one, but potentially more document images
                            // The byte data of the image can be found in the Data property.
                            // FOR THE DEMO, lets load the first image into the picture box on the page.
                            try
                            {
                                MemoryStream ms = new MemoryStream(doc.Data);
                                this.picImageDemo.Image = Image.FromStream(ms);
                            }
                            catch (Exception)
                            {

                            }
                        }

                        //NOTE: you can also iterate through the images
                        //foreach (DocumentImage di in f.Images)
                        //{
                        //    //do something....
                        //}

                        //break out of the foreach which was just showing that the filings can be iterated over.
                        //break;

                    }

                }
                else
                {
                    //If we branch here, the returned package was null.  This is an unexpected case.  Always check the status
                    //property of the FilingHandler when this occurs.
                    string whatWentWrong = filingManager.Status;
                    MessageBox.Show(whatWentWrong);

                }


                //// ADDITIONAL INFO----
                //// The request to the server did not require actual pria xml but if it did and we wanted to get at the
                //// raw XML we would do something like:
                //string theRawRequest = filingManager.RawXMLReqest;
                //Console.WriteLine(theRawRequest);

                //// ADDITIONAL INFO----
                ////The response from the server was a well formed pria respone.  To see it:
                //string theRawResponse = filingManager.RawXMLResponse;
                //Console.WriteLine(theRawResponse);


                //// ADDITIONAL INFO----
                //// If you can manipulate pria responses directly, you can simply invoke the raw webservice using the API
                //// as a proxy.  This gives you the response as a well formed pria response xml document.
                //string priaResponse = filingManager.PRIAGetPendingPackage(guid);
                //Console.WriteLine(priaResponse);



                //Tell the user the operation completed.
                showSuccess();



            }
            catch (Exception ex)
            {
                showError(ex);
            }

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPendingPackages(lstRejectPackage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstRejectPackage.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a package ID before retrieiving the pending filing", "Select a package", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            //The following call was demoed previously, but also stores the package on the form.
            GetPendingPackage((string)lstRejectPackage.SelectedItem);
            if (this.mainPackage != null)
            {
                lblPackageID.Text = mainPackage.GSCCCAID.ToString();
                btnReject.Enabled = true;
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            RejectPackage(this.mainPackage, this.txtRejectionReason.Text);   
        }

        private void RejectPackage(Package package, string reason)
        {
            // Get a Configured filinghandler using the form values
            FilingHandler filingManager = this.getConfiguedFilingHandler();


            try
            {
                // Rejected packages must provide reasons.  Insert the reasons into the pacakge
                if (!string.IsNullOrEmpty(reason.Trim()))
                {
                    package.ReasonsForRejection.Add(new RejectionReason(reason));

                    //NOTE - you can add any number of reasons.......
                }



                //Reject the package 
                bool success = filingManager.RejectPackage(package);

                //if RejectPacakge returns true, then the package was successfully rejected.  If not, you might want
                // to check the raw response or status returned.

                if (!success)
                {
                    string err = filingManager.Status;
                    MessageBox.Show(err);

                    //or check the raw response.
                    string response = filingManager.RawXMLResponse;
                    Console.WriteLine(response);
                    
                }
                else
                {
                    showSuccess();
                }
    


            }
            catch (Exception ex)
            {
                showError(ex);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadPendingPackages(this.lstAcceptPackage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstAcceptPackage.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a package ID before retrieiving the pending filing", "Select a package", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            //The following call was demoed previously, but also stores the package on the form.
            GetPendingPackage((string)this.lstAcceptPackage.SelectedItem);
            if (this.mainPackage != null)
            {
                this.lblAcceptPackageID.Text = mainPackage.GSCCCAID.ToString();
                btnAccept.Enabled = true;
            }

        }

        private bool validateAcceptForm()
        {
            ///This validates the form to make sure the requirements are met.
            ///You can comment out any of the lines below to remove a validation test and see
            ///how the web service responds (errors will be in the status property of the filinghandler insance
            
            List<string> validationErrors = new List<string>();

            if (this.txtBook.Text.Trim() == "")
                validationErrors.Add("-Book field must be set\r\n");

            if (this.txtPage.Text.TrimStart() == "")
                validationErrors.Add("-Page field must be set\r\n");

            if (this.lstFees.Items.Count == 0)
                validationErrors.Add("-Recording fees must be set\r\n");

            if (validationErrors.Count > 0)
            {
                validationErrors.Insert(0,"Some of the information required for accepting a package was not provided:\r\n\r\n");
                MessageBox.Show(string.Concat<string>(validationErrors), "Form Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return (validationErrors.Count == 0);
            

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmt.Text.Trim()) && !string.IsNullOrEmpty(txtDesc.Text.Trim()))
            {
                string[] items = new string[2];
                items[0] = this.txtAmt.Text.TrimStart(" $".ToCharArray());
                items[1] = this.txtDesc.Text;

                lstFees.Items.Add(new ListViewItem(items));
            }
            else
            {
                MessageBox.Show("Please enter both a fee amount and a description", "Incomplete Fee Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lstFees.Items.Clear();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validateAcceptForm())
                    return;

                // All calls to AcceptPackage require a full document package to be sent in xml format.
                // The API handles this for you, but it is important to note a few things.
                // 1) Each document delivered in the original filing package MUST be represented in the accept package.
                // 2) It is important to look at the "recordable" property of each filing.  Some documents may not be submitted
                //    for recording.
                // 3) Entire packages are accepted or rejected, not individual filings. 


                // for simplicity, we are going to accept the retrieved pending package "as is", but this is NOT
                // a reasonable way to accept the documents.  In the real world, the document images within the pacakge
                // would be updated to contain the stamped and final versions.

                Package p = this.mainPackage;

                //psuedo code to mock update and process the filings with actual images.
                foreach (Filing f in p.Filings)
                {
                    foreach (DocumentImage di in f.Images)
                    {
                        // blah blah ..  
                    }
                }

                //The previous lines of code did absolutely nothing but the point was to illustrate that some 
                // manipulation could be done to the received pending filing. You could have started from scratch
                // and built the objects yourself.

                //we are going to step through the filing collection again and apply the endorsement to each
                //recordable document.  Again, this is not suitable for the real world because each document will have its
                //own endorsement and fee, but it serves the purposed for this very simple demo.

                foreach (Filing f in p.Filings)
                {
                    if (f.Recordable)
                    {
                        //Assign the endorsement info
                        f.Endorsement.Book = this.txtBook.Text;
                        f.Endorsement.Page = this.txtPage.Text;

                        //This representes the ACTUAL  (stamped) filing date
                        f.Endorsement.FileDate = DateTime.Now;

                        //Docket type
                        f.Endorsement.DocketType = (DOCKET_TYPES)Enum.Parse(typeof(DOCKET_TYPES), this.txtDocket.Text, true);

                        //If this was something other than a book/page filing, the instrument number
                        // would have to be set:
                        //f.Endorsement.InstrumentNumber = "000000232";

                        //set the fees.
                        foreach (ListViewItem l in this.lstFees.Items)
                        {
                            //no error checking here, but there should be.  
                            FilingFee newFee = new FilingFee(Convert.ToDouble(l.SubItems[0].Text), l.SubItems[1].Text);
                            f.Fees.Add(newFee);
                        }

                    }
                }

                //So we have endorsed all of our documents, time to submit the package.
                // Get a Configured filinghandler using the form values
                FilingHandler filingManager = this.getConfiguedFilingHandler();

                filingManager.TimeoutInSeconds = Int32.MaxValue;
                bool acceptedOnServer = filingManager.AcceptPackage(p);
                if (!acceptedOnServer)
                {
                    //something happened such as a business rule violation.
                    string err = filingManager.Status;
                    MessageBox.Show(err);

                    //or check the raw response.
                    string response = filingManager.RawXMLResponse;
                    Console.WriteLine(response);
                }
                else
                {
                    showSuccess();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Filing f = new Filing();
            f.Endorsement.DocketType = DOCKET_TYPES.DEED;
        }


        private void loadSamples()
        {
            string[] parts = new string[2];
            

            //add a single page satisfaction
            parts[0] = "satisfaction1.xml";
            parts[1] = "Single Page Satisfaction Document";
            lstSubmit.Items.Add(new ListViewItem(parts));

            //Add a three page satisfaction.  I don't know if these even exist, but it is intended to allow for multiple images.
            parts[0] = "satisfaction2.xml";
            parts[1] = "Multi-page Satisfaction Document";
            lstSubmit.Items.Add(new ListViewItem(parts));

            //Add a single page satisfaction with some non-recordable document.
            parts[0] = "satisfaction3.xml";
            parts[1] = "Satisfaction with an additional, non-recordable document";
            lstSubmit.Items.Add(new ListViewItem(parts));

            //Add a single page satisfaction with some non-recordable document.
            parts[0] = "satisfaction4.xml";
            lstSubmit.Items.Add(new ListViewItem(parts));

            //Add a generic test line
            parts[0] = "Troubleshooting.xml";
            parts[1] = "Internal test.";
            lstSubmit.Items.Add(new ListViewItem(parts));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSamples();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ///The following code is only used for submitting samples to the server so that there is work
            ///to process and experiment with.  THe code is not pretty.
            if (lstSubmit.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a filing to submit", "Submit Filing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (this.txtFIPS.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the FIPS code for the county in which you want to file", "Submit Filing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string theFiling = File.ReadAllText(lstSubmit.SelectedItems[0].SubItems[0].Text).Replace("FIPS_CODE", this.txtFIPS.Text);
            FilingHandler filingManager = getConfiguedFilingHandler();

            int numPackages = 1;
            int.TryParse(txtTotalPackages.Text, out numPackages);
            string warningtext = string.Format("About to process {0} packages. Proceed?", numPackages);
            string warningcap = "Continue?";

            var result = MessageBox.Show(warningtext, warningcap, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Process halted.");
                return;
            }

            bool success = true;
            for (int i = 0; i < numPackages; i++)
            {
                string returnXML = filingManager.PRIATestSubmit(theFiling);
                if (returnXML.ToUpper().Contains("ERROR"))
                {
                    MessageBox.Show("An Error occurred: \r\n\r\n:" + returnXML);
                    success = false;
                    break;
                }
            }

            if (success)
                showSuccess();

        }

        private void btnValidatePT61Status_Click(object sender, EventArgs e)
        {
            try
            {
                PT61 pt61 = new PT61(this.txtUser.Text, this.txtPassword.Text, this.txtURL.Text);
                var response = pt61.ValidatePT61Status(this.txtPT61Number.Text);

                this.txtPT61Results.Text = String.Format("Results for PT-61 {0}", this.txtPT61Number.Text);
                this.txtPT61Results.AppendText(Environment.NewLine);
                this.txtPT61Results.AppendText("Call Status     : " + response.CallStatus);
                this.txtPT61Results.AppendText(Environment.NewLine);
                this.txtPT61Results.AppendText("Valid              : " + response.Valid);
                this.txtPT61Results.AppendText(Environment.NewLine);
                var pt61numb = !String.IsNullOrEmpty(response.NewPT61Number) ? response.NewPT61Number : "None";
                this.txtPT61Results.AppendText("New PT-61 # : " + pt61numb);
                this.txtPT61Results.AppendText(Environment.NewLine);
                this.txtPT61Results.AppendText("Raw XML     : " + response.RawXML);
                this.txtPT61Results.AppendText(Environment.NewLine);

            }
            catch(Exception ex)
            {
                this.txtPT61Results.Text = ex.Message;
            }

        }
    }
}
