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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string strconn = "database=QLSINHVIEN;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa;password=7415963";
        SqlConnection conn = null;
        int result = -1;
        private void Form5_Load(object sender, EventArgs e)
        {
            Hienthisinhvien();
        }
        private void Hienthisinhvien()
        {
            lvSinhvien.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("Select * from sinhvien",conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string masv = reader.GetString(0);
                string hoten = reader.GetString(1);
                string malopsv = reader.GetString(2);
                ListViewItem item = lvSinhvien.Items.Add(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malopsv);
            }
            conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "delete from sinhvien where masv=@masv";
            SqlParameter sqlPara1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(sqlPara1);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nXóa một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
                txtMaSinhVien.Text = "";
                txtHoTen.Text = "";
                txtMaLop.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update sinhvien set hoten=@hoten,malop=@malop where masv=@masv";
            SqlParameter sqlPara1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(sqlPara1);
            SqlParameter sqlPara2 = new SqlParameter("@hoten", txtHoTen.Text);
            command.Parameters.Add(sqlPara2);
            SqlParameter sqlPara3 = new SqlParameter("@malop", txtMaLop.Text);
            command.Parameters.Add(sqlPara3);
            command.Connection = conn;
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nCập nhật một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into sinhvien(masv,hoten,malop) values(@masv, @hoten,@malop)";
            SqlParameter sqlPara1 = new SqlParameter("@masv", txtMaSinhVien.Text);
            command.Parameters.Add(sqlPara1);
            SqlParameter sqlPara2 = new SqlParameter("@hoten", txtHoTen.Text);
            command.Parameters.Add(sqlPara2);
            SqlParameter sqlPara3 = new SqlParameter("@malop", txtMaLop.Text);
            command.Parameters.Add(sqlPara3);
            command.Connection = conn;
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nThêm một sinh viên thất bại");
            }
            if (result > 0)
            {
                Hienthisinhvien();
            }
        }

        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                txtMaSinhVien.Text = lvSinhvien.SelectedItems[0].SubItems[0].Text;
                txtHoTen.Text = lvSinhvien.SelectedItems[0].SubItems[1].Text;
                txtMaLop.Text = lvSinhvien.SelectedItems[0].SubItems[2].Text;
            }
        }
    }
}
