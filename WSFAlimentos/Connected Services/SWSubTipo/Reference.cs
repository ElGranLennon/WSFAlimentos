﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSFAlimentos.SWSubTipo {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service/", ConfigurationName="SWSubTipo.WSSubTipo")]
    public interface WSSubTipo {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findSubtipoProductoRequest", ReplyAction="http://service/WSSubTipo/findSubtipoProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.findSubtipoProductoResponse findSubtipoProducto(WSFAlimentos.SWSubTipo.findSubtipoProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findSubtipoProductoRequest", ReplyAction="http://service/WSSubTipo/findSubtipoProductoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findSubtipoProductoResponse> findSubtipoProductoAsync(WSFAlimentos.SWSubTipo.findSubtipoProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/createSubTipoRequest", ReplyAction="http://service/WSSubTipo/createSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.createSubTipoResponse createSubTipo(WSFAlimentos.SWSubTipo.createSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/createSubTipoRequest", ReplyAction="http://service/WSSubTipo/createSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.createSubTipoResponse> createSubTipoAsync(WSFAlimentos.SWSubTipo.createSubTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/edioSubTipoRequest", ReplyAction="http://service/WSSubTipo/edioSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.edioSubTipoResponse edioSubTipo(WSFAlimentos.SWSubTipo.edioSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/edioSubTipoRequest", ReplyAction="http://service/WSSubTipo/edioSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.edioSubTipoResponse> edioSubTipoAsync(WSFAlimentos.SWSubTipo.edioSubTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/removoSubTipoRequest", ReplyAction="http://service/WSSubTipo/removoSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.removoSubTipoResponse removoSubTipo(WSFAlimentos.SWSubTipo.removoSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/removoSubTipoRequest", ReplyAction="http://service/WSSubTipo/removoSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.removoSubTipoResponse> removoSubTipoAsync(WSFAlimentos.SWSubTipo.removoSubTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findAllSubTipoRequest", ReplyAction="http://service/WSSubTipo/findAllSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.findAllSubTipoResponse findAllSubTipo(WSFAlimentos.SWSubTipo.findAllSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findAllSubTipoRequest", ReplyAction="http://service/WSSubTipo/findAllSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findAllSubTipoResponse> findAllSubTipoAsync(WSFAlimentos.SWSubTipo.findAllSubTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findRangeSubTipoRequest", ReplyAction="http://service/WSSubTipo/findRangeSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.findRangeSubTipoResponse findRangeSubTipo(WSFAlimentos.SWSubTipo.findRangeSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/findRangeSubTipoRequest", ReplyAction="http://service/WSSubTipo/findRangeSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findRangeSubTipoResponse> findRangeSubTipoAsync(WSFAlimentos.SWSubTipo.findRangeSubTipoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/countSubTipoRequest", ReplyAction="http://service/WSSubTipo/countSubTipoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WSFAlimentos.SWSubTipo.countSubTipoResponse countSubTipo(WSFAlimentos.SWSubTipo.countSubTipoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://service/WSSubTipo/countSubTipoRequest", ReplyAction="http://service/WSSubTipo/countSubTipoResponse")]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.countSubTipoResponse> countSubTipoAsync(WSFAlimentos.SWSubTipo.countSubTipoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service/")]
    public partial class subtipoProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string descripcionStpField;
        
        private subtipoProductoPK subtipoProductoPKField;
        
        private tipoProducto tipoProductoField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string descripcionStp {
            get {
                return this.descripcionStpField;
            }
            set {
                this.descripcionStpField = value;
                this.RaisePropertyChanged("descripcionStp");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public subtipoProductoPK subtipoProductoPK {
            get {
                return this.subtipoProductoPKField;
            }
            set {
                this.subtipoProductoPKField = value;
                this.RaisePropertyChanged("subtipoProductoPK");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public tipoProducto tipoProducto {
            get {
                return this.tipoProductoField;
            }
            set {
                this.tipoProductoField = value;
                this.RaisePropertyChanged("tipoProducto");
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3221.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service/")]
    public partial class subtipoProductoPK : object, System.ComponentModel.INotifyPropertyChanged {
        
        private short subtipoPField;
        
        private short tipoProductoIdTpField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public short subtipoP {
            get {
                return this.subtipoPField;
            }
            set {
                this.subtipoPField = value;
                this.RaisePropertyChanged("subtipoP");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public short tipoProductoIdTp {
            get {
                return this.tipoProductoIdTpField;
            }
            set {
                this.tipoProductoIdTpField = value;
                this.RaisePropertyChanged("tipoProductoIdTp");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="findSubtipoProducto", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findSubtipoProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public findSubtipoProductoRequest() {
        }
        
        public findSubtipoProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findSubtipoProductoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findSubtipoProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto @return;
        
        public findSubtipoProductoResponse() {
        }
        
        public findSubtipoProductoResponse(WSFAlimentos.SWSubTipo.subtipoProducto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class createSubTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto entity;
        
        public createSubTipoRequest() {
        }
        
        public createSubTipoRequest(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class createSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public createSubTipoResponse() {
        }
        
        public createSubTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edioSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class edioSubTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto entity;
        
        public edioSubTipoRequest() {
        }
        
        public edioSubTipoRequest(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edioSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class edioSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public edioSubTipoResponse() {
        }
        
        public edioSubTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removoSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class removoSubTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto entity;
        
        public removoSubTipoRequest() {
        }
        
        public removoSubTipoRequest(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            this.entity = entity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removoSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class removoSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public removoSubTipoResponse() {
        }
        
        public removoSubTipoResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAllSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findAllSubTipoRequest {
        
        public findAllSubTipoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findAllSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findAllSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto[] @return;
        
        public findAllSubTipoResponse() {
        }
        
        public findAllSubTipoResponse(WSFAlimentos.SWSubTipo.subtipoProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findRangeSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findRangeSubTipoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("range", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Nullable<int>[] range;
        
        public findRangeSubTipoRequest() {
        }
        
        public findRangeSubTipoRequest(System.Nullable<int>[] range) {
            this.range = range;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="findRangeSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class findRangeSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WSFAlimentos.SWSubTipo.subtipoProducto[] @return;
        
        public findRangeSubTipoResponse() {
        }
        
        public findRangeSubTipoResponse(WSFAlimentos.SWSubTipo.subtipoProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="countSubTipo", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class countSubTipoRequest {
        
        public countSubTipoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="countSubTipoResponse", WrapperNamespace="http://service/", IsWrapped=true)]
    public partial class countSubTipoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public countSubTipoResponse() {
        }
        
        public countSubTipoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSSubTipoChannel : WSFAlimentos.SWSubTipo.WSSubTipo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSSubTipoClient : System.ServiceModel.ClientBase<WSFAlimentos.SWSubTipo.WSSubTipo>, WSFAlimentos.SWSubTipo.WSSubTipo {
        
        public WSSubTipoClient() {
        }
        
        public WSSubTipoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSSubTipoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSubTipoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSSubTipoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.findSubtipoProductoResponse WSFAlimentos.SWSubTipo.WSSubTipo.findSubtipoProducto(WSFAlimentos.SWSubTipo.findSubtipoProductoRequest request) {
            return base.Channel.findSubtipoProducto(request);
        }
        
        public WSFAlimentos.SWSubTipo.subtipoProducto findSubtipoProducto(int id) {
            WSFAlimentos.SWSubTipo.findSubtipoProductoRequest inValue = new WSFAlimentos.SWSubTipo.findSubtipoProductoRequest();
            inValue.id = id;
            WSFAlimentos.SWSubTipo.findSubtipoProductoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findSubtipoProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findSubtipoProductoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.findSubtipoProductoAsync(WSFAlimentos.SWSubTipo.findSubtipoProductoRequest request) {
            return base.Channel.findSubtipoProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findSubtipoProductoResponse> findSubtipoProductoAsync(int id) {
            WSFAlimentos.SWSubTipo.findSubtipoProductoRequest inValue = new WSFAlimentos.SWSubTipo.findSubtipoProductoRequest();
            inValue.id = id;
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findSubtipoProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.createSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.createSubTipo(WSFAlimentos.SWSubTipo.createSubTipoRequest request) {
            return base.Channel.createSubTipo(request);
        }
        
        public bool createSubTipo(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.createSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.createSubTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWSubTipo.createSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).createSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.createSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.createSubTipoAsync(WSFAlimentos.SWSubTipo.createSubTipoRequest request) {
            return base.Channel.createSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.createSubTipoResponse> createSubTipoAsync(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.createSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.createSubTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).createSubTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.edioSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.edioSubTipo(WSFAlimentos.SWSubTipo.edioSubTipoRequest request) {
            return base.Channel.edioSubTipo(request);
        }
        
        public bool edioSubTipo(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.edioSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.edioSubTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWSubTipo.edioSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).edioSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.edioSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.edioSubTipoAsync(WSFAlimentos.SWSubTipo.edioSubTipoRequest request) {
            return base.Channel.edioSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.edioSubTipoResponse> edioSubTipoAsync(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.edioSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.edioSubTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).edioSubTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.removoSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.removoSubTipo(WSFAlimentos.SWSubTipo.removoSubTipoRequest request) {
            return base.Channel.removoSubTipo(request);
        }
        
        public bool removoSubTipo(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.removoSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.removoSubTipoRequest();
            inValue.entity = entity;
            WSFAlimentos.SWSubTipo.removoSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).removoSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.removoSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.removoSubTipoAsync(WSFAlimentos.SWSubTipo.removoSubTipoRequest request) {
            return base.Channel.removoSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.removoSubTipoResponse> removoSubTipoAsync(WSFAlimentos.SWSubTipo.subtipoProducto entity) {
            WSFAlimentos.SWSubTipo.removoSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.removoSubTipoRequest();
            inValue.entity = entity;
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).removoSubTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.findAllSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.findAllSubTipo(WSFAlimentos.SWSubTipo.findAllSubTipoRequest request) {
            return base.Channel.findAllSubTipo(request);
        }
        
        public WSFAlimentos.SWSubTipo.subtipoProducto[] findAllSubTipo() {
            WSFAlimentos.SWSubTipo.findAllSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.findAllSubTipoRequest();
            WSFAlimentos.SWSubTipo.findAllSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findAllSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findAllSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.findAllSubTipoAsync(WSFAlimentos.SWSubTipo.findAllSubTipoRequest request) {
            return base.Channel.findAllSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findAllSubTipoResponse> findAllSubTipoAsync() {
            WSFAlimentos.SWSubTipo.findAllSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.findAllSubTipoRequest();
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findAllSubTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.findRangeSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.findRangeSubTipo(WSFAlimentos.SWSubTipo.findRangeSubTipoRequest request) {
            return base.Channel.findRangeSubTipo(request);
        }
        
        public WSFAlimentos.SWSubTipo.subtipoProducto[] findRangeSubTipo(System.Nullable<int>[] range) {
            WSFAlimentos.SWSubTipo.findRangeSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.findRangeSubTipoRequest();
            inValue.range = range;
            WSFAlimentos.SWSubTipo.findRangeSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findRangeSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findRangeSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.findRangeSubTipoAsync(WSFAlimentos.SWSubTipo.findRangeSubTipoRequest request) {
            return base.Channel.findRangeSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.findRangeSubTipoResponse> findRangeSubTipoAsync(System.Nullable<int>[] range) {
            WSFAlimentos.SWSubTipo.findRangeSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.findRangeSubTipoRequest();
            inValue.range = range;
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).findRangeSubTipoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSFAlimentos.SWSubTipo.countSubTipoResponse WSFAlimentos.SWSubTipo.WSSubTipo.countSubTipo(WSFAlimentos.SWSubTipo.countSubTipoRequest request) {
            return base.Channel.countSubTipo(request);
        }
        
        public int countSubTipo() {
            WSFAlimentos.SWSubTipo.countSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.countSubTipoRequest();
            WSFAlimentos.SWSubTipo.countSubTipoResponse retVal = ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).countSubTipo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.countSubTipoResponse> WSFAlimentos.SWSubTipo.WSSubTipo.countSubTipoAsync(WSFAlimentos.SWSubTipo.countSubTipoRequest request) {
            return base.Channel.countSubTipoAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSFAlimentos.SWSubTipo.countSubTipoResponse> countSubTipoAsync() {
            WSFAlimentos.SWSubTipo.countSubTipoRequest inValue = new WSFAlimentos.SWSubTipo.countSubTipoRequest();
            return ((WSFAlimentos.SWSubTipo.WSSubTipo)(this)).countSubTipoAsync(inValue);
        }
    }
}