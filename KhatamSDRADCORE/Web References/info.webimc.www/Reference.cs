﻿//------------------------------------------------------------------------------
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

namespace KhatamSDRADCORE.info.webimc.www {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ShoppingBinding", Namespace="urn:IranMC")]
    public partial class ShoppingService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetSendPriceOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterOrderOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetStateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetMultiStatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback TotalOrdersOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ShoppingService() {
            this.Url = global::KhatamSDRADCORE.Properties.Settings.Default.KhatamSDRADCORE_info_webimc_www_ShoppingService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetSendPriceCompletedEventHandler GetSendPriceCompleted;
        
        /// <remarks/>
        public event RegisterOrderCompletedEventHandler RegisterOrderCompleted;
        
        /// <remarks/>
        public event GetStateCompletedEventHandler GetStateCompleted;
        
        /// <remarks/>
        public event GetMultiStatesCompletedEventHandler GetMultiStatesCompleted;
        
        /// <remarks/>
        public event TotalOrdersCompletedEventHandler TotalOrdersCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:IranMC", ResponseNamespace="urn:IranMC")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public string GetSendPrice(string ProductSumPrice, string ProductSumWeight, int OstanId, int ShahrId, int SendType) {
            object[] results = this.Invoke("GetSendPrice", new object[] {
                        ProductSumPrice,
                        ProductSumWeight,
                        OstanId,
                        ShahrId,
                        SendType});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSendPriceAsync(string ProductSumPrice, string ProductSumWeight, int OstanId, int ShahrId, int SendType) {
            this.GetSendPriceAsync(ProductSumPrice, ProductSumWeight, OstanId, ShahrId, SendType, null);
        }
        
        /// <remarks/>
        public void GetSendPriceAsync(string ProductSumPrice, string ProductSumWeight, int OstanId, int ShahrId, int SendType, object userState) {
            if ((this.GetSendPriceOperationCompleted == null)) {
                this.GetSendPriceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSendPriceOperationCompleted);
            }
            this.InvokeAsync("GetSendPrice", new object[] {
                        ProductSumPrice,
                        ProductSumWeight,
                        OstanId,
                        ShahrId,
                        SendType}, this.GetSendPriceOperationCompleted, userState);
        }
        
        private void OnGetSendPriceOperationCompleted(object arg) {
            if ((this.GetSendPriceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSendPriceCompleted(this, new GetSendPriceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:IranMc", ResponseNamespace="urn:IranMc")]
        [return: System.Xml.Serialization.SoapElementAttribute("FactorKey")]
        public string RegisterOrder(string Name, string LastName, string Company, string JobTel, string HomeTel, string Mobile, string Email, string ZipCode, string Address, string Comment, int OstanId, int ShahrId, string Orders, int SendType, int Discount) {
            object[] results = this.Invoke("RegisterOrder", new object[] {
                        Name,
                        LastName,
                        Company,
                        JobTel,
                        HomeTel,
                        Mobile,
                        Email,
                        ZipCode,
                        Address,
                        Comment,
                        OstanId,
                        ShahrId,
                        Orders,
                        SendType,
                        Discount});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterOrderAsync(string Name, string LastName, string Company, string JobTel, string HomeTel, string Mobile, string Email, string ZipCode, string Address, string Comment, int OstanId, int ShahrId, string Orders, int SendType, int Discount) {
            this.RegisterOrderAsync(Name, LastName, Company, JobTel, HomeTel, Mobile, Email, ZipCode, Address, Comment, OstanId, ShahrId, Orders, SendType, Discount, null);
        }
        
        /// <remarks/>
        public void RegisterOrderAsync(
                    string Name, 
                    string LastName, 
                    string Company, 
                    string JobTel, 
                    string HomeTel, 
                    string Mobile, 
                    string Email, 
                    string ZipCode, 
                    string Address, 
                    string Comment, 
                    int OstanId, 
                    int ShahrId, 
                    string Orders, 
                    int SendType, 
                    int Discount, 
                    object userState) {
            if ((this.RegisterOrderOperationCompleted == null)) {
                this.RegisterOrderOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterOrderOperationCompleted);
            }
            this.InvokeAsync("RegisterOrder", new object[] {
                        Name,
                        LastName,
                        Company,
                        JobTel,
                        HomeTel,
                        Mobile,
                        Email,
                        ZipCode,
                        Address,
                        Comment,
                        OstanId,
                        ShahrId,
                        Orders,
                        SendType,
                        Discount}, this.RegisterOrderOperationCompleted, userState);
        }
        
        private void OnRegisterOrderOperationCompleted(object arg) {
            if ((this.RegisterOrderCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterOrderCompleted(this, new RegisterOrderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:IranMC", ResponseNamespace="urn:IranMC")]
        [return: System.Xml.Serialization.SoapElementAttribute("State")]
        public int GetState(string FactorKey) {
            object[] results = this.Invoke("GetState", new object[] {
                        FactorKey});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void GetStateAsync(string FactorKey) {
            this.GetStateAsync(FactorKey, null);
        }
        
        /// <remarks/>
        public void GetStateAsync(string FactorKey, object userState) {
            if ((this.GetStateOperationCompleted == null)) {
                this.GetStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStateOperationCompleted);
            }
            this.InvokeAsync("GetState", new object[] {
                        FactorKey}, this.GetStateOperationCompleted, userState);
        }
        
        private void OnGetStateOperationCompleted(object arg) {
            if ((this.GetStateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStateCompleted(this, new GetStateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:IranMC", ResponseNamespace="urn:IranMC")]
        [return: System.Xml.Serialization.SoapElementAttribute("StateStr")]
        public string GetMultiStates(string FactorKeyStr) {
            object[] results = this.Invoke("GetMultiStates", new object[] {
                        FactorKeyStr});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetMultiStatesAsync(string FactorKeyStr) {
            this.GetMultiStatesAsync(FactorKeyStr, null);
        }
        
        /// <remarks/>
        public void GetMultiStatesAsync(string FactorKeyStr, object userState) {
            if ((this.GetMultiStatesOperationCompleted == null)) {
                this.GetMultiStatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMultiStatesOperationCompleted);
            }
            this.InvokeAsync("GetMultiStates", new object[] {
                        FactorKeyStr}, this.GetMultiStatesOperationCompleted, userState);
        }
        
        private void OnGetMultiStatesOperationCompleted(object arg) {
            if ((this.GetMultiStatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMultiStatesCompleted(this, new GetMultiStatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="urn:IranMC", ResponseNamespace="urn:IranMC")]
        [return: System.Xml.Serialization.SoapElementAttribute("Result")]
        public int TotalOrders(int State) {
            object[] results = this.Invoke("TotalOrders", new object[] {
                        State});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void TotalOrdersAsync(int State) {
            this.TotalOrdersAsync(State, null);
        }
        
        /// <remarks/>
        public void TotalOrdersAsync(int State, object userState) {
            if ((this.TotalOrdersOperationCompleted == null)) {
                this.TotalOrdersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTotalOrdersOperationCompleted);
            }
            this.InvokeAsync("TotalOrders", new object[] {
                        State}, this.TotalOrdersOperationCompleted, userState);
        }
        
        private void OnTotalOrdersOperationCompleted(object arg) {
            if ((this.TotalOrdersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TotalOrdersCompleted(this, new TotalOrdersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetSendPriceCompletedEventHandler(object sender, GetSendPriceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSendPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSendPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void RegisterOrderCompletedEventHandler(object sender, RegisterOrderCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterOrderCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterOrderCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetStateCompletedEventHandler(object sender, GetStateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetStateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetStateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void GetMultiStatesCompletedEventHandler(object sender, GetMultiStatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMultiStatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMultiStatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void TotalOrdersCompletedEventHandler(object sender, TotalOrdersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TotalOrdersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TotalOrdersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591