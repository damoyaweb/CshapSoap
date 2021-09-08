using System;
using ServiceReference1;
using Callejero;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {

            consumirWebServiceHello("Diego & Moya");
            obtenerMunicipios("ALACANT", "ALACANT");
        }

        private static void obtenerMunicipios(string Provincia, string Municipio)
        {
            CallejerodelasedeelectrónicadelcatastroSoapClient soapClient = new CallejerodelasedeelectrónicadelcatastroSoapClient();
            
        }

        private static void consumirWebServiceHello(string name)
        {
            HelloEndpointClient client = new HelloEndpointClient();

            helloRequest request = new helloRequest { Name = name };
            SayHelloBody body = new SayHelloBody(request);
            SayHello sayHello = new SayHello { Body = body };

            SayHelloResponse response = client.SayHello(sayHello);

            Console.WriteLine(response.Body.HelloResponse.Message);

        }
    }
}
