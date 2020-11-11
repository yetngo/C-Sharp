using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiCSDL_Bai1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string strconn = "database=QLSINHVIEN;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa;password=7415963";
        SqlConnection conn = null;
        private void btSoSV_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select count(*) from sinhvien";
            command.Connection = conn;
            int kq = (int)command.ExecuteScalar();
            lblSoluong.Text = kq.ToString();
            conn.Close();
        }
    }
}
