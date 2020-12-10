using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class rStudent : Form
    {
        public rStudent()
        {
            InitializeComponent();
        }

        private void rStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsStudent.Student' table. You can move, or remove it, as needed.
            this.StudentTableAdapter.Fill(this.dsStudent.Student);

            this.reportViewer1.RefreshReport();
        }
    }
}
