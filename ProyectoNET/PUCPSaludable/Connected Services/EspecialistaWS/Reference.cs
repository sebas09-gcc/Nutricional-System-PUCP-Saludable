﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PUCPSaludable.EspecialistaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", ConfigurationName="EspecialistaWS.EspecialistaService")]
    public interface EspecialistaService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/videoEspecialistaPo" +
            "rIDRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/videoEspecialistaPo" +
            "rIDResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse videoEspecialistaPorID(PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/videoEspecialistaPo" +
            "rIDRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/videoEspecialistaPo" +
            "rIDResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse> videoEspecialistaPorIDAsync(PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarVideoRequest" +
            "", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarVideoRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.agregarVideoResponse agregarVideo(PUCPSaludable.EspecialistaWS.agregarVideoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarVideoRequest" +
            "", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarVideoRespons" +
            "e")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarVideoResponse> agregarVideoAsync(PUCPSaludable.EspecialistaWS.agregarVideoRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarVideosRequest" +
            "", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarVideosRespons" +
            "e")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.listarVideosResponse listarVideos(PUCPSaludable.EspecialistaWS.listarVideosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarVideosRequest" +
            "", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarVideosRespons" +
            "e")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarVideosResponse> listarVideosAsync(PUCPSaludable.EspecialistaWS.listarVideosRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarMensajesReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarMensajesRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.listarMensajesResponse listarMensajes(PUCPSaludable.EspecialistaWS.listarMensajesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarMensajesReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/listarMensajesRespo" +
            "nse")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarMensajesResponse> listarMensajesAsync(PUCPSaludable.EspecialistaWS.listarMensajesRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/mensajeEspecialista" +
            "PorIDRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/mensajeEspecialista" +
            "PorIDResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse mensajeEspecialistaPorID(PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/mensajeEspecialista" +
            "PorIDRequest", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/mensajeEspecialista" +
            "PorIDResponse")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse> mensajeEspecialistaPorIDAsync(PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarMensajeReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarMensajeRespo" +
            "nse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PUCPSaludable.EspecialistaWS.agregarMensajeResponse agregarMensaje(PUCPSaludable.EspecialistaWS.agregarMensajeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarMensajeReque" +
            "st", ReplyAction="http://services.pucpsaludable.pucp.edu.pe/EspecialistaService/agregarMensajeRespo" +
            "nse")]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarMensajeResponse> agregarMensajeAsync(PUCPSaludable.EspecialistaWS.agregarMensajeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="videoEspecialistaPorID", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class videoEspecialistaPorIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_especialista;
        
        public videoEspecialistaPorIDRequest() {
        }
        
        public videoEspecialistaPorIDRequest(int id_especialista) {
            this.id_especialista = id_especialista;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="videoEspecialistaPorIDResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class videoEspecialistaPorIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public videoEspecialistaPorIDResponse() {
        }
        
        public videoEspecialistaPorIDResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarVideo", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class agregarVideoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_especialista;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string URL_video;
        
        public agregarVideoRequest() {
        }
        
        public agregarVideoRequest(int id_especialista, string URL_video) {
            this.id_especialista = id_especialista;
            this.URL_video = URL_video;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarVideoResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class agregarVideoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public agregarVideoResponse() {
        }
        
        public agregarVideoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVideos", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarVideosRequest {
        
        public listarVideosRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarVideosResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarVideosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public listarVideosResponse() {
        }
        
        public listarVideosResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarMensajes", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarMensajesRequest {
        
        public listarMensajesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarMensajesResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class listarMensajesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public listarMensajesResponse() {
        }
        
        public listarMensajesResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mensajeEspecialistaPorID", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class mensajeEspecialistaPorIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_especialista;
        
        public mensajeEspecialistaPorIDRequest() {
        }
        
        public mensajeEspecialistaPorIDRequest(int id_especialista) {
            this.id_especialista = id_especialista;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="mensajeEspecialistaPorIDResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class mensajeEspecialistaPorIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public mensajeEspecialistaPorIDResponse() {
        }
        
        public mensajeEspecialistaPorIDResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarMensaje", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class agregarMensajeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id_especialista;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tituloMensaje;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mensajeMensaje;
        
        public agregarMensajeRequest() {
        }
        
        public agregarMensajeRequest(int id_especialista, string tituloMensaje, string mensajeMensaje) {
            this.id_especialista = id_especialista;
            this.tituloMensaje = tituloMensaje;
            this.mensajeMensaje = mensajeMensaje;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarMensajeResponse", WrapperNamespace="http://services.pucpsaludable.pucp.edu.pe/", IsWrapped=true)]
    public partial class agregarMensajeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://services.pucpsaludable.pucp.edu.pe/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public agregarMensajeResponse() {
        }
        
        public agregarMensajeResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EspecialistaServiceChannel : PUCPSaludable.EspecialistaWS.EspecialistaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EspecialistaServiceClient : System.ServiceModel.ClientBase<PUCPSaludable.EspecialistaWS.EspecialistaService>, PUCPSaludable.EspecialistaWS.EspecialistaService {
        
        public EspecialistaServiceClient() {
        }
        
        public EspecialistaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EspecialistaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialistaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EspecialistaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse PUCPSaludable.EspecialistaWS.EspecialistaService.videoEspecialistaPorID(PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest request) {
            return base.Channel.videoEspecialistaPorID(request);
        }
        
        public string[] videoEspecialistaPorID(int id_especialista) {
            PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest inValue = new PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest();
            inValue.id_especialista = id_especialista;
            PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).videoEspecialistaPorID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.videoEspecialistaPorIDAsync(PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest request) {
            return base.Channel.videoEspecialistaPorIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDResponse> videoEspecialistaPorIDAsync(int id_especialista) {
            PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest inValue = new PUCPSaludable.EspecialistaWS.videoEspecialistaPorIDRequest();
            inValue.id_especialista = id_especialista;
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).videoEspecialistaPorIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.agregarVideoResponse PUCPSaludable.EspecialistaWS.EspecialistaService.agregarVideo(PUCPSaludable.EspecialistaWS.agregarVideoRequest request) {
            return base.Channel.agregarVideo(request);
        }
        
        public int agregarVideo(int id_especialista, string URL_video) {
            PUCPSaludable.EspecialistaWS.agregarVideoRequest inValue = new PUCPSaludable.EspecialistaWS.agregarVideoRequest();
            inValue.id_especialista = id_especialista;
            inValue.URL_video = URL_video;
            PUCPSaludable.EspecialistaWS.agregarVideoResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).agregarVideo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarVideoResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.agregarVideoAsync(PUCPSaludable.EspecialistaWS.agregarVideoRequest request) {
            return base.Channel.agregarVideoAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarVideoResponse> agregarVideoAsync(int id_especialista, string URL_video) {
            PUCPSaludable.EspecialistaWS.agregarVideoRequest inValue = new PUCPSaludable.EspecialistaWS.agregarVideoRequest();
            inValue.id_especialista = id_especialista;
            inValue.URL_video = URL_video;
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).agregarVideoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.listarVideosResponse PUCPSaludable.EspecialistaWS.EspecialistaService.listarVideos(PUCPSaludable.EspecialistaWS.listarVideosRequest request) {
            return base.Channel.listarVideos(request);
        }
        
        public string[] listarVideos() {
            PUCPSaludable.EspecialistaWS.listarVideosRequest inValue = new PUCPSaludable.EspecialistaWS.listarVideosRequest();
            PUCPSaludable.EspecialistaWS.listarVideosResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).listarVideos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarVideosResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.listarVideosAsync(PUCPSaludable.EspecialistaWS.listarVideosRequest request) {
            return base.Channel.listarVideosAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarVideosResponse> listarVideosAsync() {
            PUCPSaludable.EspecialistaWS.listarVideosRequest inValue = new PUCPSaludable.EspecialistaWS.listarVideosRequest();
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).listarVideosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.listarMensajesResponse PUCPSaludable.EspecialistaWS.EspecialistaService.listarMensajes(PUCPSaludable.EspecialistaWS.listarMensajesRequest request) {
            return base.Channel.listarMensajes(request);
        }
        
        public string[] listarMensajes() {
            PUCPSaludable.EspecialistaWS.listarMensajesRequest inValue = new PUCPSaludable.EspecialistaWS.listarMensajesRequest();
            PUCPSaludable.EspecialistaWS.listarMensajesResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).listarMensajes(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarMensajesResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.listarMensajesAsync(PUCPSaludable.EspecialistaWS.listarMensajesRequest request) {
            return base.Channel.listarMensajesAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.listarMensajesResponse> listarMensajesAsync() {
            PUCPSaludable.EspecialistaWS.listarMensajesRequest inValue = new PUCPSaludable.EspecialistaWS.listarMensajesRequest();
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).listarMensajesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse PUCPSaludable.EspecialistaWS.EspecialistaService.mensajeEspecialistaPorID(PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest request) {
            return base.Channel.mensajeEspecialistaPorID(request);
        }
        
        public string[] mensajeEspecialistaPorID(int id_especialista) {
            PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest inValue = new PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest();
            inValue.id_especialista = id_especialista;
            PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).mensajeEspecialistaPorID(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.mensajeEspecialistaPorIDAsync(PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest request) {
            return base.Channel.mensajeEspecialistaPorIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDResponse> mensajeEspecialistaPorIDAsync(int id_especialista) {
            PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest inValue = new PUCPSaludable.EspecialistaWS.mensajeEspecialistaPorIDRequest();
            inValue.id_especialista = id_especialista;
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).mensajeEspecialistaPorIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUCPSaludable.EspecialistaWS.agregarMensajeResponse PUCPSaludable.EspecialistaWS.EspecialistaService.agregarMensaje(PUCPSaludable.EspecialistaWS.agregarMensajeRequest request) {
            return base.Channel.agregarMensaje(request);
        }
        
        public int agregarMensaje(int id_especialista, string tituloMensaje, string mensajeMensaje) {
            PUCPSaludable.EspecialistaWS.agregarMensajeRequest inValue = new PUCPSaludable.EspecialistaWS.agregarMensajeRequest();
            inValue.id_especialista = id_especialista;
            inValue.tituloMensaje = tituloMensaje;
            inValue.mensajeMensaje = mensajeMensaje;
            PUCPSaludable.EspecialistaWS.agregarMensajeResponse retVal = ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).agregarMensaje(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarMensajeResponse> PUCPSaludable.EspecialistaWS.EspecialistaService.agregarMensajeAsync(PUCPSaludable.EspecialistaWS.agregarMensajeRequest request) {
            return base.Channel.agregarMensajeAsync(request);
        }
        
        public System.Threading.Tasks.Task<PUCPSaludable.EspecialistaWS.agregarMensajeResponse> agregarMensajeAsync(int id_especialista, string tituloMensaje, string mensajeMensaje) {
            PUCPSaludable.EspecialistaWS.agregarMensajeRequest inValue = new PUCPSaludable.EspecialistaWS.agregarMensajeRequest();
            inValue.id_especialista = id_especialista;
            inValue.tituloMensaje = tituloMensaje;
            inValue.mensajeMensaje = mensajeMensaje;
            return ((PUCPSaludable.EspecialistaWS.EspecialistaService)(this)).agregarMensajeAsync(inValue);
        }
    }
}