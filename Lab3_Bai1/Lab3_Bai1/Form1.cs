using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSoM.Text = "";
            txtSoN.Text = "";
            txtKetQua.Text = "";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text); 
            int m = int.Parse(txtSoM.Text); 
            int Tong = n + m; 
            txtKetQua.Text = Tong.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int m = int.Parse(txtSoM.Text);
            int Hieu = n - m;
            txtKetQua.Text = Hieu.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int m = int.Parse(txtSoM.Text);
            int Tich = n * m;
            txtKetQua.Text = Tich.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoN.Text);
            int m = int.Parse(txtSoM.Text);
            double Thuong = (double)n / m;
            txtKetQua.Text = Thuong.ToString();
        }
    }
}
