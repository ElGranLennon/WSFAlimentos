﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSFAlimentos.SWTipo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service/", ConfigurationName="SWTipo.WSTipo")]
    public interface WSTipo {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/createTipoRequest", ReplyAction="http://service/WSTipo/createTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.createTipoResponse createTipo(WSFAlimentos.SWTipo.createTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/createTipoRequest", ReplyAction="http://service/WSTipo/createTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.createTipoResponse> createTipoAsync(WSFAlimentos.SWTipo.createTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/editTipoRequest", ReplyAction="http://service/WSTipo/editTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.editTipoResponse editTipo(WSFAlimentos.SWTipo.editTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/editTipoRequest", ReplyAction="http://service/WSTipo/editTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.editTipoResponse> editTipoAsync(WSFAlimentos.SWTipo.editTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/removeTipoRequest", ReplyAction="http://service/WSTipo/removeTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.removeTipoResponse removeTipo(WSFAlimentos.SWTipo.removeTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/removeTipoRequest", ReplyAction="http://service/WSTipo/removeTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.removeTipoResponse> removeTipoAsync(WSFAlimentos.SWTipo.removeTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findTipoRequest", ReplyAction="http://service/WSTipo/findTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.findTipoResponse findTipo(WSFAlimentos.SWTipo.findTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findTipoRequest", ReplyAction="http://service/WSTipo/findTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findTipoResponse> findTipoAsync(WSFAlimentos.SWTipo.findTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findAllTipoRequest", ReplyAction="http://service/WSTipo/findAllTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.findAllTipoResponse findAllTipo(WSFAlimentos.SWTipo.findAllTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findAllTipoRequest", ReplyAction="http://service/WSTipo/findAllTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findAllTipoResponse> findAllTipoAsync(WSFAlimentos.SWTipo.findAllTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findRangeTipoRequest", ReplyAction="http://service/WSTipo/findRangeTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.findRangeTipoResponse findRangeTipo(WSFAlimentos.SWTipo.findRangeTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/findRangeTipoRequest", ReplyAction="http://service/WSTipo/findRangeTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findRangeTipoResponse> findRangeTipoAsync(WSFAlimentos.SWTipo.findRangeTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/countTipoRequest", ReplyAction="http://service/WSTipo/countTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWTipo.countTipoResponse countTipo(WSFAlimentos.SWTipo.countTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSTipo/countTipoRequest", ReplyAction="http://service/WSTipo/countTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.countTipoResponse> countTipoAsync(WSFAlimentos.SWTipo.countTipoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service/")]
    public partial class tipoProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionTpField;
        
        private short idTpField;
        
        private bool idTpFieldSpecified;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcionTp {
            get {
                return this.descripcionTpField;
            }
            set {
                this.descripcionTpField = value;
                this.RaisePropertyChanged("descripcionTp");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public short idTp {
            get {
                return this.idTpField;
            }
            set {
                this.idTpField = value;
                this.RaisePropertyChanged("idTp");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idTpSpecified {
            get {
                return this.idTpFieldSpecified;
            }
            set {
                this.idTpFieldSpecified = value;
                this.RaisePropertyChanged("idTpSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class createTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto entity;
        
        public createTipoRequest() {
        }
        
        public createTipoRequest(WSFAlimentos.SWTipo.tipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class createTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public createTipoResponse() {
        }
        
        public createTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class editTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto entity;
        
        public editTipoRequest() {
        }
        
        public editTipoRequest(WSFAlimentos.SWTipo.tipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="editTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class editTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public editTipoResponse() {
        }
        
        public editTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class removeTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto entity;
        
        public removeTipoRequest() {
        }
        
        public removeTipoRequest(WSFAlimentos.SWTipo.tipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class removeTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public removeTipoResponse() {
        }
        
        public removeTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public findTipoRequest() {
        }
        
        public findTipoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto @return;
        
        public findTipoResponse() {
        }
        
        public findTipoResponse(WSFAlimentos.SWTipo.tipoProducto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAllTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findAllTipoRequest {
        
        public findAllTipoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAllTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findAllTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto[] @return;
        
        public findAllTipoResponse() {
        }
        
        public findAllTipoResponse(WSFAlimentos.SWTipo.tipoProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findRangeTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findRangeTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("range", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Nullable<int>[] range;
        
        public findRangeTipoRequest() {
        }
        
        public findRangeTipoRequest(System.Nullable<int>[] range) {
            this.range = range;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findRangeTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findRangeTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWTipo.tipoProducto[] @return;
        
        public findRangeTipoResponse() {
        }
        
        public findRangeTipoResponse(WSFAlimentos.SWTipo.tipoProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="countTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class countTipoRequest {
        
        public countTipoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="countTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class countTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public countTipoResponse() {
        }
        
        public countTipoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSTipoChannel : WSFAlimentos.SWTipo.WSTipo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSTipoClient : System.ServiceModel.ClientBase<WSFAlimentos.SWTipo.WSTipo>, WSFAlimentos.SWTipo.WSTipo {
        
        public WSTipoClient() {
        }
        
        public WSTipoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSTipoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTipoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSTipoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.createTipoResponse WSFAlimentos.SWTipo.WSTipo.createTipo(WSFAlimentos.SWTipo.createTipoRequest request) {
            return base.Channel.createTipo(request);
        }
        
        public bool createTipo(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.createTipoRequest inValue = new WSFAlimentos.SWTipo.createTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWTipo.createTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).createTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.createTipoResponse> WSFAlimentos.SWTipo.WSTipo.createTipoAsync(WSFAlimentos.SWTipo.createTipoRequest request) {
            return base.Channel.createTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.createTipoResponse> createTipoAsync(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.createTipoRequest inValue = new WSFAlimentos.SWTipo.createTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).createTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.editTipoResponse WSFAlimentos.SWTipo.WSTipo.editTipo(WSFAlimentos.SWTipo.editTipoRequest request) {
            return base.Channel.editTipo(request);
        }
        
        public bool editTipo(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.editTipoRequest inValue = new WSFAlimentos.SWTipo.editTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWTipo.editTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).editTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.editTipoResponse> WSFAlimentos.SWTipo.WSTipo.editTipoAsync(WSFAlimentos.SWTipo.editTipoRequest request) {
            return base.Channel.editTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.editTipoResponse> editTipoAsync(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.editTipoRequest inValue = new WSFAlimentos.SWTipo.editTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).editTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.removeTipoResponse WSFAlimentos.SWTipo.WSTipo.removeTipo(WSFAlimentos.SWTipo.removeTipoRequest request) {
            return base.Channel.removeTipo(request);
        }
        
        public bool removeTipo(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.removeTipoRequest inValue = new WSFAlimentos.SWTipo.removeTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWTipo.removeTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).removeTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.removeTipoResponse> WSFAlimentos.SWTipo.WSTipo.removeTipoAsync(WSFAlimentos.SWTipo.removeTipoRequest request) {
            return base.Channel.removeTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.removeTipoResponse> removeTipoAsync(WSFAlimentos.SWTipo.tipoProducto entity) {
            WSFAlimentos.SWTipo.removeTipoRequest inValue = new WSFAlimentos.SWTipo.removeTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).removeTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.findTipoResponse WSFAlimentos.SWTipo.WSTipo.findTipo(WSFAlimentos.SWTipo.findTipoRequest request) {
            return base.Channel.findTipo(request);
        }
        
        public WSFAlimentos.SWTipo.tipoProducto findTipo(int id) {
            WSFAlimentos.SWTipo.findTipoRequest inValue = new WSFAlimentos.SWTipo.findTipoRequest();
            inValue.id = id;
            WSFAlimentos.SWTipo.findTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).findTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findTipoResponse> WSFAlimentos.SWTipo.WSTipo.findTipoAsync(WSFAlimentos.SWTipo.findTipoRequest request) {
            return base.Channel.findTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findTipoResponse> findTipoAsync(int id) {
            WSFAlimentos.SWTipo.findTipoRequest inValue = new WSFAlimentos.SWTipo.findTipoRequest();
            inValue.id = id;
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).findTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.findAllTipoResponse WSFAlimentos.SWTipo.WSTipo.findAllTipo(WSFAlimentos.SWTipo.findAllTipoRequest request) {
            return base.Channel.findAllTipo(request);
        }
        
        public WSFAlimentos.SWTipo.tipoProducto[] findAllTipo() {
            WSFAlimentos.SWTipo.findAllTipoRequest inValue = new WSFAlimentos.SWTipo.findAllTipoRequest();
            WSFAlimentos.SWTipo.findAllTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).findAllTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findAllTipoResponse> WSFAlimentos.SWTipo.WSTipo.findAllTipoAsync(WSFAlimentos.SWTipo.findAllTipoRequest request) {
            return base.Channel.findAllTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findAllTipoResponse> findAllTipoAsync() {
            WSFAlimentos.SWTipo.findAllTipoRequest inValue = new WSFAlimentos.SWTipo.findAllTipoRequest();
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).findAllTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.findRangeTipoResponse WSFAlimentos.SWTipo.WSTipo.findRangeTipo(WSFAlimentos.SWTipo.findRangeTipoRequest request) {
            return base.Channel.findRangeTipo(request);
        }
        
        public WSFAlimentos.SWTipo.tipoProducto[] findRangeTipo(System.Nullable<int>[] range) {
            WSFAlimentos.SWTipo.findRangeTipoRequest inValue = new WSFAlimentos.SWTipo.findRangeTipoRequest();
            inValue.range = range;
            WSFAlimentos.SWTipo.findRangeTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).findRangeTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findRangeTipoResponse> WSFAlimentos.SWTipo.WSTipo.findRangeTipoAsync(WSFAlimentos.SWTipo.findRangeTipoRequest request) {
            return base.Channel.findRangeTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.findRangeTipoResponse> findRangeTipoAsync(System.Nullable<int>[] range) {
            WSFAlimentos.SWTipo.findRangeTipoRequest inValue = new WSFAlimentos.SWTipo.findRangeTipoRequest();
            inValue.range = range;
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).findRangeTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWTipo.countTipoResponse WSFAlimentos.SWTipo.WSTipo.countTipo(WSFAlimentos.SWTipo.countTipoRequest request) {
            return base.Channel.countTipo(request);
        }
        
        public int countTipo() {
            WSFAlimentos.SWTipo.countTipoRequest inValue = new WSFAlimentos.SWTipo.countTipoRequest();
            WSFAlimentos.SWTipo.countTipoResponse retVal = ((WSFAlimentos.SWTipo.WSTipo)(this)).countTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWTipo.countTipoResponse> WSFAlimentos.SWTipo.WSTipo.countTipoAsync(WSFAlimentos.SWTipo.countTipoRequest request) {
            return base.Channel.countTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWTipo.countTipoResponse> countTipoAsync() {
            WSFAlimentos.SWTipo.countTipoRequest inValue = new WSFAlimentos.SWTipo.countTipoRequest();
            return ((WSFAlimentos.SWTipo.WSTipo)(this)).countTipoAsync(inValue);
        }
    }
}
