using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._39
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
                int[] Arr = ArrConvert.StrToArray<int>(ArrInput.Text);
                ToolsIntArr toolsIntArr = new ToolsIntArr(Arr);
                int count = toolsIntArr.GetCountNotZero();
                CountOutput.Text = count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
