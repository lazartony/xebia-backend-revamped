using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calculator
    {
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Diff(double n1, double n2)
        {
            return n1 - n2;
        }
        public double Mul(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Avg(double n1, double n2)
        {
            return (n1 + n2)/2;
        }
    }
}
