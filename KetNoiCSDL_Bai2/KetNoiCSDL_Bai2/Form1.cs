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

namespace KetNoiCSDL_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string stringconn = "database=QLSINHVIEN;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa;password=7415963";

        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select * from sinhvien", stringconn);
            ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "SinhVien");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtMaSV.Text;
            row["Hoten"] = txtHoTen.Text;
            row[2] = txtMaLop.Text;
            ds.Tables[0].Rows.Add(row);

            try
            {
                kq = adapter.Update(ds, "Sinhvien");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them sinh vien thất bại \n" + ex.Message);
            }

            if (kq > 0) MessageBox.Show("Thêm sinh viên thành công");
        }

        int vitri = -1;

        private void gvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;
            if (vitri == -1)
            {
                MessageBox.Show("Khong có dòng nào được chọn");
                return;
            }

            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            txtMaSV.Text = row[0].ToString();
            txtHoTen.Text = row["Hoten"].ToString();
            txtMaLop.Text = row[2].ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (vitri == -1)
            {
                MessageBox.Show("Khong có dòng nào được chọn");
                return;
            }

            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            row.BeginEdit();
            row["MaSV"] = txtMaSV.Text;
            row["Hoten"] = txtHoTen.Text;
            row[2] = txtMaLop.Text;
            row.EndEdit();

            int kq = adapter.Update(ds.Tables["Sinhvien"]);
            if (kq > 0)
            {
                MessageBox.Show("Cap nhat thanh cong");
            }
            else
                MessageBox.Show("Thêm sinh viên thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (vitri == -1) return;
            DataRow row = ds.Tables["SinhVien"].Rows[vitri];
            row.Delete();
            int kq = adapter.Update(ds.Tables["Sinhvien"]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thanh cong");
            }
            else
                MessageBox.Show("Xóa thất bại");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            gvSinhVien.DataSource = ds.Tables[0];
        }

    }
}
