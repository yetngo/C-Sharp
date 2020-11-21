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

namespace PractialExam
{
    public partial class TimBangDia : Form
    {
        public TimBangDia()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=QL_BANGDIA;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa; password=7415963";

        private void btnTim_Click(object sender, EventArgs e)
        {
            lsvDia.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from dia where tendia like N'%" + txtTenDia.Text + "%'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maDia = reader.GetString(0);
                string tenDia = reader.GetString(1);
                string theLoai = reader.GetString(2);

                ListViewItem item = lsvDia.Items.Add(maDia);
                item.SubItems.Add(tenDia);
                item.SubItems.Add(theLoai);
            }
            conn.Close();
        }
    }
}
