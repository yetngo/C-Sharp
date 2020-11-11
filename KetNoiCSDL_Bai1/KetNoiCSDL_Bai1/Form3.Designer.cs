namespace KetNoiCSDL_Bai1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhapMaLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.btnXemTTLop = new System.Windows.Forms.Button();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.lsvDSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // txtNhapMaLop
            // 
            this.txtNhapMaLop.Location = new System.Drawing.Point(99, 27);
            this.txtNhapMaLop.Name = "txtNhapMaLop";
            this.txtNhapMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtNhapMaLop.TabIndex = 4;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(99, 114);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(99, 147);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 20);
            this.txtTenLop.TabIndex = 6;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(99, 180);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 7;
            // 
            // btnXemTTLop
            // 
            this.btnXemTTLop.Location = new System.Drawing.Point(41, 70);
            this.btnXemTTLop.Name = "btnXemTTLop";
            this.btnXemTTLop.Size = new System.Drawing.Size(158, 23);
            this.btnXemTTLop.TabIndex = 8;
            this.btnXemTTLop.Text = "Xem thông tin chi tiết về lớp";
            this.btnXemTTLop.UseVisualStyleBackColor = true;
            this.btnXemTTLop.Click += new System.EventHandler(this.btnXemTTLop_Click);
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Location = new System.Drawing.Point(243, 70);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(241, 23);
            this.btnXemDSSV.TabIndex = 9;
            this.btnXemDSSV.Text = "Xem danh sách sinh viên của lớp";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            this.btnXemDSSV.Click += new System.EventHandler(this.btnXemDSSV_Click);
            // 
            // lsvDSSV
            // 
            this.lsvDSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvDSSV.FullRowSelect = true;
            this.lsvDSSV.GridLines = true;
            this.lsvDSSV.HideSelection = false;
            this.lsvDSSV.Location = new System.Drawing.Point(243, 114);
            this.lsvDSSV.Name = "lsvDSSV";
            this.lsvDSSV.Size = new System.Drawing.Size(241, 145);
            this.lsvDSSV.TabIndex = 10;
            this.lsvDSSV.UseCompatibleStateImageBehavior = false;
            this.lsvDSSV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sv";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã lớp";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 308);
            this.Controls.Add(this.lsvDSSV);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.btnXemTTLop);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtNhapMaLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhapMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Button btnXemTTLop;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.ListView lsvDSSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}