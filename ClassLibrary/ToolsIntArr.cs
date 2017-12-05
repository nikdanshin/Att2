using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ToolsIntArr
    {
        public int[] Arr { get; set; }
        public ToolsIntArr(int[] arr)
        {
            Arr = arr;
        }
        public int GetCountNotZero()
        {
            int count = 0;
            for (int i = Array.IndexOf(Arr,0)+1; i < Array.LastIndexOf(Arr,0); i++)
            {
                if(Arr[i] != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
