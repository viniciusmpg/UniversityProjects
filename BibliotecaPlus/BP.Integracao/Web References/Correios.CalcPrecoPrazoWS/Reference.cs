﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.269.
// 
#pragma warning disable 1591

namespace Integracao.Correios.CalcPrecoPrazoWS {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="CalcPrecoPrazoWSSoap", Namespace="http://tempuri.org/")]
    public partial class CalcPrecoPrazoWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CalcPrecoPrazoOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalcPrecoOperationCompleted;
        
        private System.Threading.SendOrPostCallback CalcPrazoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CalcPrecoPrazoWS() {
            this.Url = global::Integracao.Properties.Settings.Default.Integracao_Correios_CalcPrecoPrazoWS_CalcPrecoPrazoWS;
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
        public event CalcPrecoPrazoCompletedEventHandler CalcPrecoPrazoCompleted;
        
        /// <remarks/>
        public event CalcPrecoCompletedEventHandler CalcPrecoCompleted;
        
        /// <remarks/>
        public event CalcPrazoCompletedEventHandler CalcPrazoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrecoPrazo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public cResultado CalcPrecoPrazo(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            object[] results = this.Invoke("CalcPrecoPrazo", new object[] {
                        nCdEmpresa,
                        sDsSenha,
                        nCdServico,
                        sCepOrigem,
                        sCepDestino,
                        nVlPeso,
                        nCdFormato,
                        nVlComprimento,
                        nVlAltura,
                        nVlLargura,
                        nVlDiametro,
                        sCdMaoPropria,
                        nVlValorDeclarado,
                        sCdAvisoRecebimento});
            return ((cResultado)(results[0]));
        }
        
        /// <remarks/>
        public void CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            this.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, null);
        }
        
        /// <remarks/>
        public void CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, object userState) {
            if ((this.CalcPrecoPrazoOperationCompleted == null)) {
                this.CalcPrecoPrazoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalcPrecoPrazoOperationCompleted);
            }
            this.InvokeAsync("CalcPrecoPrazo", new object[] {
                        nCdEmpresa,
                        sDsSenha,
                        nCdServico,
                        sCepOrigem,
                        sCepDestino,
                        nVlPeso,
                        nCdFormato,
                        nVlComprimento,
                        nVlAltura,
                        nVlLargura,
                        nVlDiametro,
                        sCdMaoPropria,
                        nVlValorDeclarado,
                        sCdAvisoRecebimento}, this.CalcPrecoPrazoOperationCompleted, userState);
        }
        
        private void OnCalcPrecoPrazoOperationCompleted(object arg) {
            if ((this.CalcPrecoPrazoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalcPrecoPrazoCompleted(this, new CalcPrecoPrazoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPreco", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public cResultado CalcPreco(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            object[] results = this.Invoke("CalcPreco", new object[] {
                        nCdEmpresa,
                        sDsSenha,
                        nCdServico,
                        sCepOrigem,
                        sCepDestino,
                        nVlPeso,
                        nCdFormato,
                        nVlComprimento,
                        nVlAltura,
                        nVlLargura,
                        nVlDiametro,
                        sCdMaoPropria,
                        nVlValorDeclarado,
                        sCdAvisoRecebimento});
            return ((cResultado)(results[0]));
        }
        
        /// <remarks/>
        public void CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento) {
            this.CalcPrecoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, null);
        }
        
        /// <remarks/>
        public void CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, object userState) {
            if ((this.CalcPrecoOperationCompleted == null)) {
                this.CalcPrecoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalcPrecoOperationCompleted);
            }
            this.InvokeAsync("CalcPreco", new object[] {
                        nCdEmpresa,
                        sDsSenha,
                        nCdServico,
                        sCepOrigem,
                        sCepDestino,
                        nVlPeso,
                        nCdFormato,
                        nVlComprimento,
                        nVlAltura,
                        nVlLargura,
                        nVlDiametro,
                        sCdMaoPropria,
                        nVlValorDeclarado,
                        sCdAvisoRecebimento}, this.CalcPrecoOperationCompleted, userState);
        }
        
        private void OnCalcPrecoOperationCompleted(object arg) {
            if ((this.CalcPrecoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalcPrecoCompleted(this, new CalcPrecoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CalcPrazo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public cResultado CalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino) {
            object[] results = this.Invoke("CalcPrazo", new object[] {
                        nCdServico,
                        sCepOrigem,
                        sCepDestino});
            return ((cResultado)(results[0]));
        }
        
        /// <remarks/>
        public void CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino) {
            this.CalcPrazoAsync(nCdServico, sCepOrigem, sCepDestino, null);
        }
        
        /// <remarks/>
        public void CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino, object userState) {
            if ((this.CalcPrazoOperationCompleted == null)) {
                this.CalcPrazoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCalcPrazoOperationCompleted);
            }
            this.InvokeAsync("CalcPrazo", new object[] {
                        nCdServico,
                        sCepOrigem,
                        sCepDestino}, this.CalcPrazoOperationCompleted, userState);
        }
        
        private void OnCalcPrazoOperationCompleted(object arg) {
            if ((this.CalcPrazoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CalcPrazoCompleted(this, new CalcPrazoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class cResultado {
        
        private cServico[] servicosField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public cServico[] Servicos {
            get {
                return this.servicosField;
            }
            set {
                this.servicosField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class cServico {
        
        private int codigoField;
        
        private string valorField;
        
        private string prazoEntregaField;
        
        private string valorMaoPropriaField;
        
        private string valorAvisoRecebimentoField;
        
        private string valorValorDeclaradoField;
        
        private string entregaDomiciliarField;
        
        private string entregaSabadoField;
        
        private string erroField;
        
        private string msgErroField;
        
        /// <remarks/>
        public int Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
        
        /// <remarks/>
        public string PrazoEntrega {
            get {
                return this.prazoEntregaField;
            }
            set {
                this.prazoEntregaField = value;
            }
        }
        
        /// <remarks/>
        public string ValorMaoPropria {
            get {
                return this.valorMaoPropriaField;
            }
            set {
                this.valorMaoPropriaField = value;
            }
        }
        
        /// <remarks/>
        public string ValorAvisoRecebimento {
            get {
                return this.valorAvisoRecebimentoField;
            }
            set {
                this.valorAvisoRecebimentoField = value;
            }
        }
        
        /// <remarks/>
        public string ValorValorDeclarado {
            get {
                return this.valorValorDeclaradoField;
            }
            set {
                this.valorValorDeclaradoField = value;
            }
        }
        
        /// <remarks/>
        public string EntregaDomiciliar {
            get {
                return this.entregaDomiciliarField;
            }
            set {
                this.entregaDomiciliarField = value;
            }
        }
        
        /// <remarks/>
        public string EntregaSabado {
            get {
                return this.entregaSabadoField;
            }
            set {
                this.entregaSabadoField = value;
            }
        }
        
        /// <remarks/>
        public string Erro {
            get {
                return this.erroField;
            }
            set {
                this.erroField = value;
            }
        }
        
        /// <remarks/>
        public string MsgErro {
            get {
                return this.msgErroField;
            }
            set {
                this.msgErroField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CalcPrecoPrazoCompletedEventHandler(object sender, CalcPrecoPrazoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalcPrecoPrazoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalcPrecoPrazoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public cResultado Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((cResultado)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CalcPrecoCompletedEventHandler(object sender, CalcPrecoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalcPrecoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalcPrecoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public cResultado Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((cResultado)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void CalcPrazoCompletedEventHandler(object sender, CalcPrazoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CalcPrazoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CalcPrazoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public cResultado Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((cResultado)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591