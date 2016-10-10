# gma.dotnet.aplicacaomodelo
Aplicação para demonstrar a minha forma de desenvolvimento em dot net

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using wcfMy;


namespace UiConsole
{
 class Program
 {
  static void Main(string[] args)
  {
    ServiceHost host = new ServiceHost(typeof(MeuServico), new Uri[] { new Uri("http://localhost:57960/gma.svc") });
    host.Open();
   Console.WriteLine("Serviço rodando...");
   Console.WriteLine("Tecle  para finalizar.");
   Console.ReadKey();
    host.Close();
  }
 }
}


<system.serviceModel>
    <behaviors>
      <serviceBehaviors>
        <behavior>
          <!-- To avoid disclosing metadata information, set the values below to false before deployment -->
          <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true"/>
          <!-- To receive exception details in faults for debugging purposes, set the value below to true.  Set to false before deployment to avoid disclosing exception information -->
          <serviceDebug includeExceptionDetailInFaults="false"/>
        </behavior>
      </serviceBehaviors>
    </behaviors>
    <protocolMapping>
      <add binding="basicHttpsBinding" scheme="https" />
    </protocolMapping>
    <serviceHostingEnvironment aspNetCompatibilityEnabled="true" multipleSiteBindingsEnabled="true" />
  </system.serviceModel>
