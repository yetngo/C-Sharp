using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int ucln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
        private int bcnn(int a, int b)
        {
            return (a * b) / ucln(a, b);
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Form1 f = new Form1();
            if (rbUSCLN.Checked)
                txtKetQua.Text = ucln(a, b).ToString();
            else if (rbBSCNN.Checked)
                txtKetQua.Text = bcnn(a, b).ToString();
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
            rbUSCLN.Checked=true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
