//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PUCPSaludable.HorarioCitaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", ConfigurationName="HorarioCitaWS.HorarioCitasService")]
    public interface HorarioCitasService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/listarPorEspecReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/listarPorEspecRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.HorarioCitaWS.listarPorEspecResponse listarPorEspec(PUCPSaludable.HorarioCitaWS.listarPorEspecRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/listarPorEspecReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/listarPorEspecRespo" +
            "nse")]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.listarPorEspecResponse> listarPorEspecAsync(PUCPSaludable.HorarioCitaWS.listarPorEspecRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/insertarRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/insertarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.HorarioCitaWS.insertarResponse insertar(PUCPSaludable.HorarioCitaWS.insertarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/insertarRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/insertarResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.insertarResponse> insertarAsync(PUCPSaludable.HorarioCitaWS.insertarRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/eliminarHorariosAnt" +
            "erioresRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/eliminarHorariosAnt" +
            "erioresResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse eliminarHorariosAnteriores(PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/eliminarHorariosAnt" +
            "erioresRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/HorarioCitasService/eliminarHorariosAnt" +
            "erioresResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse> eliminarHorariosAnterioresAsync(PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/")]
    public partial class horario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int diaSemanaField;
        
        private int estadoField;
        
        private System.DateTime fechaHoraRegistroField;
        
        private bool fechaHoraRegistroFieldSpecified;
        
        private int fid_especialistaField;
        
        private System.DateTime horaFinField;
        
        private bool horaFinFieldSpecified;
        
        private System.DateTime horarioInicioField;
        
        private bool horarioInicioFieldSpecified;
        
        private int id_horarioField;
        
        private int id_tallerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int diaSemana {
            get {
                return this.diaSemanaField;
            }
            set {
                this.diaSemanaField = value;
                this.RaisePropertyChanged("diaSemana");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("estado");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime fechaHoraRegistro {
            get {
                return this.fechaHoraRegistroField;
            }
            set {
                this.fechaHoraRegistroField = value;
                this.RaisePropertyChanged("fechaHoraRegistro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fechaHoraRegistroSpecified {
            get {
                return this.fechaHoraRegistroFieldSpecified;
            }
            set {
                this.fechaHoraRegistroFieldSpecified = value;
                this.RaisePropertyChanged("fechaHoraRegistroSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int fid_especialista {
            get {
                return this.fid_especialistaField;
            }
            set {
                this.fid_especialistaField = value;
                this.RaisePropertyChanged("fid_especialista");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public System.DateTime horaFin {
            get {
                return this.horaFinField;
            }
            set {
                this.horaFinField = value;
                this.RaisePropertyChanged("horaFin");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horaFinSpecified {
            get {
                return this.horaFinFieldSpecified;
            }
            set {
                this.horaFinFieldSpecified = value;
                this.RaisePropertyChanged("horaFinSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime horarioInicio {
            get {
                return this.horarioInicioField;
            }
            set {
                this.horarioInicioField = value;
                this.RaisePropertyChanged("horarioInicio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool horarioInicioSpecified {
            get {
                return this.horarioInicioFieldSpecified;
            }
            set {
                this.horarioInicioFieldSpecified = value;
                this.RaisePropertyChanged("horarioInicioSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int id_horario {
            get {
                return this.id_horarioField;
            }
            set {
                this.id_horarioField = value;
                this.RaisePropertyChanged("id_horario");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int id_taller {
            get {
                return this.id_tallerField;
            }
            set {
                this.id_tallerField = value;
                this.RaisePropertyChanged("id_taller");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPorEspec", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarPorEspecRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public listarPorEspecRequest() {
        }
        
        public listarPorEspecRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarPorEspecResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarPorEspecResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PUCPSaludable.HorarioCitaWS.horario[] @return;
        
        public listarPorEspecResponse() {
        }
        
        public listarPorEspecResponse(PUCPSaludable.HorarioCitaWS.horario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertar", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PUCPSaludable.HorarioCitaWS.horario arg0;
        
        public insertarRequest() {
        }
        
        public insertarRequest(PUCPSaludable.HorarioCitaWS.horario arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarResponse() {
        }
        
        public insertarResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarHorariosAnteriores", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarHorariosAnterioresRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public eliminarHorariosAnterioresRequest() {
        }
        
        public eliminarHorariosAnterioresRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarHorariosAnterioresResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class eliminarHorariosAnterioresResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public eliminarHorariosAnterioresResponse() {
        }
        
        public eliminarHorariosAnterioresResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HorarioCitasServiceChannel : PUCPSaludable.HorarioCitaWS.HorarioCitasService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HorarioCitasServiceClient : System.ServiceModel.ClientBase<PUCPSaludable.HorarioCitaWS.HorarioCitasService>, PUCPSaludable.HorarioCitaWS.HorarioCitasService {
        
        public HorarioCitasServiceClient() {
        }
        
        public HorarioCitasServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HorarioCitasServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HorarioCitasServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HorarioCitasServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.HorarioCitaWS.listarPorEspecResponse PUCPSaludable.HorarioCitaWS.HorarioCitasService.listarPorEspec(PUCPSaludable.HorarioCitaWS.listarPorEspecRequest request) {
            return base.Channel.listarPorEspec(request);
        }
        
        public PUCPSaludable.HorarioCitaWS.horario[] listarPorEspec(int arg0) {
            PUCPSaludable.HorarioCitaWS.listarPorEspecRequest inValue = new PUCPSaludable.HorarioCitaWS.listarPorEspecRequest();
            inValue.arg0 = arg0;
            PUCPSaludable.HorarioCitaWS.listarPorEspecResponse retVal = ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).listarPorEspec(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.listarPorEspecResponse> PUCPSaludable.HorarioCitaWS.HorarioCitasService.listarPorEspecAsync(PUCPSaludable.HorarioCitaWS.listarPorEspecRequest request) {
            return base.Channel.listarPorEspecAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.listarPorEspecResponse> listarPorEspecAsync(int arg0) {
            PUCPSaludable.HorarioCitaWS.listarPorEspecRequest inValue = new PUCPSaludable.HorarioCitaWS.listarPorEspecRequest();
            inValue.arg0 = arg0;
            return ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).listarPorEspecAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.HorarioCitaWS.insertarResponse PUCPSaludable.HorarioCitaWS.HorarioCitasService.insertar(PUCPSaludable.HorarioCitaWS.insertarRequest request) {
            return base.Channel.insertar(request);
        }
        
        public int insertar(PUCPSaludable.HorarioCitaWS.horario arg0) {
            PUCPSaludable.HorarioCitaWS.insertarRequest inValue = new PUCPSaludable.HorarioCitaWS.insertarRequest();
            inValue.arg0 = arg0;
            PUCPSaludable.HorarioCitaWS.insertarResponse retVal = ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).insertar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.insertarResponse> PUCPSaludable.HorarioCitaWS.HorarioCitasService.insertarAsync(PUCPSaludable.HorarioCitaWS.insertarRequest request) {
            return base.Channel.insertarAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.insertarResponse> insertarAsync(PUCPSaludable.HorarioCitaWS.horario arg0) {
            PUCPSaludable.HorarioCitaWS.insertarRequest inValue = new PUCPSaludable.HorarioCitaWS.insertarRequest();
            inValue.arg0 = arg0;
            return ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).insertarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse PUCPSaludable.HorarioCitaWS.HorarioCitasService.eliminarHorariosAnteriores(PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest request) {
            return base.Channel.eliminarHorariosAnteriores(request);
        }
        
        public int eliminarHorariosAnteriores(int arg0) {
            PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest inValue = new PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest();
            inValue.arg0 = arg0;
            PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse retVal = ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).eliminarHorariosAnteriores(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse> PUCPSaludable.HorarioCitaWS.HorarioCitasService.eliminarHorariosAnterioresAsync(PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest request) {
            return base.Channel.eliminarHorariosAnterioresAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresResponse> eliminarHorariosAnterioresAsync(int arg0) {
            PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest inValue = new PUCPSaludable.HorarioCitaWS.eliminarHorariosAnterioresRequest();
            inValue.arg0 = arg0;
            return ((PUCPSaludable.HorarioCitaWS.HorarioCitasService)(this)).eliminarHorariosAnterioresAsync(inValue);
        }
    }
}
