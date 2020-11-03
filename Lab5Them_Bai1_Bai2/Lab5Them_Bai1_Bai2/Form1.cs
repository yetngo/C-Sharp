using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Them_Bai1_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool found = false;
            foreach(DataGridViewRow row in tbOrder.Rows)
                if(Convert.ToString(row.Cells[0].Value)==b.Text)
                {
                    row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                    found = true;
                    break;
                }
            if(!found) this.tbOrder.Rows.Add(b.Text, 1);

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.tbOrder.SelectedRows)
            {
                tbOrder.Rows.RemoveAt(item.Index);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order success");
            tbOrder.DataSource = "";
        }
    }
}
