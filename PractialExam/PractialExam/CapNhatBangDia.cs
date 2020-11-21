using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractialExam
{
    public partial class CapNhatBangDia : Form
    {
        public CapNhatBangDia()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=QL_BANGDIA;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa; password=7415963";
        int result = -1;
        Regex maDia = new Regex(@"[D]\d{4}", RegexOptions.IgnoreCase);

        private bool validate()
        {

            if (string.IsNullOrWhiteSpace(txtMaDia.Text) || string.IsNullOrWhiteSpace(txtTenDia.Text) || string.IsNullOrWhiteSpace(txtTheLoai.Text))
            {
                MessageBox.Show("Vui lòng điền tất cả các text box!");
                return false;
            }
            else if (!maDia.IsMatch(txtMaDia.Text))
            {
                MessageBox.Show("MADIA phải có dạng Dxxxx với x là các số!");
                return false;
            }
            return true;
        }
        private bool check(string madia)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from dia where madia=@madia";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@madia", madia);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                conn.Close();
                return false;

            }
            conn.Close();
            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (check(txtMaDia.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "update dia set theloai=@theloai,tendia=@tendia where madia=@madia";
                    SqlParameter sqlPara1 = new SqlParameter("@madia", txtMaDia.Text);
                    command.Parameters.Add(sqlPara1);
                    SqlParameter sqlPara2 = new SqlParameter("@tendia", txtTenDia.Text);
                    command.Parameters.Add(sqlPara2);
                    SqlParameter sqlPara3 = new SqlParameter("@theloai", txtTheLoai.Text);
                    command.Parameters.Add(sqlPara3);
                    command.Connection = conn;
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Sửa một đĩa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Sửa một đĩa thất bại");
                    }
                }
                else MessageBox.Show("Không tìm thấy đĩa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaDia.Text) && maDia.IsMatch(txtMaDia.Text))
            {
                if (check(txtMaDia.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "delete from thuedia where madia=@madia delete from dia where madia=@madia";
                    SqlParameter sqlPara1 = new SqlParameter("@madia", txtMaDia.Text);
                    command.Parameters.Add(sqlPara1);
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Xóa một đĩa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Xóa một đĩa thất bại");
                    }
                    if (result > 0)
                    {
                        txtMaDia.Text = "";
                        txtTenDia.Text = "";
                        txtTheLoai.Text = "";
                    }
                }
                else MessageBox.Show("Không tìm thấy đĩa");
            }
            else
            {
                MessageBox.Show("Mã đĩa phải có dạng Dxxxx với x là các số!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                if (!check(txtMaDia.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into dia(madia,tendia,theloai) values(@madia, @tendia,@theloai)";
                    SqlParameter sqlPara1 = new SqlParameter("@madia", txtMaDia.Text);
                    command.Parameters.Add(sqlPara1);
                    SqlParameter sqlPara2 = new SqlParameter("@tendia", txtTenDia.Text);
                    command.Parameters.Add(sqlPara2);
                    SqlParameter sqlPara3 = new SqlParameter("@theloai", txtTheLoai.Text);
                    command.Parameters.Add(sqlPara3);
                    command.Connection = conn;
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Thêm một đĩa thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Thêm một đĩa thất bại");
                    }
                }
                else MessageBox.Show("Mã đĩa đã tồn tại!");
            }
        }
    }
}
