using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Show();
        }

        private void btnListSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.Show();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }
    }
}
