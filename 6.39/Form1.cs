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

namespace _6._39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            try
            {
                double X = double.Parse(InputX.Text);
                if (Math.Abs(X)>1)
                {
                    throw new Exception();
                }
                double E = double.Parse(InputE.Text);
                ToolsMath toolsMath = new ToolsMath(X, E);
                double y = toolsMath.GetLeft();
                OutY1.Text = "y=" + y;
                y = toolsMath.GetRight(out int n);
                OutY2.Text = "y=" + y;
                OutN.Text = "n=" + n;
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
