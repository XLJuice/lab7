using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) ||
               (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!";
                return;
            }
            double x1 = double.Parse(tbX1.Text);
            double x2 = double.Parse(tbX2.Text);
            double y = (Math.Sqrt(Math.Pow(x1,3)+Math.Pow(x2,5)))/(1000*Math.Sqrt(x1+Math.Pow(x2,5)))+65;
            tbY.Text = y.ToString("0.######");
            double z = (x1 + x2) / 2;
            avg.Text = z.ToString("0.######");
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
