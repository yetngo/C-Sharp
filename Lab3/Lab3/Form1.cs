using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtAddress.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)
                || string.IsNullOrWhiteSpace(cbbYear.SelectedIndex.ToString()) || string.IsNullOrWhiteSpace(dtpJoin.Value.ToString()))
                MessageBox.Show("Please fill all text boxes!");
            else
            {
                ListViewItem lvi = lsvEmployee.Items.Add(txtName.Text);
                lvi.SubItems.Add(txtAge.Text);
                lvi.SubItems.Add(txtAddress.Text);
                lvi.SubItems.Add(cbbYear.Text);
                lvi.SubItems.Add(txtPhone.Text);
                lvi.SubItems.Add(txtEmail.Text);
                lvi.SubItems.Add(dtpJoin.Value.ToShortDateString());
                MessageBox.Show("Add success");
            }
        }
        public void SaveFile(string filename)
        {
            StreamWriter write = new StreamWriter(filename);
            foreach (ListViewItem item in lsvEmployee.Items)
                write.WriteLineAsync(item.SubItems[0].Text+","+item.SubItems[1].Text + "," + item.SubItems[2].Text
                    + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + "," + item.SubItems[5].Text + "," + item.SubItems[6].Text);
            write.ToString();
            write.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveDialog.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                lsvEmployee.Items.Remove(lsvEmployee.SelectedItems[0]);
                MessageBox.Show("Delete success");
            }
            else MessageBox.Show("Please select a employee!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                lsvEmployee.SelectedItems[0].SubItems[0].Text = txtName.Text;
                lsvEmployee.SelectedItems[0].SubItems[1].Text = txtAge.Text;
                lsvEmployee.SelectedItems[0].SubItems[2].Text = txtAddress.Text;
                lsvEmployee.SelectedItems[0].SubItems[3].Text = cbbYear.Text;
                lsvEmployee.SelectedItems[0].SubItems[4].Text = txtPhone.Text;
                lsvEmployee.SelectedItems[0].SubItems[5].Text = txtEmail.Text;
                lsvEmployee.SelectedItems[0].SubItems[6].Text = dtpJoin.Text;
                MessageBox.Show("Update success");
            }
            else MessageBox.Show("Please select a employee!");
        }

        private void llb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llb.LinkVisited = true;
            System.Diagnostics.Process.Start("http://talktime.com");
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                txtName.Text = lsvEmployee.SelectedItems[0].SubItems[0].Text;
                txtAge.Text = lsvEmployee.SelectedItems[0].SubItems[1].Text;
                txtAddress.Text = lsvEmployee.SelectedItems[0].SubItems[2].Text;
                cbbYear.Text = lsvEmployee.SelectedItems[0].SubItems[3].Text;
                txtPhone.Text = lsvEmployee.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = lsvEmployee.SelectedItems[0].SubItems[5].Text;
                dtpJoin.Text = lsvEmployee.SelectedItems[0].SubItems[6].Text;
            }
        }
    }
}
