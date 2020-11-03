using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Them_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtDienThoai.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtDiaChi.Text;
            }
        }

        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0) 
            { 
                txtHoTen.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text; 
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text; 
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text; 
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text; 
            }  
        }

        private bool check(string check)
        {
            if (string.IsNullOrWhiteSpace(check))
                return false;
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check(txtHoTen.Text) && check(txtDiaChi.Text) && check(txtDienThoai.Text))
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(txtHoTen.Text);
                lvi.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
                lvi.SubItems.Add(txtDienThoai.Text);
                lvi.SubItems.Add(txtDiaChi.Text);
            }
            else
                MessageBox.Show("Please input empty textbox!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
