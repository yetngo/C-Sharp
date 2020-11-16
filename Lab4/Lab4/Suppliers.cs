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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa; password=7415963";

        private void View()
        {
            lsvSuppliers.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Suppliers", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string supplierID = reader.GetInt32(0).ToString();
                string companyName = reader.GetString(1);
                string contactName = reader.GetString(2);
                string contactTitle = reader.GetString(3);
                string address = reader.GetString(4);
                string city = reader.GetString(5);
                string region = reader.GetSqlString(6).ToString();
                string postalCode = reader.GetString(7);
                string country = reader.GetString(8);
                string phone = reader.GetString(9);
                string fax = reader.GetSqlString(10).ToString();
                string homePage = reader.GetSqlString(11).ToString();

                ListViewItem item = lsvSuppliers.Items.Add(supplierID);
                item.SubItems.Add(companyName);
                item.SubItems.Add(contactName);
                item.SubItems.Add(contactTitle);
                item.SubItems.Add(address);
                item.SubItems.Add(city);
                item.SubItems.Add(region);
                item.SubItems.Add(postalCode);
                item.SubItems.Add(country);
                item.SubItems.Add(phone);
                item.SubItems.Add(fax);
                item.SubItems.Add(homePage);
            }
            conn.Close();
        }
        private void Suppliers_Load(object sender, EventArgs e)
        {
            View();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvSuppliers.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Suppliers where CompanyName like '%" + txtName.Text + "%'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string supplierID = reader.GetInt32(0).ToString();
                string companyName = reader.GetString(1);
                string contactName = reader.GetString(2);
                string contactTitle = reader.GetString(3);
                string address = reader.GetString(4);
                string city = reader.GetString(5);
                string region = reader.GetSqlString(6).ToString();
                string postalCode = reader.GetString(7);
                string country = reader.GetString(8);
                string phone = reader.GetString(9);
                string fax = reader.GetSqlString(10).ToString();
                string homePage = reader.GetSqlString(11).ToString();

                ListViewItem item = lsvSuppliers.Items.Add(supplierID);
                item.SubItems.Add(companyName);
                item.SubItems.Add(contactName);
                item.SubItems.Add(contactTitle);
                item.SubItems.Add(address);
                item.SubItems.Add(city);
                item.SubItems.Add(region);
                item.SubItems.Add(postalCode);
                item.SubItems.Add(country);
                item.SubItems.Add(phone);
                item.SubItems.Add(fax);
                item.SubItems.Add(homePage);
            }
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            View();
        }
    }
}
