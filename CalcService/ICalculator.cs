using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcService
{
    [ServiceContract (Namespace = "http://ddu.ac.in/wcf")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double op1, double op2);

        [OperationContract]
        double Mul(double op1, double op2);
    }
}
