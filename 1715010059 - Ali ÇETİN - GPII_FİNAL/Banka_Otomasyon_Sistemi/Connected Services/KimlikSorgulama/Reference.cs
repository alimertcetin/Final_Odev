﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Banka_Otomasyon_Sistemi.KimlikSorgulama {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="KimlikSorgulama.KPSPublicSoap")]
    public interface KPSPublicSoap {
        
        // CODEGEN: Generating message contract since element name Ad from namespace http://tckimlik.nvi.gov.tr/WS is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse TCKimlikNoDogrula(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequestBody Body;
        
        public TCKimlikNoDogrulaRequest() {
        }
        
        public TCKimlikNoDogrulaRequest(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TCKimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int DogumYili;
        
        public TCKimlikNoDogrulaRequestBody() {
        }
        
        public TCKimlikNoDogrulaRequestBody(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponseBody Body;
        
        public TCKimlikNoDogrulaResponse() {
        }
        
        public TCKimlikNoDogrulaResponse(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TCKimlikNoDogrulaResult;
        
        public TCKimlikNoDogrulaResponseBody() {
        }
        
        public TCKimlikNoDogrulaResponseBody(bool TCKimlikNoDogrulaResult) {
            this.TCKimlikNoDogrulaResult = TCKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KPSPublicSoapChannel : Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KPSPublicSoapClient : System.ServiceModel.ClientBase<Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap>, Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap {
        
        public KPSPublicSoapClient() {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap.TCKimlikNoDogrula(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrula(request);
        }
        
        public bool TCKimlikNoDogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest inValue = new Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest();
            inValue.Body = new Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse retVal = ((Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap)(this)).TCKimlikNoDogrula(inValue);
            return retVal.Body.TCKimlikNoDogrulaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse> Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap.TCKimlikNoDogrulaAsync(Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrulaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest inValue = new Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequest();
            inValue.Body = new Banka_Otomasyon_Sistemi.KimlikSorgulama.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            return ((Banka_Otomasyon_Sistemi.KimlikSorgulama.KPSPublicSoap)(this)).TCKimlikNoDogrulaAsync(inValue);
        }
    }
}
