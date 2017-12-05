using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ToolsList
    {
        private IList<int> Weights { get; set; }
        private int SumWeight { get; set; }
        private bool CheckInt(int a)
        {
            int sum = 0;
            for (int i = 0; i < Weights.Count; i++)
            {
                if ((a & 1) == 1)
                {
                    sum += Weights[i];
                }
                a = a >> 1;
            }
            if(sum == SumWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private List<int> IntToList(int a)
        {
            List<int> VarList = new List<int>();
            for (int i = 0; i < Weights.Count; i++)
            {
                if ((a & 1) == 1)
                {
                    VarList.Add(Weights[i]);
                }
                a = a >> 1;
            }
            return VarList;
        }
        public List<List<int>> SelectionCount(IList<int> weights, int sumWeight)
        {
            Weights = weights;
            SumWeight = sumWeight;
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < (1 << Weights.Count); i++)
            {
                if (CheckInt(i))
                {
                    list.Add(IntToList(i));
                }
            }
            return list;
        }

    }
}
