﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace IT140P_Final_Project.LoanService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Soap Service TestBinding", Namespace="urn:soaptest")]
    public partial class SoapServiceTest : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback calculate_personal_loan_repaymentOperationCompleted;
        
        private System.Threading.SendOrPostCallback calculate_car_loan_repaymentOperationCompleted;
        
        private System.Threading.SendOrPostCallback calculate_home_loan_repaymentOperationCompleted;
        
        private System.Threading.SendOrPostCallback calculate_education_loan_repaymentOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SoapServiceTest() {
            this.Url = "http://192.168.1.34/FinalProject/TheWebService.php";
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
        public event calculate_personal_loan_repaymentCompletedEventHandler calculate_personal_loan_repaymentCompleted;
        
        /// <remarks/>
        public event calculate_car_loan_repaymentCompletedEventHandler calculate_car_loan_repaymentCompleted;
        
        /// <remarks/>
        public event calculate_home_loan_repaymentCompletedEventHandler calculate_home_loan_repaymentCompleted;
        
        /// <remarks/>
        public event calculate_education_loan_repaymentCompletedEventHandler calculate_education_loan_repaymentCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.34/FinalProject/TheWebService.php/calculate_personal_loan_repaym" +
            "ent", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public float calculate_personal_loan_repayment(float loan_amount, float interest_rate, int loan_term) {
            object[] results = this.Invoke("calculate_personal_loan_repayment", new object[] {
                        loan_amount,
                        interest_rate,
                        loan_term});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void calculate_personal_loan_repaymentAsync(float loan_amount, float interest_rate, int loan_term) {
            this.calculate_personal_loan_repaymentAsync(loan_amount, interest_rate, loan_term, null);
        }
        
        /// <remarks/>
        public void calculate_personal_loan_repaymentAsync(float loan_amount, float interest_rate, int loan_term, object userState) {
            if ((this.calculate_personal_loan_repaymentOperationCompleted == null)) {
                this.calculate_personal_loan_repaymentOperationCompleted = new System.Threading.SendOrPostCallback(this.Oncalculate_personal_loan_repaymentOperationCompleted);
            }
            this.InvokeAsync("calculate_personal_loan_repayment", new object[] {
                        loan_amount,
                        interest_rate,
                        loan_term}, this.calculate_personal_loan_repaymentOperationCompleted, userState);
        }
        
        private void Oncalculate_personal_loan_repaymentOperationCompleted(object arg) {
            if ((this.calculate_personal_loan_repaymentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.calculate_personal_loan_repaymentCompleted(this, new calculate_personal_loan_repaymentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.34/FinalProject/TheWebService.php/calculate_car_loan_repayment", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public float calculate_car_loan_repayment(float car_price, float down_payment, float interest_rate, int loan_term) {
            object[] results = this.Invoke("calculate_car_loan_repayment", new object[] {
                        car_price,
                        down_payment,
                        interest_rate,
                        loan_term});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void calculate_car_loan_repaymentAsync(float car_price, float down_payment, float interest_rate, int loan_term) {
            this.calculate_car_loan_repaymentAsync(car_price, down_payment, interest_rate, loan_term, null);
        }
        
        /// <remarks/>
        public void calculate_car_loan_repaymentAsync(float car_price, float down_payment, float interest_rate, int loan_term, object userState) {
            if ((this.calculate_car_loan_repaymentOperationCompleted == null)) {
                this.calculate_car_loan_repaymentOperationCompleted = new System.Threading.SendOrPostCallback(this.Oncalculate_car_loan_repaymentOperationCompleted);
            }
            this.InvokeAsync("calculate_car_loan_repayment", new object[] {
                        car_price,
                        down_payment,
                        interest_rate,
                        loan_term}, this.calculate_car_loan_repaymentOperationCompleted, userState);
        }
        
        private void Oncalculate_car_loan_repaymentOperationCompleted(object arg) {
            if ((this.calculate_car_loan_repaymentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.calculate_car_loan_repaymentCompleted(this, new calculate_car_loan_repaymentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.34/FinalProject/TheWebService.php/calculate_home_loan_repayment", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public float calculate_home_loan_repayment(float home_price, float down_payment, float interest_rate, int loan_term) {
            object[] results = this.Invoke("calculate_home_loan_repayment", new object[] {
                        home_price,
                        down_payment,
                        interest_rate,
                        loan_term});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void calculate_home_loan_repaymentAsync(float home_price, float down_payment, float interest_rate, int loan_term) {
            this.calculate_home_loan_repaymentAsync(home_price, down_payment, interest_rate, loan_term, null);
        }
        
        /// <remarks/>
        public void calculate_home_loan_repaymentAsync(float home_price, float down_payment, float interest_rate, int loan_term, object userState) {
            if ((this.calculate_home_loan_repaymentOperationCompleted == null)) {
                this.calculate_home_loan_repaymentOperationCompleted = new System.Threading.SendOrPostCallback(this.Oncalculate_home_loan_repaymentOperationCompleted);
            }
            this.InvokeAsync("calculate_home_loan_repayment", new object[] {
                        home_price,
                        down_payment,
                        interest_rate,
                        loan_term}, this.calculate_home_loan_repaymentOperationCompleted, userState);
        }
        
        private void Oncalculate_home_loan_repaymentOperationCompleted(object arg) {
            if ((this.calculate_home_loan_repaymentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.calculate_home_loan_repaymentCompleted(this, new calculate_home_loan_repaymentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://192.168.1.34/FinalProject/TheWebService.php/calculate_education_loan_repay" +
            "ment", RequestNamespace="", ResponseNamespace="")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public float calculate_education_loan_repayment(float loan_amount, float interest_rate, int loan_term, int grace_period) {
            object[] results = this.Invoke("calculate_education_loan_repayment", new object[] {
                        loan_amount,
                        interest_rate,
                        loan_term,
                        grace_period});
            return ((float)(results[0]));
        }
        
        /// <remarks/>
        public void calculate_education_loan_repaymentAsync(float loan_amount, float interest_rate, int loan_term, int grace_period) {
            this.calculate_education_loan_repaymentAsync(loan_amount, interest_rate, loan_term, grace_period, null);
        }
        
        /// <remarks/>
        public void calculate_education_loan_repaymentAsync(float loan_amount, float interest_rate, int loan_term, int grace_period, object userState) {
            if ((this.calculate_education_loan_repaymentOperationCompleted == null)) {
                this.calculate_education_loan_repaymentOperationCompleted = new System.Threading.SendOrPostCallback(this.Oncalculate_education_loan_repaymentOperationCompleted);
            }
            this.InvokeAsync("calculate_education_loan_repayment", new object[] {
                        loan_amount,
                        interest_rate,
                        loan_term,
                        grace_period}, this.calculate_education_loan_repaymentOperationCompleted, userState);
        }
        
        private void Oncalculate_education_loan_repaymentOperationCompleted(object arg) {
            if ((this.calculate_education_loan_repaymentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.calculate_education_loan_repaymentCompleted(this, new calculate_education_loan_repaymentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void calculate_personal_loan_repaymentCompletedEventHandler(object sender, calculate_personal_loan_repaymentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class calculate_personal_loan_repaymentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal calculate_personal_loan_repaymentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void calculate_car_loan_repaymentCompletedEventHandler(object sender, calculate_car_loan_repaymentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class calculate_car_loan_repaymentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal calculate_car_loan_repaymentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void calculate_home_loan_repaymentCompletedEventHandler(object sender, calculate_home_loan_repaymentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class calculate_home_loan_repaymentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal calculate_home_loan_repaymentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void calculate_education_loan_repaymentCompletedEventHandler(object sender, calculate_education_loan_repaymentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class calculate_education_loan_repaymentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal calculate_education_loan_repaymentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public float Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591