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
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        string strconn = "database=QLSINHVIEN;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa;password=7415963";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                MessageBox.Show("Kết nối thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại \n" + ex.Message);
            }
        }

        private void btnDongkn_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đã đóng CSDL thành công");
            }
        }
    }
}
