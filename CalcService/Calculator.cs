using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcService
{
    public class Calculator : ICalculator
    {
        public double Add(double op1, double op2)
        {
            return op1 + op2;
        }

        public double Mul(double op1, double op2)
        {
            return op1 * op2;
        }
    }
}
