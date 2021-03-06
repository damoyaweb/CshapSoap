//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Callejero
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.ServiceContractAttribute(Name="Callejero de la sede electrónica del catastro.Soap", Namespace="http://tempuri.org/OVCServWeb/OVCCallejero", ConfigurationName="Callejero.CallejerodelasedeelectrónicadelcatastroSoap")]
    public interface CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPRC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.Consulta_DNPRCResponse Consulta_DNPRC(Callejero.Consulta_DNPRCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPRC", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.Consulta_DNPRCResponse> Consulta_DNPRCAsync(Callejero.Consulta_DNPRCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaProvincia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.ConsultaProvincia1 ObtenerProvincias(Callejero.ConsultaProvincia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaProvincia", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.ConsultaProvincia1> ObtenerProvinciasAsync(Callejero.ConsultaProvincia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaMunicipio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.ConsultaMunicipio1 ObtenerMunicipios(Callejero.ConsultaMunicipio request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaMunicipio", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.ConsultaMunicipio1> ObtenerMunicipiosAsync(Callejero.ConsultaMunicipio request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaVia", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.ConsultaVia1 ObtenerCallejero(Callejero.ConsultaVia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaVia", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.ConsultaVia1> ObtenerCallejeroAsync(Callejero.ConsultaVia request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaNumero", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.ConsultaNumero1 ObtenerNumerero(Callejero.ConsultaNumero request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/ConsultaNumero", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.ConsultaNumero1> ObtenerNumereroAsync(Callejero.ConsultaNumero request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPLOC", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.Consulta_DNPLOCResponse Consulta_DNPLOC(Callejero.Consulta_DNPLOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPLOC", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(Callejero.Consulta_DNPLOCRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPPP", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Callejero.Consulta_DNPPPResponse Consulta_DNPPP(Callejero.Consulta_DNPPPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OVCServWeb/OVCCallejero/Consulta_DNPPP", ReplyAction="*")]
        System.Threading.Tasks.Task<Callejero.Consulta_DNPPPResponse> Consulta_DNPPPAsync(Callejero.Consulta_DNPPPRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string RefCat;
        
        public Consulta_DNPRCRequest()
        {
        }
        
        public Consulta_DNPRCRequest(string Provincia, string Municipio, string RefCat)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.RefCat = RefCat;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPRCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNP;
        
        public Consulta_DNPRCResponse()
        {
        }
        
        public Consulta_DNPRCResponse(System.Xml.XmlNode Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia
    {
        
        public ConsultaProvincia()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaProvincia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Provincias;
        
        public ConsultaProvincia1()
        {
        }
        
        public ConsultaProvincia1(System.Xml.XmlNode Provincias)
        {
            this.Provincias = Provincias;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        public ConsultaMunicipio()
        {
        }
        
        public ConsultaMunicipio(string Provincia, string Municipio)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaMunicipio1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Municipios;
        
        public ConsultaMunicipio1()
        {
        }
        
        public ConsultaMunicipio1(System.Xml.XmlNode Municipios)
        {
            this.Municipios = Municipios;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NombreVia;
        
        public ConsultaVia()
        {
        }
        
        public ConsultaVia(string Provincia, string Municipio, string TipoVia, string NombreVia)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NombreVia = NombreVia;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaVia1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Callejero;
        
        public ConsultaVia1()
        {
        }
        
        public ConsultaVia1(System.Xml.XmlNode Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string TipoVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string NomVia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        public ConsultaNumero()
        {
        }
        
        public ConsultaNumero(string Provincia, string Municipio, string TipoVia, string NomVia, string Numero)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.TipoVia = TipoVia;
            this.NomVia = NomVia;
            this.Numero = Numero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaNumero1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Callejero;
        
        public ConsultaNumero1()
        {
        }
        
        public ConsultaNumero1(System.Xml.XmlNode Callejero)
        {
            this.Callejero = Callejero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Sigla;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Calle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=4)]
        public string Numero;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=5)]
        public string Bloque;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=6)]
        public string Escalera;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=7)]
        public string Planta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=8)]
        public string Puerta;
        
        public Consulta_DNPLOCRequest()
        {
        }
        
        public Consulta_DNPLOCRequest(string Provincia, string Municipio, string Sigla, string Calle, string Numero, string Bloque, string Escalera, string Planta, string Puerta)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Sigla = Sigla;
            this.Calle = Calle;
            this.Numero = Numero;
            this.Bloque = Bloque;
            this.Escalera = Escalera;
            this.Planta = Planta;
            this.Puerta = Puerta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPLOCResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNP;
        
        public Consulta_DNPLOCResponse()
        {
        }
        
        public Consulta_DNPLOCResponse(System.Xml.XmlNode Consulta_DNP)
        {
            this.Consulta_DNP = Consulta_DNP;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public string Provincia;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=1)]
        public string Municipio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=2)]
        public string Poligono;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=3)]
        public string Parcela;
        
        public Consulta_DNPPPRequest()
        {
        }
        
        public Consulta_DNPPPRequest(string Provincia, string Municipio, string Poligono, string Parcela)
        {
            this.Provincia = Provincia;
            this.Municipio = Municipio;
            this.Poligono = Poligono;
            this.Parcela = Parcela;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Consulta_DNPPPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.catastro.meh.es/", Order=0)]
        public System.Xml.XmlNode Consulta_DNPPP;
        
        public Consulta_DNPPPResponse()
        {
        }
        
        public Consulta_DNPPPResponse(System.Xml.XmlNode Consulta_DNPPP)
        {
            this.Consulta_DNPPP = Consulta_DNPPP;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public interface CallejerodelasedeelectrónicadelcatastroSoapChannel : Callejero.CallejerodelasedeelectrónicadelcatastroSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3-preview3.21351.2")]
    public partial class CallejerodelasedeelectrónicadelcatastroSoapClient : System.ServiceModel.ClientBase<Callejero.CallejerodelasedeelectrónicadelcatastroSoap>, Callejero.CallejerodelasedeelectrónicadelcatastroSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient() : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetDefaultBinding(), CallejerodelasedeelectrónicadelcatastroSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), CallejerodelasedeelectrónicadelcatastroSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CallejerodelasedeelectrónicadelcatastroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public Callejero.Consulta_DNPRCResponse Consulta_DNPRC(Callejero.Consulta_DNPRCRequest request)
        {
            return base.Channel.Consulta_DNPRC(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.Consulta_DNPRCResponse> Consulta_DNPRCAsync(Callejero.Consulta_DNPRCRequest request)
        {
            return base.Channel.Consulta_DNPRCAsync(request);
        }
        
        public Callejero.ConsultaProvincia1 ObtenerProvincias(Callejero.ConsultaProvincia request)
        {
            return base.Channel.ObtenerProvincias(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.ConsultaProvincia1> ObtenerProvinciasAsync(Callejero.ConsultaProvincia request)
        {
            return base.Channel.ObtenerProvinciasAsync(request);
        }
        
        public Callejero.ConsultaMunicipio1 ObtenerMunicipios(Callejero.ConsultaMunicipio request)
        {
            return base.Channel.ObtenerMunicipios(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.ConsultaMunicipio1> ObtenerMunicipiosAsync(Callejero.ConsultaMunicipio request)
        {
            return base.Channel.ObtenerMunicipiosAsync(request);
        }
        
        public Callejero.ConsultaVia1 ObtenerCallejero(Callejero.ConsultaVia request)
        {
            return base.Channel.ObtenerCallejero(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.ConsultaVia1> ObtenerCallejeroAsync(Callejero.ConsultaVia request)
        {
            return base.Channel.ObtenerCallejeroAsync(request);
        }
        
        public Callejero.ConsultaNumero1 ObtenerNumerero(Callejero.ConsultaNumero request)
        {
            return base.Channel.ObtenerNumerero(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.ConsultaNumero1> ObtenerNumereroAsync(Callejero.ConsultaNumero request)
        {
            return base.Channel.ObtenerNumereroAsync(request);
        }
        
        public Callejero.Consulta_DNPLOCResponse Consulta_DNPLOC(Callejero.Consulta_DNPLOCRequest request)
        {
            return base.Channel.Consulta_DNPLOC(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.Consulta_DNPLOCResponse> Consulta_DNPLOCAsync(Callejero.Consulta_DNPLOCRequest request)
        {
            return base.Channel.Consulta_DNPLOCAsync(request);
        }
        
        public Callejero.Consulta_DNPPPResponse Consulta_DNPPP(Callejero.Consulta_DNPPPRequest request)
        {
            return base.Channel.Consulta_DNPPP(request);
        }
        
        public System.Threading.Tasks.Task<Callejero.Consulta_DNPPPResponse> Consulta_DNPPPAsync(Callejero.Consulta_DNPPPRequest request)
        {
            return base.Channel.Consulta_DNPPPAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap))
            {
                return new System.ServiceModel.EndpointAddress("http://ovc.catastro.meh.es/ovcservweb/OVCSWLocalizacionRC/OVCCallejero.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CallejerodelasedeelectrónicadelcatastroSoapClient.GetBindingForEndpoint(EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CallejerodelasedeelectrónicadelcatastroSoapClient.GetEndpointAddress(EndpointConfiguration.Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
        }
        
        public enum EndpointConfiguration
        {
            
            Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap,
        }
    }
}
