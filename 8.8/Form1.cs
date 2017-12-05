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

namespace _8._8
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
                List<int> weights = ListConvert.GetList(ListInput.Text);
                if (weights.Count > 10)
                {
                    throw new Exception();
                }
                int sumWeight = int.Parse(IntInput.Text);
                ToolsList toolsList = new ToolsList();
                List<List<int>> result = toolsList.SelectionCount(weights, sumWeight);
                if(result.Count > 0)
                {
                    Output.Text = ListConvert.GetString(result);
                }
                else
                {
                    Output.Text = "комбинаций не найдено";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
