﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.1.
// 
#pragma warning disable 1591

namespace GSCCCA.RealEstate
{
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "REServiceSoap", Namespace = "http://efile.gsccca.org/")]
    internal partial class OnlineServiceProxy : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        private System.Threading.SendOrPostCallback ValidatePT61StatusOperationCompleted;

        private System.Threading.SendOrPostCallback GetDocumentTypesOperationCompleted;

        private System.Threading.SendOrPostCallback RetrieveRejectedPackageOperationCompleted;

        private System.Threading.SendOrPostCallback RetrieveRecordedPackageOperationCompleted;

        private System.Threading.SendOrPostCallback RejectPackageOperationCompleted;

        private System.Threading.SendOrPostCallback AcceptPackageOperationCompleted;

        private System.Threading.SendOrPostCallback GetStatusOperationCompleted;

        private System.Threading.SendOrPostCallback GetPendingPackagesOperationCompleted;

        private System.Threading.SendOrPostCallback GetPendingPackageOperationCompleted;

        private System.Threading.SendOrPostCallback SubmitOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        internal OnlineServiceProxy()
        {
            this.Url = "http://efile.gsccca.org/eFileWebServices/REService.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        internal new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        internal new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event ValidatePT61StatusCompletedEventHandler ValidatePT61StatusCompleted;

        /// <remarks/>
        internal event GetDocumentTypesCompletedEventHandler GetDocumentTypesCompleted;

        /// <remarks/>
        internal event RetrieveRejectedPackageCompletedEventHandler RetrieveRejectedPackageCompleted;

        /// <remarks/>
        internal event RetrieveRecordedPackageCompletedEventHandler RetrieveRecordedPackageCompleted;

        /// <remarks/>
        internal event RejectPackageCompletedEventHandler RejectPackageCompleted;

        /// <remarks/>
        internal event AcceptPackageCompletedEventHandler AcceptPackageCompleted;

        /// <remarks/>
        internal event GetStatusCompletedEventHandler GetStatusCompleted;

        /// <remarks/>
        internal event GetPendingPackagesCompletedEventHandler GetPendingPackagesCompleted;

        /// <remarks/>
        internal event GetPendingPackageCompletedEventHandler GetPendingPackageCompleted;

        /// <remarks/>
        internal event SubmitCompletedEventHandler SubmitCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/GetDocumentTypes", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDocumentTypes(string userid, string passwd, int countyID)
        {
            object[] results = this.Invoke("GetDocumentTypes", new object[] {
                        userid,
                        passwd,
                        countyID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void GetDocumentTypesAsync(string userid, string passwd, int countyID)
        {
            this.GetDocumentTypesAsync(userid, passwd, countyID, null);
        }

        /// <remarks/>
        internal void GetDocumentTypesAsync(string userid, string passwd, int countyID, object userState)
        {
            if ((this.GetDocumentTypesOperationCompleted == null))
            {
                this.GetDocumentTypesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDocumentTypesOperationCompleted);
            }
            this.InvokeAsync("GetDocumentTypes", new object[] {
                        userid,
                        passwd,
                        countyID}, this.GetDocumentTypesOperationCompleted, userState);
        }

        internal void OnGetDocumentTypesOperationCompleted(object arg)
        {
            if ((this.GetDocumentTypesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDocumentTypesCompleted(this, new GetDocumentTypesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/ValidatePT61Status", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ValidatePT61Status(string pt61Number)
        {
            object[] results = this.Invoke("ValidatePT61Status", new object[] {
                        pt61Number});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void ValidatePT61StatusAsync(string pt61Number)
        {
            this.ValidatePT61StatusAsync(pt61Number, null);
        }

        /// <remarks/>
        public void ValidatePT61StatusAsync(string pt61Number, object userState)
        {
            if ((this.ValidatePT61StatusOperationCompleted == null))
            {
                this.ValidatePT61StatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidatePT61StatusOperationCompleted);
            }
            this.InvokeAsync("ValidatePT61Status", new object[] {
                        pt61Number}, this.ValidatePT61StatusOperationCompleted, userState);
        }

        private void OnValidatePT61StatusOperationCompleted(object arg)
        {
            if ((this.ValidatePT61StatusCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidatePT61StatusCompleted(this, new ValidatePT61StatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/RetrieveRejectedPackage", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RetrieveRejectedPackage(string userid, string password, string packageGUID)
        {
            object[] results = this.Invoke("RetrieveRejectedPackage", new object[] {
                        userid,
                        password,
                        packageGUID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void RetrieveRejectedPackageAsync(string userid, string password, string packageGUID)
        {
            this.RetrieveRejectedPackageAsync(userid, password, packageGUID, null);
        }

        /// <remarks/>
        internal void RetrieveRejectedPackageAsync(string userid, string password, string packageGUID, object userState)
        {
            if ((this.RetrieveRejectedPackageOperationCompleted == null))
            {
                this.RetrieveRejectedPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetrieveRejectedPackageOperationCompleted);
            }
            this.InvokeAsync("RetrieveRejectedPackage", new object[] {
                        userid,
                        password,
                        packageGUID}, this.RetrieveRejectedPackageOperationCompleted, userState);
        }

        internal void OnRetrieveRejectedPackageOperationCompleted(object arg)
        {
            if ((this.RetrieveRejectedPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetrieveRejectedPackageCompleted(this, new RetrieveRejectedPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/RetrieveRecordedPackage", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RetrieveRecordedPackage(string userid, string password, string packageGUID)
        {
            object[] results = this.Invoke("RetrieveRecordedPackage", new object[] {
                        userid,
                        password,
                        packageGUID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void RetrieveRecordedPackageAsync(string userid, string password, string packageGUID)
        {
            this.RetrieveRecordedPackageAsync(userid, password, packageGUID, null);
        }

        /// <remarks/>
        internal void RetrieveRecordedPackageAsync(string userid, string password, string packageGUID, object userState)
        {
            if ((this.RetrieveRecordedPackageOperationCompleted == null))
            {
                this.RetrieveRecordedPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetrieveRecordedPackageOperationCompleted);
            }
            this.InvokeAsync("RetrieveRecordedPackage", new object[] {
                        userid,
                        password,
                        packageGUID}, this.RetrieveRecordedPackageOperationCompleted, userState);
        }

        internal void OnRetrieveRecordedPackageOperationCompleted(object arg)
        {
            if ((this.RetrieveRecordedPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetrieveRecordedPackageCompleted(this, new RetrieveRecordedPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/RejectPackage", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string RejectPackage(string userID, string passwd, string filingGUID, string[] rejectionReasons)
        {
            object[] results = this.Invoke("RejectPackage", new object[] {
                        userID,
                        passwd,
                        filingGUID,
                        rejectionReasons});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void RejectPackageAsync(string userID, string passwd, string filingGUID, string[] rejectionReasons)
        {
            this.RejectPackageAsync(userID, passwd, filingGUID, rejectionReasons, null);
        }

        /// <remarks/>
        internal void RejectPackageAsync(string userID, string passwd, string filingGUID, string[] rejectionReasons, object userState)
        {
            if ((this.RejectPackageOperationCompleted == null))
            {
                this.RejectPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRejectPackageOperationCompleted);
            }
            this.InvokeAsync("RejectPackage", new object[] {
                        userID,
                        passwd,
                        filingGUID,
                        rejectionReasons}, this.RejectPackageOperationCompleted, userState);
        }

        internal void OnRejectPackageOperationCompleted(object arg)
        {
            if ((this.RejectPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RejectPackageCompleted(this, new RejectPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/AcceptPackage", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AcceptPackage(string userID, string passwd, string xml)
        {
            object[] results = this.Invoke("AcceptPackage", new object[] {
                        userID,
                        passwd,
                        xml});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void AcceptPackageAsync(string userID, string passwd, string xml)
        {
            this.AcceptPackageAsync(userID, passwd, xml, null);
        }

        /// <remarks/>
        internal void AcceptPackageAsync(string userID, string passwd, string xml, object userState)
        {
            if ((this.AcceptPackageOperationCompleted == null))
            {
                this.AcceptPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAcceptPackageOperationCompleted);
            }
            this.InvokeAsync("AcceptPackage", new object[] {
                        userID,
                        passwd,
                        xml}, this.AcceptPackageOperationCompleted, userState);
        }

        internal void OnAcceptPackageOperationCompleted(object arg)
        {
            if ((this.AcceptPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AcceptPackageCompleted(this, new AcceptPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/GetStatus", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetStatus(string userID, string passwd, string filingGUID)
        {
            object[] results = this.Invoke("GetStatus", new object[] {
                        userID,
                        passwd,
                        filingGUID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void GetStatusAsync(string userID, string passwd, string filingGUID)
        {
            this.GetStatusAsync(userID, passwd, filingGUID, null);
        }

        /// <remarks/>
        internal void GetStatusAsync(string userID, string passwd, string filingGUID, object userState)
        {
            if ((this.GetStatusOperationCompleted == null))
            {
                this.GetStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStatusOperationCompleted);
            }
            this.InvokeAsync("GetStatus", new object[] {
                        userID,
                        passwd,
                        filingGUID}, this.GetStatusOperationCompleted, userState);
        }

        internal void OnGetStatusOperationCompleted(object arg)
        {
            if ((this.GetStatusCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStatusCompleted(this, new GetStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/GetPendingPackages", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPendingPackages(string userID, string passwd)
        {
            object[] results = this.Invoke("GetPendingPackages", new object[] {
                        userID,
                        passwd});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void GetPendingPackagesAsync(string userID, string passwd)
        {
            this.GetPendingPackagesAsync(userID, passwd, null);
        }

        /// <remarks/>
        internal void GetPendingPackagesAsync(string userID, string passwd, object userState)
        {
            if ((this.GetPendingPackagesOperationCompleted == null))
            {
                this.GetPendingPackagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPendingPackagesOperationCompleted);
            }
            this.InvokeAsync("GetPendingPackages", new object[] {
                        userID,
                        passwd}, this.GetPendingPackagesOperationCompleted, userState);
        }

        private void OnGetPendingPackagesOperationCompleted(object arg)
        {
            if ((this.GetPendingPackagesCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPendingPackagesCompleted(this, new GetPendingPackagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/GetPendingPackage", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetPendingPackage(string userID, string passwd, string packageGUID)
        {
            object[] results = this.Invoke("GetPendingPackage", new object[] {
                        userID,
                        passwd,
                        packageGUID});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void GetPendingPackageAsync(string userID, string passwd, string packageGUID)
        {
            this.GetPendingPackageAsync(userID, passwd, packageGUID, null);
        }

        /// <remarks/>
        internal void GetPendingPackageAsync(string userID, string passwd, string packageGUID, object userState)
        {
            if ((this.GetPendingPackageOperationCompleted == null))
            {
                this.GetPendingPackageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetPendingPackageOperationCompleted);
            }
            this.InvokeAsync("GetPendingPackage", new object[] {
                        userID,
                        passwd,
                        packageGUID}, this.GetPendingPackageOperationCompleted, userState);
        }

        private void OnGetPendingPackageOperationCompleted(object arg)
        {
            if ((this.GetPendingPackageCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetPendingPackageCompleted(this, new GetPendingPackageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://efile.gsccca.org/Submit", RequestNamespace = "http://efile.gsccca.org/", ResponseNamespace = "http://efile.gsccca.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Submit(string userID, string passwd, string xml)
        {
            object[] results = this.Invoke("Submit", new object[] {
                        userID,
                        passwd,
                        xml});
            return ((string)(results[0]));
        }

        /// <remarks/>
        internal void SubmitAsync(string userID, string passwd, string xml)
        {
            this.SubmitAsync(userID, passwd, xml, null);
        }

        /// <remarks/>
        internal void SubmitAsync(string userID, string passwd, string xml, object userState)
        {
            if ((this.SubmitOperationCompleted == null))
            {
                this.SubmitOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubmitOperationCompleted);
            }
            this.InvokeAsync("Submit", new object[] {
                        userID,
                        passwd,
                        xml}, this.SubmitOperationCompleted, userState);
        }

        private void OnSubmitOperationCompleted(object arg)
        {
            if ((this.SubmitCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SubmitCompleted(this, new SubmitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        internal new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void ValidatePT61StatusCompletedEventHandler(object sender, ValidatePT61StatusCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidatePT61StatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ValidatePT61StatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void GetDocumentTypesCompletedEventHandler(object sender, GetDocumentTypesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class GetDocumentTypesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDocumentTypesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void RetrieveRejectedPackageCompletedEventHandler(object sender, RetrieveRejectedPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class RetrieveRejectedPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RetrieveRejectedPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void RetrieveRecordedPackageCompletedEventHandler(object sender, RetrieveRecordedPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class RetrieveRecordedPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RetrieveRecordedPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void RejectPackageCompletedEventHandler(object sender, RejectPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class RejectPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RejectPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void AcceptPackageCompletedEventHandler(object sender, AcceptPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class AcceptPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal AcceptPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void GetStatusCompletedEventHandler(object sender, GetStatusCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class GetStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void GetPendingPackagesCompletedEventHandler(object sender, GetPendingPackagesCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class GetPendingPackagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPendingPackagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void GetPendingPackageCompletedEventHandler(object sender, GetPendingPackageCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class GetPendingPackageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetPendingPackageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    internal delegate void SubmitCompletedEventHandler(object sender, SubmitCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class SubmitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal SubmitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        internal string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591