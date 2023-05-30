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
[System.Web.Services.WebServiceBindingAttribute(Name="TextCasingSoapBinding", Namespace="http://www.dataaccess.com/webservicesserver/")]
public partial class TextCasing : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback TitleCaseWordsWithTokenOperationCompleted;
    
    private System.Threading.SendOrPostCallback InvertStringCaseOperationCompleted;
    
    private System.Threading.SendOrPostCallback InvertCaseFirstAdjustStringToPreviousOperationCompleted;
    
    private System.Threading.SendOrPostCallback InvertCaseFirstAdjustStringToCurrentOperationCompleted;
    
    private System.Threading.SendOrPostCallback AllUppercaseWithTokenOperationCompleted;
    
    private System.Threading.SendOrPostCallback AllLowercaseWithTokenOperationCompleted;
    
    private System.Threading.SendOrPostCallback UppercaseWordsWithTokenOperationCompleted;
    
    private System.Threading.SendOrPostCallback LowercaseWordsWithTokenOperationCompleted;
    
    /// <remarks/>
    public TextCasing() {
        this.Url = "https://www.dataaccess.com/webservicesserver/textcasing.wso";
    }
    
    /// <remarks/>
    public event TitleCaseWordsWithTokenCompletedEventHandler TitleCaseWordsWithTokenCompleted;
    
    /// <remarks/>
    public event InvertStringCaseCompletedEventHandler InvertStringCaseCompleted;
    
    /// <remarks/>
    public event InvertCaseFirstAdjustStringToPreviousCompletedEventHandler InvertCaseFirstAdjustStringToPreviousCompleted;
    
    /// <remarks/>
    public event InvertCaseFirstAdjustStringToCurrentCompletedEventHandler InvertCaseFirstAdjustStringToCurrentCompleted;
    
    /// <remarks/>
    public event AllUppercaseWithTokenCompletedEventHandler AllUppercaseWithTokenCompleted;
    
    /// <remarks/>
    public event AllLowercaseWithTokenCompletedEventHandler AllLowercaseWithTokenCompleted;
    
    /// <remarks/>
    public event UppercaseWordsWithTokenCompletedEventHandler UppercaseWordsWithTokenCompleted;
    
    /// <remarks/>
    public event LowercaseWordsWithTokenCompletedEventHandler LowercaseWordsWithTokenCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string TitleCaseWordsWithToken(string sText, string sToken) {
        object[] results = this.Invoke("TitleCaseWordsWithToken", new object[] {
                    sText,
                    sToken});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginTitleCaseWordsWithToken(string sText, string sToken, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("TitleCaseWordsWithToken", new object[] {
                    sText,
                    sToken}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndTitleCaseWordsWithToken(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void TitleCaseWordsWithTokenAsync(string sText, string sToken) {
        this.TitleCaseWordsWithTokenAsync(sText, sToken, null);
    }
    
    /// <remarks/>
    public void TitleCaseWordsWithTokenAsync(string sText, string sToken, object userState) {
        if ((this.TitleCaseWordsWithTokenOperationCompleted == null)) {
            this.TitleCaseWordsWithTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTitleCaseWordsWithTokenOperationCompleted);
        }
        this.InvokeAsync("TitleCaseWordsWithToken", new object[] {
                    sText,
                    sToken}, this.TitleCaseWordsWithTokenOperationCompleted, userState);
    }
    
    private void OnTitleCaseWordsWithTokenOperationCompleted(object arg) {
        if ((this.TitleCaseWordsWithTokenCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.TitleCaseWordsWithTokenCompleted(this, new TitleCaseWordsWithTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string InvertStringCase(string sAString) {
        object[] results = this.Invoke("InvertStringCase", new object[] {
                    sAString});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginInvertStringCase(string sAString, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("InvertStringCase", new object[] {
                    sAString}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndInvertStringCase(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void InvertStringCaseAsync(string sAString) {
        this.InvertStringCaseAsync(sAString, null);
    }
    
    /// <remarks/>
    public void InvertStringCaseAsync(string sAString, object userState) {
        if ((this.InvertStringCaseOperationCompleted == null)) {
            this.InvertStringCaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInvertStringCaseOperationCompleted);
        }
        this.InvokeAsync("InvertStringCase", new object[] {
                    sAString}, this.InvertStringCaseOperationCompleted, userState);
    }
    
    private void OnInvertStringCaseOperationCompleted(object arg) {
        if ((this.InvertStringCaseCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.InvertStringCaseCompleted(this, new InvertStringCaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string InvertCaseFirstAdjustStringToPrevious(string sAString) {
        object[] results = this.Invoke("InvertCaseFirstAdjustStringToPrevious", new object[] {
                    sAString});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginInvertCaseFirstAdjustStringToPrevious(string sAString, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("InvertCaseFirstAdjustStringToPrevious", new object[] {
                    sAString}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndInvertCaseFirstAdjustStringToPrevious(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void InvertCaseFirstAdjustStringToPreviousAsync(string sAString) {
        this.InvertCaseFirstAdjustStringToPreviousAsync(sAString, null);
    }
    
    /// <remarks/>
    public void InvertCaseFirstAdjustStringToPreviousAsync(string sAString, object userState) {
        if ((this.InvertCaseFirstAdjustStringToPreviousOperationCompleted == null)) {
            this.InvertCaseFirstAdjustStringToPreviousOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInvertCaseFirstAdjustStringToPreviousOperationCompleted);
        }
        this.InvokeAsync("InvertCaseFirstAdjustStringToPrevious", new object[] {
                    sAString}, this.InvertCaseFirstAdjustStringToPreviousOperationCompleted, userState);
    }
    
    private void OnInvertCaseFirstAdjustStringToPreviousOperationCompleted(object arg) {
        if ((this.InvertCaseFirstAdjustStringToPreviousCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.InvertCaseFirstAdjustStringToPreviousCompleted(this, new InvertCaseFirstAdjustStringToPreviousCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string InvertCaseFirstAdjustStringToCurrent(string sAString) {
        object[] results = this.Invoke("InvertCaseFirstAdjustStringToCurrent", new object[] {
                    sAString});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginInvertCaseFirstAdjustStringToCurrent(string sAString, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("InvertCaseFirstAdjustStringToCurrent", new object[] {
                    sAString}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndInvertCaseFirstAdjustStringToCurrent(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void InvertCaseFirstAdjustStringToCurrentAsync(string sAString) {
        this.InvertCaseFirstAdjustStringToCurrentAsync(sAString, null);
    }
    
    /// <remarks/>
    public void InvertCaseFirstAdjustStringToCurrentAsync(string sAString, object userState) {
        if ((this.InvertCaseFirstAdjustStringToCurrentOperationCompleted == null)) {
            this.InvertCaseFirstAdjustStringToCurrentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInvertCaseFirstAdjustStringToCurrentOperationCompleted);
        }
        this.InvokeAsync("InvertCaseFirstAdjustStringToCurrent", new object[] {
                    sAString}, this.InvertCaseFirstAdjustStringToCurrentOperationCompleted, userState);
    }
    
    private void OnInvertCaseFirstAdjustStringToCurrentOperationCompleted(object arg) {
        if ((this.InvertCaseFirstAdjustStringToCurrentCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.InvertCaseFirstAdjustStringToCurrentCompleted(this, new InvertCaseFirstAdjustStringToCurrentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string AllUppercaseWithToken(string sAString, string sToken) {
        object[] results = this.Invoke("AllUppercaseWithToken", new object[] {
                    sAString,
                    sToken});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginAllUppercaseWithToken(string sAString, string sToken, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("AllUppercaseWithToken", new object[] {
                    sAString,
                    sToken}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndAllUppercaseWithToken(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void AllUppercaseWithTokenAsync(string sAString, string sToken) {
        this.AllUppercaseWithTokenAsync(sAString, sToken, null);
    }
    
    /// <remarks/>
    public void AllUppercaseWithTokenAsync(string sAString, string sToken, object userState) {
        if ((this.AllUppercaseWithTokenOperationCompleted == null)) {
            this.AllUppercaseWithTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllUppercaseWithTokenOperationCompleted);
        }
        this.InvokeAsync("AllUppercaseWithToken", new object[] {
                    sAString,
                    sToken}, this.AllUppercaseWithTokenOperationCompleted, userState);
    }
    
    private void OnAllUppercaseWithTokenOperationCompleted(object arg) {
        if ((this.AllUppercaseWithTokenCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllUppercaseWithTokenCompleted(this, new AllUppercaseWithTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string AllLowercaseWithToken(string sAString, string sToken) {
        object[] results = this.Invoke("AllLowercaseWithToken", new object[] {
                    sAString,
                    sToken});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginAllLowercaseWithToken(string sAString, string sToken, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("AllLowercaseWithToken", new object[] {
                    sAString,
                    sToken}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndAllLowercaseWithToken(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void AllLowercaseWithTokenAsync(string sAString, string sToken) {
        this.AllLowercaseWithTokenAsync(sAString, sToken, null);
    }
    
    /// <remarks/>
    public void AllLowercaseWithTokenAsync(string sAString, string sToken, object userState) {
        if ((this.AllLowercaseWithTokenOperationCompleted == null)) {
            this.AllLowercaseWithTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAllLowercaseWithTokenOperationCompleted);
        }
        this.InvokeAsync("AllLowercaseWithToken", new object[] {
                    sAString,
                    sToken}, this.AllLowercaseWithTokenOperationCompleted, userState);
    }
    
    private void OnAllLowercaseWithTokenOperationCompleted(object arg) {
        if ((this.AllLowercaseWithTokenCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AllLowercaseWithTokenCompleted(this, new AllLowercaseWithTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string UppercaseWordsWithToken(string sAString, string sToken) {
        object[] results = this.Invoke("UppercaseWordsWithToken", new object[] {
                    sAString,
                    sToken});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginUppercaseWordsWithToken(string sAString, string sToken, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UppercaseWordsWithToken", new object[] {
                    sAString,
                    sToken}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndUppercaseWordsWithToken(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void UppercaseWordsWithTokenAsync(string sAString, string sToken) {
        this.UppercaseWordsWithTokenAsync(sAString, sToken, null);
    }
    
    /// <remarks/>
    public void UppercaseWordsWithTokenAsync(string sAString, string sToken, object userState) {
        if ((this.UppercaseWordsWithTokenOperationCompleted == null)) {
            this.UppercaseWordsWithTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUppercaseWordsWithTokenOperationCompleted);
        }
        this.InvokeAsync("UppercaseWordsWithToken", new object[] {
                    sAString,
                    sToken}, this.UppercaseWordsWithTokenOperationCompleted, userState);
    }
    
    private void OnUppercaseWordsWithTokenOperationCompleted(object arg) {
        if ((this.UppercaseWordsWithTokenCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.UppercaseWordsWithTokenCompleted(this, new UppercaseWordsWithTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://www.dataaccess.com/webservicesserver/", ResponseNamespace="http://www.dataaccess.com/webservicesserver/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public string LowercaseWordsWithToken(string sAString, string sToken) {
        object[] results = this.Invoke("LowercaseWordsWithToken", new object[] {
                    sAString,
                    sToken});
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginLowercaseWordsWithToken(string sAString, string sToken, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("LowercaseWordsWithToken", new object[] {
                    sAString,
                    sToken}, callback, asyncState);
    }
    
    /// <remarks/>
    public string EndLowercaseWordsWithToken(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void LowercaseWordsWithTokenAsync(string sAString, string sToken) {
        this.LowercaseWordsWithTokenAsync(sAString, sToken, null);
    }
    
    /// <remarks/>
    public void LowercaseWordsWithTokenAsync(string sAString, string sToken, object userState) {
        if ((this.LowercaseWordsWithTokenOperationCompleted == null)) {
            this.LowercaseWordsWithTokenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLowercaseWordsWithTokenOperationCompleted);
        }
        this.InvokeAsync("LowercaseWordsWithToken", new object[] {
                    sAString,
                    sToken}, this.LowercaseWordsWithTokenOperationCompleted, userState);
    }
    
    private void OnLowercaseWordsWithTokenOperationCompleted(object arg) {
        if ((this.LowercaseWordsWithTokenCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.LowercaseWordsWithTokenCompleted(this, new LowercaseWordsWithTokenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void TitleCaseWordsWithTokenCompletedEventHandler(object sender, TitleCaseWordsWithTokenCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class TitleCaseWordsWithTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal TitleCaseWordsWithTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void InvertStringCaseCompletedEventHandler(object sender, InvertStringCaseCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InvertStringCaseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal InvertStringCaseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void InvertCaseFirstAdjustStringToPreviousCompletedEventHandler(object sender, InvertCaseFirstAdjustStringToPreviousCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InvertCaseFirstAdjustStringToPreviousCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal InvertCaseFirstAdjustStringToPreviousCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void InvertCaseFirstAdjustStringToCurrentCompletedEventHandler(object sender, InvertCaseFirstAdjustStringToCurrentCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class InvertCaseFirstAdjustStringToCurrentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal InvertCaseFirstAdjustStringToCurrentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void AllUppercaseWithTokenCompletedEventHandler(object sender, AllUppercaseWithTokenCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllUppercaseWithTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AllUppercaseWithTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void AllLowercaseWithTokenCompletedEventHandler(object sender, AllLowercaseWithTokenCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class AllLowercaseWithTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AllLowercaseWithTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void UppercaseWordsWithTokenCompletedEventHandler(object sender, UppercaseWordsWithTokenCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class UppercaseWordsWithTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal UppercaseWordsWithTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
public delegate void LowercaseWordsWithTokenCompletedEventHandler(object sender, LowercaseWordsWithTokenCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class LowercaseWordsWithTokenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal LowercaseWordsWithTokenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
