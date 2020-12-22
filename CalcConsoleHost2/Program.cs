using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalcConsoleHost2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(CalcService.Calculator));
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
