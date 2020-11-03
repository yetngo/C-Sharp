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

namespace Lab4Them_Bai1
{
    public partial class Form1 : Form
    {
        int clean, white, xRay, filling;

        public int Clean { get => clean; set => clean = value; }
        public int White { get => white; set => white = value; }
        public int XRay { get => xRay; set => xRay = value; }
        public int Filling { get => filling; set => filling = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetPay()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                MessageBox.Show("Vui long nhap ten khach hang!!");
            else
            {
                int total = 0;
                if (chkClean.Checked) total += Clean;
                if (chkWhitening.Checked) total += White;
                if (chkXRay.Checked) total += XRay;
                total += (int)numFilling.Value * Filling;
                string txt = total.ToString("$#,##0");
                txtTotal.Text = txt;
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
            list.Items.Add(txtName.Text + "\t" + txtTotal.Text);
        }

        public void SaveFile(string filename)
        {
            StreamWriter write = new StreamWriter(filename);
            foreach (var item in list.Items)
                write.WriteLine(item.ToString());
            write.ToString();
            write.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter= "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(saveDialog.FileName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                list.Items.Clear();
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        list.Items.Add(line);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("donGia.txt");
            lblClean.Text = "$"+lines[1];
            lblWhitening.Text = "$" + lines[3];
            lblFilling.Text = "$" + lines[7]+"/cái";
            lblXRay.Text = "$" + lines[5];
            Clean = int.Parse(lines[1]);
            White = int.Parse(lines[3]);
            XRay = int.Parse(lines[5]);
            Filling = int.Parse(lines[5]);
        }
    }
}
