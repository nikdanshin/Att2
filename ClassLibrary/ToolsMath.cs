using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ToolsMath
    {
        public double X { get; set; }
        public double E { get; set; }
        public ToolsMath(double x, double e)
        {
            X = x;
            E = e;
        }
        public double GetLeft()
        {
            return Math.Sqrt(1 + X);
        }
        public double GetRight(out int n)
        {
            n = 0;
            double a = 1;
            double Result = 0;
            while (Math.Abs(a)>E)
            {
                a = An(a, ++n);
                Result += a;
            }
            return Result;
        }
        private double An(double a, int n)
        {
            if(n == 1)
            {
                return 1;
            }
            if(n == 2)
            {
                return a * X / (2 * (n - 1));
            }
            return -a * X * (2 * (n - 2) - 1) / (2 * (n - 1));
        }
    }
}
