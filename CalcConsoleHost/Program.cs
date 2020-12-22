using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using CalcService;

namespace CalcConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpAddr = new Uri("http://localhost:8000/Calculator");
            
            ServiceHost sh = new ServiceHost(typeof(Calculator), httpAddr);

            BasicHttpBinding httpBinding = new BasicHttpBinding();

            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior
            {
                HttpGetEnabled = true,  // To get the metadata via http
                HttpsGetEnabled = true  // To get the metadata via https
            };

            sh.Description.Behaviors.Add(mBehave);

            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            sh.AddServiceEndpoint(typeof(ICalculator), httpBinding, httpAddr);

            sh.Open();
            Console.WriteLine("Caculator service running on : http://localhost:8000/Calculator");
            Console.WriteLine("Goto http://localhost:8000/Calculator?singleWsdl");
            Console.WriteLine("or  http://localhost:8000/Calculator?wsdl");
            Console.WriteLine("to retrieve service metadata/WSDL file.");
            Console.ReadLine();
            sh.Close();
        }
    }
}
