using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractialExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void băngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatBangDia c = new CapNhatBangDia();
            c.Show();
        }

        private void tênBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimBangDia t = new TimBangDia();
            t.Show();
        }
    }
}
