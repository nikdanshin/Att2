using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ToolsDoubleArr
    {
        public double[] Arr { get; set; }
        public ToolsDoubleArr(double[] arr)
        {
            Arr = arr;
        }
        public int GetIndexNearR(double R)
        {
            int index = 0;
            double Dif = double.MaxValue;
            double NewDif = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                NewDif = GetDif(R, Arr[i]);
                if (NewDif < Dif)
                {
                    Dif = NewDif;
                    index = i;
                }
            }
            return index;
        }
        private double GetDif(double a, double b)
        {
            return Math.Abs(a - b);
        }
    }
}
