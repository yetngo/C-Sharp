using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        string strconn = "Server=;database=LibC#;user id=uyenlp;password=abcd";
        SqlCommand cmd;
        DbDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }
        public DbDataReader GetLib()
        {
            String sql = "select * from LibrarianInfo";
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();

            return reader;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLibName.Text;
            string password = txtPassword.Text;
            if (CheckLogin(username, password))
            {
                this.Hide();
                Form2 f = new Form2();
                f.getLibID = username;
                f.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Login Error! Your ID or Password are wrong. Try again!", "Login Error");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Unchecked(object sender, EventArgs e)
        {
            if (!cbPW.Checked)
            {
                cbPW.Text = "Hiển thị mật khẩu";
                txtPassword.PasswordChar = '*';
            }
            else
            {
                cbPW.Text = "Ẩn mật khẩu";
                txtPassword.PasswordChar = '\0';
            }
        }
        public Boolean CheckLogin(String username, String password)
        {
            DbDataReader reader = GetLib();
            try
            {
                while (reader.Read())
                {
                    String LibID = reader.GetString(0);
                    String PasswordLib = reader.GetString(2);
                    if (username == LibID && password == PasswordLib)
                    {
                        return true;
                    }
                }
                return false;
            }
            finally
            {
                reader.Dispose();
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(500, 100);
        }
    }
}
