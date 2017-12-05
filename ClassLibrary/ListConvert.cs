using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ListConvert
    {
        public static List<int> GetList(string str)
        {
            List<int> NewList = new List<int>();
            string[] temp = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temp.Length; i++)
            {
                NewList.Add(int.Parse(temp[i]));
            }
            return NewList;
        }
        public static string GetString(IList<int> list)
        {
            return string.Join(", ", list);
        }
        public static string GetString(IList<List<int>> list)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                stringBuilder.AppendLine(GetString(list[i]));
            }
            return stringBuilder.ToString();
        }
    }
}
