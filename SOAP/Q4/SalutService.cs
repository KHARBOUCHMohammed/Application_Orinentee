﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="SalutPortBinding", Namespace="http://localhost:8080")]
public partial class SalutService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback salutOperationCompleted;
    
    /// <remarks/>
    public SalutService() {
        this.Url = "http://localhost:8080/Question3/SalutService";
    }
    
    /// <remarks/>
    public event salutCompletedEventHandler salutCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://localhost:8080", ResponseNamespace="http://localhost:8080", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string salut([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string arg0) {
        object[] results = this.Invoke("salut", new object[] {
                    arg0});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginsalut(string arg0, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("salut", new object[] {
                    arg0}, callback, asyncState);
    }
    
    /// <remarks/>
    public string Endsalut(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void salutAsync(string arg0) {
        this.salutAsync(arg0, null);
    }
    
    /// <remarks/>
    public void salutAsync(string arg0, object userState) {
        if ((this.salutOperationCompleted == null)) {
            this.salutOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsalutOperationCompleted);
        }
        this.InvokeAsync("salut", new object[] {
                    arg0}, this.salutOperationCompleted, userState);
    }
    
    private void OnsalutOperationCompleted(object arg) {
        if ((this.salutCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.salutCompleted(this, new salutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void salutCompletedEventHandler(object sender, salutCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class salutCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal salutCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
