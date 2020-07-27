//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Paycomet_cs.api.paycomet.com_2 {
    using System.Xml.Serialization;
    using System.Diagnostics;
    using System.Web.Services;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("VisualStudio", "8.6.6.11")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="PAYTPV_OperationsGatewayBinding", Namespace="urn:PAYTPV_OperationsGateway")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(Operation))]
    public partial class PAYTPV_OperationsGatewayService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback search_operationsOperationCompleted;
        
        /// <remarks/>
        public PAYTPV_OperationsGatewayService() {
            this.Url = "https://api.paycomet.com/gateway/xml-operations";
        }
        
        public PAYTPV_OperationsGatewayService(string url) {
            this.Url = url;
        }
        
        /// <remarks/>
        public event search_operationsCompletedEventHandler search_operationsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("http://schemas.xmlsoap.org/soap/envelope/#Operations_Engine#search_operations", RequestNamespace="http://schemas.xmlsoap.org/soap/envelope/", ResponseNamespace="http://schemas.xmlsoap.org/soap/envelope/")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public Operation[] search_operations(
                    string PAYTPV_OPERATIONS_MERCHANTCODE, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_SORTYPE, 
                    string PAYTPV_OPERATIONS_SORTORDER, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_LIMIT, 
                    string[] PAYTPV_OPERATIONS_TERMINAL, 
                    string[] PAYTPV_OPERATIONS_OPERATIONS, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_MINAMOUNT, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_MAXAMOUNT, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_STATE, 
                    string PAYTPV_OPERATIONS_FROMDATE, 
                    string PAYTPV_OPERATIONS_TODATE, 
                    string PAYTPV_OPERATIONS_CURRENCY, 
                    string PAYTPV_OPERATIONS_SIGNATURE, 
                    string PAYTPV_OPERATIONS_REFERENCE, 
                    [System.Xml.Serialization.SoapElementAttribute(DataType="integer")] string PAYTPV_OPERATIONS_SEARCHTYPE, 
                    string PAYTPV_OPERATIONS_VERSION) {
            object[] results = this.Invoke("search_operations", new object[] {
                        PAYTPV_OPERATIONS_MERCHANTCODE,
                        PAYTPV_OPERATIONS_SORTYPE,
                        PAYTPV_OPERATIONS_SORTORDER,
                        PAYTPV_OPERATIONS_LIMIT,
                        PAYTPV_OPERATIONS_TERMINAL,
                        PAYTPV_OPERATIONS_OPERATIONS,
                        PAYTPV_OPERATIONS_MINAMOUNT,
                        PAYTPV_OPERATIONS_MAXAMOUNT,
                        PAYTPV_OPERATIONS_STATE,
                        PAYTPV_OPERATIONS_FROMDATE,
                        PAYTPV_OPERATIONS_TODATE,
                        PAYTPV_OPERATIONS_CURRENCY,
                        PAYTPV_OPERATIONS_SIGNATURE,
                        PAYTPV_OPERATIONS_REFERENCE,
                        PAYTPV_OPERATIONS_SEARCHTYPE,
                        PAYTPV_OPERATIONS_VERSION});
            return ((Operation[])(results[0]));
        }
        
        /// <remarks/>
        public void search_operationsAsync(
                    string PAYTPV_OPERATIONS_MERCHANTCODE, 
                    string PAYTPV_OPERATIONS_SORTYPE, 
                    string PAYTPV_OPERATIONS_SORTORDER, 
                    string PAYTPV_OPERATIONS_LIMIT, 
                    string[] PAYTPV_OPERATIONS_TERMINAL, 
                    string[] PAYTPV_OPERATIONS_OPERATIONS, 
                    string PAYTPV_OPERATIONS_MINAMOUNT, 
                    string PAYTPV_OPERATIONS_MAXAMOUNT, 
                    string PAYTPV_OPERATIONS_STATE, 
                    string PAYTPV_OPERATIONS_FROMDATE, 
                    string PAYTPV_OPERATIONS_TODATE, 
                    string PAYTPV_OPERATIONS_CURRENCY, 
                    string PAYTPV_OPERATIONS_SIGNATURE, 
                    string PAYTPV_OPERATIONS_REFERENCE, 
                    string PAYTPV_OPERATIONS_SEARCHTYPE, 
                    string PAYTPV_OPERATIONS_VERSION) {
            this.search_operationsAsync(PAYTPV_OPERATIONS_MERCHANTCODE, PAYTPV_OPERATIONS_SORTYPE, PAYTPV_OPERATIONS_SORTORDER, PAYTPV_OPERATIONS_LIMIT, PAYTPV_OPERATIONS_TERMINAL, PAYTPV_OPERATIONS_OPERATIONS, PAYTPV_OPERATIONS_MINAMOUNT, PAYTPV_OPERATIONS_MAXAMOUNT, PAYTPV_OPERATIONS_STATE, PAYTPV_OPERATIONS_FROMDATE, PAYTPV_OPERATIONS_TODATE, PAYTPV_OPERATIONS_CURRENCY, PAYTPV_OPERATIONS_SIGNATURE, PAYTPV_OPERATIONS_REFERENCE, PAYTPV_OPERATIONS_SEARCHTYPE, PAYTPV_OPERATIONS_VERSION, null);
        }
        
        /// <remarks/>
        public void search_operationsAsync(
                    string PAYTPV_OPERATIONS_MERCHANTCODE, 
                    string PAYTPV_OPERATIONS_SORTYPE, 
                    string PAYTPV_OPERATIONS_SORTORDER, 
                    string PAYTPV_OPERATIONS_LIMIT, 
                    string[] PAYTPV_OPERATIONS_TERMINAL, 
                    string[] PAYTPV_OPERATIONS_OPERATIONS, 
                    string PAYTPV_OPERATIONS_MINAMOUNT, 
                    string PAYTPV_OPERATIONS_MAXAMOUNT, 
                    string PAYTPV_OPERATIONS_STATE, 
                    string PAYTPV_OPERATIONS_FROMDATE, 
                    string PAYTPV_OPERATIONS_TODATE, 
                    string PAYTPV_OPERATIONS_CURRENCY, 
                    string PAYTPV_OPERATIONS_SIGNATURE, 
                    string PAYTPV_OPERATIONS_REFERENCE, 
                    string PAYTPV_OPERATIONS_SEARCHTYPE, 
                    string PAYTPV_OPERATIONS_VERSION, 
                    object userState) {
            if ((this.search_operationsOperationCompleted == null)) {
                this.search_operationsOperationCompleted = new System.Threading.SendOrPostCallback(this.Onsearch_operationsOperationCompleted);
            }
            this.InvokeAsync("search_operations", new object[] {
                        PAYTPV_OPERATIONS_MERCHANTCODE,
                        PAYTPV_OPERATIONS_SORTYPE,
                        PAYTPV_OPERATIONS_SORTORDER,
                        PAYTPV_OPERATIONS_LIMIT,
                        PAYTPV_OPERATIONS_TERMINAL,
                        PAYTPV_OPERATIONS_OPERATIONS,
                        PAYTPV_OPERATIONS_MINAMOUNT,
                        PAYTPV_OPERATIONS_MAXAMOUNT,
                        PAYTPV_OPERATIONS_STATE,
                        PAYTPV_OPERATIONS_FROMDATE,
                        PAYTPV_OPERATIONS_TODATE,
                        PAYTPV_OPERATIONS_CURRENCY,
                        PAYTPV_OPERATIONS_SIGNATURE,
                        PAYTPV_OPERATIONS_REFERENCE,
                        PAYTPV_OPERATIONS_SEARCHTYPE,
                        PAYTPV_OPERATIONS_VERSION}, this.search_operationsOperationCompleted, userState);
        }
        
        private void Onsearch_operationsOperationCompleted(object arg) {
            if ((this.search_operationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.search_operationsCompleted(this, new search_operationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("VisualStudio", "8.6.6.11")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:PAYTPV_OperationsGateway")]
    public partial class Operation {
        
        /// <remarks/>
        public string PAYTPV_ERROR_ID;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_ID;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_TIMESTAMP;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_REFERENCE;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_OPERATION;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_OPERATIONNAME;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_STATE;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_STATENAME;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_TERMINAL;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_TERMINALNAME;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_PAN;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_USER;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_AMOUNT;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_CURRENCY;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_AMOUNTDISPLAY;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_ERRORID;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_ERRORDESC;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_FEEEURO;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_FEEPERCENT;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_IP;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_CARDBRAND;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_BICCODE;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_SCORING;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_AUTHCODE;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_BANKMERCHANT;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_CONCEPT;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_PANCOUNTRY;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_COUNTRY;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_ISSUERBANK;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_SPLITID;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_METHODID;
        
        /// <remarks/>
        public string PAYTPV_OPERATION_METHODNAME;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("VisualStudio", "8.6.6.11")]
    public delegate void search_operationsCompletedEventHandler(object sender, search_operationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("VisualStudio", "8.6.6.11")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class search_operationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal search_operationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Operation[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Operation[])(this.results[0]));
            }
        }
    }
}