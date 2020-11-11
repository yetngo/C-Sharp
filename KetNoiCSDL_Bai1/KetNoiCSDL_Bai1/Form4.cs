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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string strconn = "database=QLSINHVIEN;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa;password=7415963";
        SqlConnection conn = null;
        private void Form4_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from lop";
            command.Connection = conn;
            lsbDanhSachLop.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string malop = reader.GetString(0);
                string tenlop = reader.GetString(1);
                int nam = reader.GetInt32(2);
                string line = malop + "-" + tenlop + "-" + nam.ToString();
                lsbDanhSachLop.Items.Add(line);
            }
            conn.Close();
        }

        private void lsbDanhSachLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvDSSV.Items.Clear();
            if (lsbDanhSachLop.SelectedIndex == -1) return;
            string line = lsbDanhSachLop.SelectedItem.ToString();
            string[] array = line.Split('-');
            string malop = array[0];
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from sinhvien where malop=@malop";
            SqlParameter sqlPara = new SqlParameter("@malop", SqlDbType.Char);
            sqlPara.Value = malop;
            command.Parameters.Add(sqlPara);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malopsv = reader.GetString(2);
                ListViewItem item = lsvDSSV.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malopsv);
            }
            conn.Close();
        }
    }
}
