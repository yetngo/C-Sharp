using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class form : Form
    {
        string filename;
        public form()
        {
            InitializeComponent();
        }
        private bool validate()
        {
            Regex phone = new Regex(@"\d{10}", RegexOptions.IgnoreCase);
            Regex email = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtAddress.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)
                || string.IsNullOrWhiteSpace(cbbYear.SelectedIndex.ToString()) || string.IsNullOrWhiteSpace(dtpJoin.Value.ToString()))
            {
                MessageBox.Show("Please fill all text boxes!");
                return false;
            }
            else if (!phone.IsMatch(txtPhone.Text))
            {
                MessageBox.Show("Phone number has 10 digits!");
                return false;
            }
            else if (!email.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Please input right email!");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                ListViewItem lvi = lsvEmployee.Items.Add(txtName.Text);
                lvi.SubItems.Add(txtAge.Text);
                lvi.SubItems.Add(txtAddress.Text);
                lvi.SubItems.Add(cbbYear.Text);
                lvi.SubItems.Add(txtPhone.Text);
                lvi.SubItems.Add(txtEmail.Text);
                lvi.SubItems.Add(dtpJoin.Text);
                MessageBox.Show("Add success");
            }
        }
        private void SaveFile(string filename)
        {
            StreamWriter write = new StreamWriter(filename);
            foreach (ListViewItem item in lsvEmployee.Items)
                write.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text
                    + "," + item.SubItems[3].Text + "," + item.SubItems[4].Text + "," + item.SubItems[5].Text + "," + item.SubItems[6].Text);
            write.ToString();
            write.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.DefaultExt = "txt";
                saveDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.RestoreDirectory = true;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveDialog.FileName;
                }
            }
            SaveFile(filename);
            MessageBox.Show("Save success");
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
                if (validate())
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

        public void loadFile(string fileName)
        {
            try
            {
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(input);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] list = str.Split(',');
                    string name = list[0];
                    string age = list[1];
                    string address = list[2];
                    string year = list[3];
                    string phone = list[4];
                    string email = list[5];
                    string date = list[6];
                    ListViewItem item = lsvEmployee.Items.Add(name);
                    item.SubItems.Add(age);
                    item.SubItems.Add(address);
                    item.SubItems.Add(year);
                    item.SubItems.Add(phone);
                    item.SubItems.Add(email);
                    item.SubItems.Add(date);
                }
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {

                MessageBox.Show(e.Message);
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = "txt";
            openDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openDialog.CheckFileExists = true;
            openDialog.CheckPathExists = true;
            openDialog.FilterIndex = 2;
            openDialog.RestoreDirectory = true;
            openDialog.ReadOnlyChecked = true;
            openDialog.ShowReadOnly = true;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openDialog.FileName;
                loadFile(filename);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            filename = null;
            lsvEmployee.Items.Clear();
            txtAddress.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            cbbYear.Text = "0";
            dtpJoin.Value = DateTime.Now;
        }
    }
}
