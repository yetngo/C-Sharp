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

namespace Lab4
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa; password=7415963";

        private void Categories_Load(object sender, EventArgs e)
        {
            lsvCategories.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Categories", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetInt32(0).ToString();
                string name = reader.GetString(1);
                string description = reader.GetString(2);

                ListViewItem item = lsvCategories.Items.Add(id);
                item.SubItems.Add(name);
                item.SubItems.Add(description);
            }
        }
    }
}
