using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int add;
            add = Convert.ToInt32(txtVal1.Text) + Convert.ToInt32(txtVal2.Text);
            txtAns.Text = Convert.ToString(add);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int min;
            min = Convert.ToInt32(txtVal1.Text) - Convert.ToInt32(txtVal2.Text);
            txtAns.Text = Convert.ToString(min);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int mul;
            mul = Convert.ToInt32(txtVal1.Text) * Convert.ToInt32(txtVal2.Text);
            txtAns.Text = Convert.ToString(mul);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Double div;
            div = Convert.ToDouble(txtVal1.Text) / Convert.ToDouble(txtVal2.Text);
            txtAns.Text = Convert.ToString(div);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.thenanosoft.com");
        }
    }
}
