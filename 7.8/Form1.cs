using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace _7._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double[] Arr = ArrConvert.StrToArray<double>(ArrInput.Text);
                double R = double.Parse(RInput.Text);
                ToolsDoubleArr toolsDoubleArr = new ToolsDoubleArr(Arr);
                int index = toolsDoubleArr.GetIndexNearR(R);
                ElementOutput.Text = Arr[index].ToString();
                IndexOutput.Text = index.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
