//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PUCPSaludable.IndicadorSaludWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", ConfigurationName="IndicadorSaludWS.IndicadorSaludService")]
    public interface IndicadorSaludService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/insertarIndicador" +
            "SaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/insertarIndicador" +
            "SaludResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse insertarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/insertarIndicador" +
            "SaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/insertarIndicador" +
            "SaludResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse> insertarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/modificarIndicado" +
            "rSaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/modificarIndicado" +
            "rSaludResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse modificarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/modificarIndicado" +
            "rSaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/modificarIndicado" +
            "rSaludResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse> modificarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/adquirirIndicador" +
            "SaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/adquirirIndicador" +
            "SaludResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse adquirirIndicadorSalud(PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/adquirirIndicador" +
            "SaludRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/IndicadorSaludService/adquirirIndicador" +
            "SaludResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse> adquirirIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/")]
    public partial class indicadorSalud : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool alcoholField;
        
        private string alergiasMedField;
        
        private bool analgesicosField;
        
        private bool antiacidosField;
        
        private bool anticonceptivosOralesField;
        
        private bool cafeField;
        
        private bool celiaquiaField;
        
        private string cirugiasPreviasField;
        
        private bool climaterioField;
        
        private bool colitisField;
        
        private bool dentaduraField;
        
        private bool diarreaField;
        
        private bool diureticosField;
        
        private bool embarazoField;
        
        private bool estrenimientoField;
        
        private int fid_alumnoField;
        
        private bool gastritisField;
        
        private bool laxantesField;
        
        private bool nauseaField;
        
        private bool pirosisField;
        
        private bool sensibilidadDentalField;
        
        private bool tabacoField;
        
        private bool terapiaHormonalField;
        
        private bool ulceraField;
        
        private bool vomitoField;
        
        private bool aFCancerField;
        
        private bool aFDiabetesField;
        
        private bool aFHTAField;
        
        private bool aFHipercolesterolemiaField;
        
        private bool aFHipertrigliceridemiaField;
        
        private bool aFObesidadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool alcohol {
            get {
                return this.alcoholField;
            }
            set {
                this.alcoholField = value;
                this.RaisePropertyChanged("alcohol");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string alergiasMed {
            get {
                return this.alergiasMedField;
            }
            set {
                this.alergiasMedField = value;
                this.RaisePropertyChanged("alergiasMed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool analgesicos {
            get {
                return this.analgesicosField;
            }
            set {
                this.analgesicosField = value;
                this.RaisePropertyChanged("analgesicos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool antiacidos {
            get {
                return this.antiacidosField;
            }
            set {
                this.antiacidosField = value;
                this.RaisePropertyChanged("antiacidos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public bool anticonceptivosOrales {
            get {
                return this.anticonceptivosOralesField;
            }
            set {
                this.anticonceptivosOralesField = value;
                this.RaisePropertyChanged("anticonceptivosOrales");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public bool cafe {
            get {
                return this.cafeField;
            }
            set {
                this.cafeField = value;
                this.RaisePropertyChanged("cafe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public bool celiaquia {
            get {
                return this.celiaquiaField;
            }
            set {
                this.celiaquiaField = value;
                this.RaisePropertyChanged("celiaquia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string cirugiasPrevias {
            get {
                return this.cirugiasPreviasField;
            }
            set {
                this.cirugiasPreviasField = value;
                this.RaisePropertyChanged("cirugiasPrevias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public bool climaterio {
            get {
                return this.climaterioField;
            }
            set {
                this.climaterioField = value;
                this.RaisePropertyChanged("climaterio");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public bool colitis {
            get {
                return this.colitisField;
            }
            set {
                this.colitisField = value;
                this.RaisePropertyChanged("colitis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public bool dentadura {
            get {
                return this.dentaduraField;
            }
            set {
                this.dentaduraField = value;
                this.RaisePropertyChanged("dentadura");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public bool diarrea {
            get {
                return this.diarreaField;
            }
            set {
                this.diarreaField = value;
                this.RaisePropertyChanged("diarrea");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=12)]
        public bool diureticos {
            get {
                return this.diureticosField;
            }
            set {
                this.diureticosField = value;
                this.RaisePropertyChanged("diureticos");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=13)]
        public bool embarazo {
            get {
                return this.embarazoField;
            }
            set {
                this.embarazoField = value;
                this.RaisePropertyChanged("embarazo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=14)]
        public bool estrenimiento {
            get {
                return this.estrenimientoField;
            }
            set {
                this.estrenimientoField = value;
                this.RaisePropertyChanged("estrenimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=15)]
        public int fid_alumno {
            get {
                return this.fid_alumnoField;
            }
            set {
                this.fid_alumnoField = value;
                this.RaisePropertyChanged("fid_alumno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=16)]
        public bool gastritis {
            get {
                return this.gastritisField;
            }
            set {
                this.gastritisField = value;
                this.RaisePropertyChanged("gastritis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=17)]
        public bool laxantes {
            get {
                return this.laxantesField;
            }
            set {
                this.laxantesField = value;
                this.RaisePropertyChanged("laxantes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=18)]
        public bool nausea {
            get {
                return this.nauseaField;
            }
            set {
                this.nauseaField = value;
                this.RaisePropertyChanged("nausea");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=19)]
        public bool pirosis {
            get {
                return this.pirosisField;
            }
            set {
                this.pirosisField = value;
                this.RaisePropertyChanged("pirosis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=20)]
        public bool sensibilidadDental {
            get {
                return this.sensibilidadDentalField;
            }
            set {
                this.sensibilidadDentalField = value;
                this.RaisePropertyChanged("sensibilidadDental");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=21)]
        public bool tabaco {
            get {
                return this.tabacoField;
            }
            set {
                this.tabacoField = value;
                this.RaisePropertyChanged("tabaco");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=22)]
        public bool terapiaHormonal {
            get {
                return this.terapiaHormonalField;
            }
            set {
                this.terapiaHormonalField = value;
                this.RaisePropertyChanged("terapiaHormonal");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=23)]
        public bool ulcera {
            get {
                return this.ulceraField;
            }
            set {
                this.ulceraField = value;
                this.RaisePropertyChanged("ulcera");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=24)]
        public bool vomito {
            get {
                return this.vomitoField;
            }
            set {
                this.vomitoField = value;
                this.RaisePropertyChanged("vomito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=25)]
        public bool aFCancer {
            get {
                return this.aFCancerField;
            }
            set {
                this.aFCancerField = value;
                this.RaisePropertyChanged("aFCancer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=26)]
        public bool aFDiabetes {
            get {
                return this.aFDiabetesField;
            }
            set {
                this.aFDiabetesField = value;
                this.RaisePropertyChanged("aFDiabetes");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=27)]
        public bool aFHTA {
            get {
                return this.aFHTAField;
            }
            set {
                this.aFHTAField = value;
                this.RaisePropertyChanged("aFHTA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=28)]
        public bool aFHipercolesterolemia {
            get {
                return this.aFHipercolesterolemiaField;
            }
            set {
                this.aFHipercolesterolemiaField = value;
                this.RaisePropertyChanged("aFHipercolesterolemia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=29)]
        public bool aFHipertrigliceridemia {
            get {
                return this.aFHipertrigliceridemiaField;
            }
            set {
                this.aFHipertrigliceridemiaField = value;
                this.RaisePropertyChanged("aFHipertrigliceridemia");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=30)]
        public bool aFObesidad {
            get {
                return this.aFObesidadField;
            }
            set {
                this.aFObesidadField = value;
                this.RaisePropertyChanged("aFObesidad");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarIndicadorSalud", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarIndicadorSaludRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud;
        
        public insertarIndicadorSaludRequest() {
        }
        
        public insertarIndicadorSaludRequest(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            this.indicadorSalud = indicadorSalud;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="insertarIndicadorSaludResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class insertarIndicadorSaludResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public insertarIndicadorSaludResponse() {
        }
        
        public insertarIndicadorSaludResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarIndicadorSalud", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarIndicadorSaludRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud;
        
        public modificarIndicadorSaludRequest() {
        }
        
        public modificarIndicadorSaludRequest(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            this.indicadorSalud = indicadorSalud;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarIndicadorSaludResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class modificarIndicadorSaludResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public modificarIndicadorSaludResponse() {
        }
        
        public modificarIndicadorSaludResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="adquirirIndicadorSalud", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class adquirirIndicadorSaludRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int name;
        
        public adquirirIndicadorSaludRequest() {
        }
        
        public adquirirIndicadorSaludRequest(int name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="adquirirIndicadorSaludResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class adquirirIndicadorSaludResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PUCPSaludable.IndicadorSaludWS.indicadorSalud @return;
        
        public adquirirIndicadorSaludResponse() {
        }
        
        public adquirirIndicadorSaludResponse(PUCPSaludable.IndicadorSaludWS.indicadorSalud @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IndicadorSaludServiceChannel : PUCPSaludable.IndicadorSaludWS.IndicadorSaludService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IndicadorSaludServiceClient : System.ServiceModel.ClientBase<PUCPSaludable.IndicadorSaludWS.IndicadorSaludService>, PUCPSaludable.IndicadorSaludWS.IndicadorSaludService {
        
        public IndicadorSaludServiceClient() {
        }
        
        public IndicadorSaludServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IndicadorSaludServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndicadorSaludServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IndicadorSaludServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.insertarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest request) {
            return base.Channel.insertarIndicadorSalud(request);
        }
        
        public int insertarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest();
            inValue.indicadorSalud = indicadorSalud;
            PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse retVal = ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).insertarIndicadorSalud(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse> PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.insertarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest request) {
            return base.Channel.insertarIndicadorSaludAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludResponse> insertarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.insertarIndicadorSaludRequest();
            inValue.indicadorSalud = indicadorSalud;
            return ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).insertarIndicadorSaludAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.modificarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest request) {
            return base.Channel.modificarIndicadorSalud(request);
        }
        
        public int modificarIndicadorSalud(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest();
            inValue.indicadorSalud = indicadorSalud;
            PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse retVal = ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).modificarIndicadorSalud(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse> PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.modificarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest request) {
            return base.Channel.modificarIndicadorSaludAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludResponse> modificarIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.indicadorSalud indicadorSalud) {
            PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.modificarIndicadorSaludRequest();
            inValue.indicadorSalud = indicadorSalud;
            return ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).modificarIndicadorSaludAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.adquirirIndicadorSalud(PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest request) {
            return base.Channel.adquirirIndicadorSalud(request);
        }
        
        public PUCPSaludable.IndicadorSaludWS.indicadorSalud adquirirIndicadorSalud(int name) {
            PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest();
            inValue.name = name;
            PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse retVal = ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).adquirirIndicadorSalud(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse> PUCPSaludable.IndicadorSaludWS.IndicadorSaludService.adquirirIndicadorSaludAsync(PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest request) {
            return base.Channel.adquirirIndicadorSaludAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludResponse> adquirirIndicadorSaludAsync(int name) {
            PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest inValue = new PUCPSaludable.IndicadorSaludWS.adquirirIndicadorSaludRequest();
            inValue.name = name;
            return ((PUCPSaludable.IndicadorSaludWS.IndicadorSaludService)(this)).adquirirIndicadorSaludAsync(inValue);
        }
    }
}
