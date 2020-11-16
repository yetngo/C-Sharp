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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;
        string strconn = "database=Northwind;Server=NHANLTTDE140100\\YETSQLSERVER;User id=sa; password=7415963";

        private void View()
        {
            lsvProducts.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Products", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string productID = reader.GetInt32(0).ToString();
                string productName = reader.GetString(1);
                string supplierID = reader.GetInt32(2).ToString();
                string categoryID = reader.GetInt32(3).ToString();
                string quantityPerUnit = reader.GetString(4);
                string unitPrice = reader.GetDecimal(5).ToString();
                string unitsInStock = reader.GetInt16(6).ToString();
                string unitsOnOrder = reader.GetInt16(7).ToString();
                string reorderLevel = reader.GetInt16(8).ToString();
                string discontinued = reader.GetBoolean(9).ToString();

                ListViewItem item = lsvProducts.Items.Add(productID);
                item.SubItems.Add(productName);
                item.SubItems.Add(supplierID);
                item.SubItems.Add(categoryID);
                item.SubItems.Add(quantityPerUnit);
                item.SubItems.Add(unitPrice);
                item.SubItems.Add(unitsInStock);
                item.SubItems.Add(unitsOnOrder);
                item.SubItems.Add(reorderLevel);
                item.SubItems.Add(discontinued);
            }
            conn.Close();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            View();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lsvProducts.Items.Clear();
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand("select * from Products where ProductName like '%" + txtName.Text + "%'", conn);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string productID = reader.GetInt32(0).ToString();
                string productName = reader.GetString(1);
                string supplierID = reader.GetInt32(2).ToString();
                string categoryID = reader.GetInt32(3).ToString();
                string quantityPerUnit = reader.GetString(4);
                string unitPrice = reader.GetDecimal(5).ToString();
                string unitsInStock = reader.GetInt16(6).ToString();
                string unitsOnOrder = reader.GetInt16(7).ToString();
                string reorderLevel = reader.GetInt16(8).ToString();
                string discontinued = reader.GetBoolean(9).ToString();

                ListViewItem item = lsvProducts.Items.Add(productID);
                item.SubItems.Add(productName);
                item.SubItems.Add(supplierID);
                item.SubItems.Add(categoryID);
                item.SubItems.Add(quantityPerUnit);
                item.SubItems.Add(unitPrice);
                item.SubItems.Add(unitsInStock);
                item.SubItems.Add(unitsOnOrder);
                item.SubItems.Add(reorderLevel);
                item.SubItems.Add(discontinued);
            }
            conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            View();
        }
    }
}
