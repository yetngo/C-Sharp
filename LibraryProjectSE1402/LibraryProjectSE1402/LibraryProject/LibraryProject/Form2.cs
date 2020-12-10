using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strconn = "Server=;database=LibC#;user id=uyenlp;password=abcd";
        int result = -1;
        private void ViewMuonTra()
        {
            dgvMuonTra.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM LogLibs", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string stID = reader.GetString(0).Trim();
                int bID = reader.GetInt32(1);
                DateTime ngayMuon = reader.GetDateTime(2);
                DateTime? ngayTra = reader[3] as DateTime?;
                int logID = reader.GetInt32(4);
                string libID = reader.GetString(5);
                dgvMuonTra.Rows.Add(stID, bID, ngayMuon, ngayTra, logID, libID);
            }
            conn.Close();
        }
        private void ViewSach()
        {
            dgvSach.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("Select * from Books", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                int BookID = reader.GetInt32(0);
                string Name = reader.GetString(1);
                string Author = reader.GetString(2);
                string Category = reader.GetString(3);
                string Status;
                if (reader.GetInt32(4) == 0)
                    Status = "Đã Mượn";
                else Status = "Chưa Mượn";
                dgvSach.Rows.Add(BookID, Name, Author, Category, Status);
            }
            conn.Close();
        }


        private void DtvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < dgvSach.RowCount - 1)
            {
                DataGridViewRow row = dgvSach.Rows[rowIndex];
                txtIDSach.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtAuthor.Text = row.Cells[2].Value.ToString();
                txtCategory.Text = row.Cells[3].Value.ToString();
                chkStatus.Checked = row.Cells[4].Value.ToString() == "Đã Mượn" ? true : false;
                txtIDBook.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                txtIDSach.Text = "";
                txtName.Text = "";
                txtAuthor.Text = "";
                txtCategory.Text = "";
                chkStatus.Checked = false;
            }
        }

        private void DtvMuonTraSachClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < dgvMuonTra.RowCount - 1)
            {
                DataGridViewRow row = dgvMuonTra.Rows[rowIndex];
                txtIDLog.Text = row.Cells[4].Value.ToString();
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtIDBook.Text = row.Cells[1].Value.ToString();
                txtIDBook.Enabled = false;
                dtpNgayMuon.Enabled = false;
            }
            else
            {
                txtIDLog.Text = "";
                txtMSSV.Text = "";
                txtIDBook.Text = "";
                txtIDBook.Enabled = true;
                dtpNgayMuon.Enabled = true;
            }
        }
        //
        //-----------------------Bảng SV-------------------------
        private bool validateSV()
        {
            Regex idValid = new Regex(@"[A-Z]{2}\d{5}", RegexOptions.IgnoreCase);
            Regex classValid = new Regex(@"[A-Z]{2}\d{4}", RegexOptions.IgnoreCase);
            Regex emailValid = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(txtIDSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền toàn bộ ô trống!");
                return false;
            }
            else if (!idValid.IsMatch(txtIDSV.Text))
            {
                MessageBox.Show("Vui lòng điền đúng ID!");
                return false;
            }
            else if (!classValid.IsMatch(txtLop.Text))
            {
                MessageBox.Show("Vui lòng điền đúng Lớp!");
                return false;
            }
            else if (!emailValid.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đúng email!");
                return false;
            }
            return true;
        }
        private bool check(string id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from student where studentID=@studentID";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@studentID", id);
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

        private void ViewSV()
        {
            dgvSV.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("Select * from Student", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string StudentID = reader.GetString(0).Trim();
                string FullName = reader.GetString(1);
                string Email = reader.GetString(2);
                string Status;
                if (reader.GetInt32(3) == 1)
                    Status = "Bình thường";
                else Status = "Bị cấm";
                string Class = reader.GetString(4);
                dgvSV.Rows.Add(StudentID, FullName, Class, Email, Status);
            }
            conn.Close();
        }
        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < dgvSV.RowCount - 1)
            {
                DataGridViewRow row = dgvSV.Rows[rowIndex];
                txtIDSV.Text = row.Cells[0].Value.ToString();
                txtTenSV.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                ckbBan.Checked = row.Cells[4].Value.ToString() == "Bình thường" ? false : true;
                txtLop.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                txtIDSV.Text = "";
                txtTenSV.Text = "";
                txtEmail.Text = "";
                ckbBan.Checked = false;
                txtLop.Text = "";
            }
        }
        private void btnAddSV_Click(object sender, EventArgs e)
        {
            if (validateSV())
            {
                if (!check(txtIDSV.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into Student(StudentID,Fullname,Email,Status,Class) values (@id,@name,@email,@status,@classSV)";
                    SqlParameter sqlPara1 = new SqlParameter("@id", txtIDSV.Text);
                    command.Parameters.Add(sqlPara1);
                    SqlParameter sqlPara2 = new SqlParameter("@name", txtTenSV.Text);
                    command.Parameters.Add(sqlPara2);
                    SqlParameter sqlPara3 = new SqlParameter("@email", txtEmail.Text);
                    command.Parameters.Add(sqlPara3);
                    SqlParameter sqlPara4 = new SqlParameter("@status", ckbBan.Checked ? 2 : 1);
                    command.Parameters.Add(sqlPara4);
                    SqlParameter sqlPara5 = new SqlParameter("@classSV", txtLop.Text);
                    command.Parameters.Add(sqlPara5);
                    command.Connection = conn;

                    try
                    {
                        result = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message + "\nThêm sinh viên thất bại"); }
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewSV();
                        txtIDSV.Text = "";
                        txtTenSV.Text = "";
                        txtEmail.Text = "";
                        ckbBan.Checked = false;
                        txtLop.Text = "";
                        MessageBox.Show("Thêm sinh viên thành công");
                    }
                }
                else
                {
                    MessageBox.Show("ID đã tồn tại");
                }
            }
        }

        private void btnUpdateSV_Click(object sender, EventArgs e)
        {
            if (validateSV())
            {
                if (check(txtIDSV.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "update Student set Fullname=@name,Email=@email,Status=@status,Class=@classSV where StudentID=@id";
                    SqlParameter sqlPara1 = new SqlParameter("@id", txtIDSV.Text);
                    command.Parameters.Add(sqlPara1);
                    SqlParameter sqlPara2 = new SqlParameter("@name", txtTenSV.Text);
                    command.Parameters.Add(sqlPara2);
                    SqlParameter sqlPara3 = new SqlParameter("@email", txtEmail.Text);
                    command.Parameters.Add(sqlPara3);
                    SqlParameter sqlPara4 = new SqlParameter("@status", ckbBan.Checked ? 2 : 1);
                    command.Parameters.Add(sqlPara4);
                    SqlParameter sqlPara5 = new SqlParameter("@classSV", txtLop.Text);
                    command.Parameters.Add(sqlPara5);
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
                        ViewSV();
                    }
                }
                else MessageBox.Show("Không tìm thấy sinh viên");
            }
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            Regex idValid = new Regex(@"[A-Z]{2}\d{5}", RegexOptions.IgnoreCase);
            if (!string.IsNullOrWhiteSpace(txtIDSV.Text) && idValid.IsMatch(txtIDSV.Text))
            {
                if (check(txtIDSV.Text))
                {
                    if (conn == null)
                        conn = new SqlConnection(strconn);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.Connection = conn;
                    command.CommandText = "delete from loglibs where StudentID=@id delete from Student where StudentID=@id";
                    SqlParameter sqlPara1 = new SqlParameter("@id", txtIDSV.Text);
                    command.Parameters.Add(sqlPara1);
                    try
                    {
                        result = command.ExecuteNonQuery();
                        MessageBox.Show("Xóa sinh viên thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "Xóa sinh viên thất bại");
                    }
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewSV();
                        txtIDSV.Text = "";
                        txtTenSV.Text = "";
                        txtEmail.Text = "";
                        ckbBan.Checked = false;
                        txtLop.Text = "";
                    }
                }
                else MessageBox.Show("Không tìm thấy sinh viên");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng ID!");
            }
        }
        //-----------------Bảng SV xong ---------------------------------
        //

        private void Form2_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(250, 70);
            ViewMuonTra();
            ViewSach();
            ViewSV();
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        { 
            dgvSach.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Name LIKE N'%" + txtSearchBook.Text + "%'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dgvSach.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
            }
            conn.Close();
        }

        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            dgvSV.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE StudentID LIKE N'%" + txtSearchSV.Text + "%'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string StudentID = reader.GetString(0).Trim();
                string FullName = reader.GetString(1);
                string Email = reader.GetString(2);
                string Status;
                if (reader.GetInt32(3) == 1)
                    Status = "Bình thường";
                else Status = "Bị cấm";
                string Class = reader.GetString(4);
                dgvSV.Rows.Add(StudentID, FullName, Class, Email, Status);
            }
            conn.Close();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            dgvMuonTra.Rows.Clear();
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM LogLibs WHERE StudentID LIKE N'%" + txtBookName.Text + "%'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string stID = reader.GetString(0).Trim();
                int bID = reader.GetInt32(1);
                DateTime ngayMuon = reader.GetDateTime(2);
                DateTime? ngayTra = reader[3] as DateTime?;
                int logID = reader.GetInt32(4);
                string libID = reader.GetString(5);
                dgvMuonTra.Rows.Add(stID, bID, ngayMuon, ngayTra, logID, libID);
            }
            conn.Close();
        }

        private void dgvMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=============================== TAB mượn sách ======================================
        public string getLibID
        {
            set { textBox7.Text = value; }
        }
        private bool validateStudentStatus(string id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT status FROM  student where StudentID=@StudentID";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@StudentID", id);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int status = reader.GetInt32(0);
                if (status == 2)
                {
                    conn.Close();
                    MessageBox.Show("Sinh viên đã bị cấm! không thể mượn sách");
                    return false;
                }
            }
            conn.Close();
            return true;
        }
        private bool validateBookStatus(int id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT status FROM  Books where bookid=@bookid";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@bookid", id);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int status = reader.GetInt32(0);
                if (status == 0)
                {
                    conn.Close();
                    MessageBox.Show("Sách đã được mượn! Vui lòng chọn sách khác!");
                    return false;
                }
            }
            conn.Close();
            return true;
        }
        private bool checkBookID(int id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from books where bookid=@bookid";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@bookid", id);
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
        private bool validateLogLib()
        {
            Regex idValid = new Regex(@"[A-Z]{2}\d{5}", RegexOptions.IgnoreCase);
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) || string.IsNullOrWhiteSpace(txtIDBook.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return false;
            }
            else if (!idValid.IsMatch(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng điền đúng ID sinh viên!");
                return false;
            }
            else if (!check(txtMSSV.Text))
            {
                MessageBox.Show("Mã số sinh viên không có trong hệ thống");
                return false;
            }
            else if (!checkBookID(int.Parse(txtIDBook.Text)))
            {
                MessageBox.Show("Mã số sách không có trong hệ thống");
                return false;
            }

            return true;
        }
        private bool checkStudentID(int id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select studentid from [LogLibs] where LogID=@LogID";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@LogID", id);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string stID = reader.GetString(0).Trim();
                if (!stID.Equals(txtMSSV.Text))
                {
                    conn.Close();
                    MessageBox.Show("StudentID không mượn sách này!" + "\nVui lòng nhập lại StudentID");
                    return false;
                }

            }
            conn.Close();
            return true;
        }
        private bool checkNgayTra(int id)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select ngaytra from [LogLibs] where LogID=@LogID";
            command.Connection = conn;

            SqlParameter para1 = new SqlParameter("@LogID", id);
            command.Parameters.Add(para1);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                DateTime? ngayTra = reader[0] as DateTime?;
                if (ngayTra != null)
                {
                    conn.Close();
                    MessageBox.Show("Sách đã được trả");
                    return false;
                }
            }
            conn.Close();
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateLogLib() && validateBookStatus(Int16.Parse(txtIDBook.Text)) && validateStudentStatus(txtMSSV.Text))
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO LogLibs(StudentID,BookID,NgayMuon,LibID)" +
                                        "VALUES (@stID,@bID,@NgayMuon,@LibID) " +
                                        "UPDATE books set status=0 where bookID=@bID ";

                SqlParameter sqlPara1 = new SqlParameter("@stID", txtMSSV.Text);
                cmd.Parameters.Add(sqlPara1);
                SqlParameter sqlPara2 = new SqlParameter("@bID", int.Parse(txtIDBook.Text));
                cmd.Parameters.Add(sqlPara2);
                SqlParameter sqlPara3 = new SqlParameter("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.Add(sqlPara3);
                SqlParameter sqlPara4 = new SqlParameter("@LibID", textBox7.Text);
                cmd.Parameters.Add(sqlPara4);

                cmd.Connection = conn;
                try
                {
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewMuonTra();
                        ViewSV();
                        ViewSach();
                        txtIDSV.Text = "";
                        txtTenSV.Text = "";
                        txtEmail.Text = "";
                        ckbBan.Checked = false;
                        txtLop.Text = "";
                        MessageBox.Show("Mượn sách thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Muợn sách thất bại");
                }

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateLogLib() && validateStudentStatus(txtMSSV.Text))
            {

                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE LogLibs SET StudentID=@stID,BookID=@bID,NgayMuon=@NgayMuon WHERE LogID=@logID";

                SqlParameter sqlPara1 = new SqlParameter("@LogID", int.Parse(txtIDLog.Text));
                cmd.Parameters.Add(sqlPara1);
                SqlParameter sqlPara2 = new SqlParameter("@stID", txtMSSV.Text.Trim());
                cmd.Parameters.Add(sqlPara2);
                SqlParameter sqlPara3 = new SqlParameter("@bID", int.Parse(txtIDBook.Text));
                cmd.Parameters.Add(sqlPara3);
                SqlParameter sqlPara4 = new SqlParameter("@NgayMuon", dtpNgayMuon.Value);
                cmd.Parameters.Add(sqlPara4);
                cmd.Connection = conn;
                try
                {
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewMuonTra();
                        ViewSV();
                        ViewSach();
                        txtIDLog.Text = "";
                        txtMSSV.Text = "";
                        txtIDBook.Text = "";

                        MessageBox.Show("Cập nhật thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
        //================= Xóa thông tin mượn sách =======================
        private void button7_Click(object sender, EventArgs e)
        {
            if (validateLogLib() && checkStudentID(int.Parse(txtIDLog.Text)))
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM LogLibs where LogID=@logID " +
                    "UPDATE books set status=1 where bookID=@bID ";

                SqlParameter sqlPara1 = new SqlParameter("@logID", txtIDLog.Text);
                cmd.Parameters.Add(sqlPara1);
                SqlParameter sqlPara2 = new SqlParameter("@bID", int.Parse(txtIDBook.Text));
                cmd.Parameters.Add(sqlPara2);

                cmd.Connection = conn;
                try
                {
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewMuonTra();
                        ViewSV();
                        ViewSach();
                        txtIDLog.Text = "";
                        txtMSSV.Text = "";
                        txtIDBook.Text = "";
                        MessageBox.Show("Xóa thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Xóa thất bại");
                }

            }
        }
        //================= Trả sách =======================
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (validateLogLib() && validateStudentStatus(txtMSSV.Text) && checkStudentID(int.Parse(txtIDLog.Text)) && checkNgayTra(int.Parse(txtIDLog.Text)))
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE LogLibs SET NgayTra=@NgayTra WHERE LogID=@LogID " +
                                   "UPDATE books set status=1 where bookID=@bID ";

                DateTime NgayTra = DateTime.Now;
                DateTime ngayMuon = dtpNgayMuon.Value;
                TimeSpan interval = NgayTra.Subtract(ngayMuon);
                // thời gian mượn 
                int tgMuon = interval.Days;

                SqlParameter sqlpara1 = new SqlParameter("@LogID", int.Parse(txtIDLog.Text));
                cmd.Parameters.Add(sqlpara1);
                SqlParameter sqlPara2 = new SqlParameter("@NgayTra", NgayTra);
                cmd.Parameters.Add(sqlPara2);
                SqlParameter sqlPara3 = new SqlParameter("@bID", txtIDBook.Text);
                cmd.Parameters.Add(sqlPara3);
                cmd.Connection = conn;
                try
                {
                    result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dgvSV.Rows.Clear();
                        ViewMuonTra();
                        ViewSV();
                        ViewSach();
                        if (tgMuon > 10)
                        {
                            int muon = tgMuon - 10;
                            MessageBox.Show("Trả sách muộn " + muon + " ngày");
                        }
                        else
                        {
                            MessageBox.Show("Trả sách thành công");
                            txtIDLog.Text = "";
                            txtMSSV.Text = "";
                            txtIDBook.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trả sách thất bại");
                }
            }
        }
        //=============================== TAB Quản lí sách ======================================

        private bool validateSach()
        {
            return IsNameValid(txtName.Text)
                 && IsAuthorValid(txtAuthor.Text)
                 && IsCategoryValid(txtCategory.Text);
        }
        private bool IsNameValid(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
        private bool IsAuthorValid(string author)
        {
            return !string.IsNullOrEmpty(author);
        }
        private bool IsCategoryValid(string category)
        {
            return !string.IsNullOrEmpty(category);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (validateSach())
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into Books(Name,Author,Category,Status) values (@name,@author,@category,@status)";

                SqlParameter sqlPara2 = new SqlParameter("@name", txtName.Text);
                command.Parameters.Add(sqlPara2);
                SqlParameter sqlPara3 = new SqlParameter("@author", txtAuthor.Text);
                command.Parameters.Add(sqlPara3);
                SqlParameter sqlPara4 = new SqlParameter("@category", txtCategory.Text);
                command.Parameters.Add(sqlPara4);
                SqlParameter sqlPara5 = new SqlParameter("@status", chkStatus.Checked ? 0 : 1);
                command.Parameters.Add(sqlPara5);
                command.Connection = conn;

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message + "\nThêm sách thất bại"); }
                if (result > 0)
                {
                    dgvSV.Rows.Clear();
                    ViewSach();
                    ViewSV();
                    txtName.Text = "";
                    txtAuthor.Text = "";
                    chkStatus.Checked = false;
                    txtCategory.Text = "";
                    MessageBox.Show("Thêm sách thành công");
                }
            }
            else
                MessageBox.Show("Không được bỏ trống");
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (validateSach())
            {
                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update Books set Name=@name,Author=@author,Category=@category,Status =@status where BookID=@id";
                SqlParameter sqlPara1 = new SqlParameter("@id", txtIDSach.Text);
                command.Parameters.Add(sqlPara1);
                SqlParameter sqlPara2 = new SqlParameter("@name", txtName.Text);
                command.Parameters.Add(sqlPara2);
                SqlParameter sqlPara3 = new SqlParameter("@author", txtAuthor.Text);
                command.Parameters.Add(sqlPara3);
                SqlParameter sqlPara5 = new SqlParameter("@category", txtCategory.Text);
                command.Parameters.Add(sqlPara5);
                SqlParameter sqlPara4 = new SqlParameter("@status", chkStatus.Checked ? 0 : 1);
                command.Parameters.Add(sqlPara4);
                command.Connection = conn;

                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nCập nhật sách thất bại");
                }
                if (result > 0)
                {
                    ViewSach();
                }
            }
            else
                MessageBox.Show("Không được để trống");
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "delete from loglibs where StudentID=@id delete from Books where BookID=@id";
            SqlParameter sqlPara1 = new SqlParameter("@id", txtIDSach.Text);
            command.Parameters.Add(sqlPara1);
            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Xóa sách thất bại");
            }
            if (result > 0)
            {
                dgvSach.Rows.Clear();
                ViewSach();
                txtName.Text = "";
                txtAuthor.Text = "";
                txtCategory.Text = "";
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            if (dgvSach.SelectedRows.Count > 0)
            {
                txtIDBook.Text = dgvSach.SelectedRows[0].Cells[0].Value.ToString();
                txtBookName.Text = dgvSach.SelectedRows[0].Cells[1].Value.ToString();
                txtAuthor.Text = dgvSach.SelectedRows[0].Cells[3].Value.ToString();
                txtCategory.Text = dgvSach.SelectedRows[0].Cells[2].Value.ToString();
                chkStatus.Checked = row.Cells[4].Value.ToString() == "Bình thường" ? false : true;
            }*/
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogReport_Click(object sender, EventArgs e)
        {
            rLog f = new rLog();
            f.Show();
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            rBook f = new rBook();
            f.Show();
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            rStudent f = new rStudent();
            f.Show();
        }
    }
}


