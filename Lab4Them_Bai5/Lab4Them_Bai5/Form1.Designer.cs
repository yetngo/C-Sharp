namespace Lab4Them_Bai5
{
    partial class Form1
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btTraisangphai = new System.Windows.Forms.Button();
            this.btPhaisangtrai = new System.Windows.Forms.Button();
            this.btTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btTatcatraisangphai = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(103, 61);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(202, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // btCapnhat
            // 
            this.btCapnhat.Location = new System.Drawing.Point(322, 59);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btCapnhat.TabIndex = 3;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBandau);
            this.groupBox1.Location = new System.Drawing.Point(21, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.Location = new System.Drawing.Point(6, 19);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(137, 134);
            this.lstBandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKetqua);
            this.groupBox2.Location = new System.Drawing.Point(247, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.Location = new System.Drawing.Point(6, 19);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(138, 134);
            this.lstKetqua.TabIndex = 0;
            // 
            // btTraisangphai
            // 
            this.btTraisangphai.Location = new System.Drawing.Point(176, 182);
            this.btTraisangphai.Name = "btTraisangphai";
            this.btTraisangphai.Size = new System.Drawing.Size(30, 23);
            this.btTraisangphai.TabIndex = 6;
            this.btTraisangphai.Text = ">";
            this.btTraisangphai.UseVisualStyleBackColor = true;
            this.btTraisangphai.Click += new System.EventHandler(this.btTraisangphai_Click);
            // 
            // btPhaisangtrai
            // 
            this.btPhaisangtrai.Location = new System.Drawing.Point(212, 182);
            this.btPhaisangtrai.Name = "btPhaisangtrai";
            this.btPhaisangtrai.Size = new System.Drawing.Size(29, 23);
            this.btPhaisangtrai.TabIndex = 7;
            this.btPhaisangtrai.Text = "<";
            this.btPhaisangtrai.UseVisualStyleBackColor = true;
            this.btPhaisangtrai.Click += new System.EventHandler(this.btPhaisangtrai_Click);
            // 
            // btTatcaphaisangtrai
            // 
            this.btTatcaphaisangtrai.Location = new System.Drawing.Point(212, 211);
            this.btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            this.btTatcaphaisangtrai.Size = new System.Drawing.Size(29, 23);
            this.btTatcaphaisangtrai.TabIndex = 9;
            this.btTatcaphaisangtrai.Text = "<<";
            this.btTatcaphaisangtrai.UseVisualStyleBackColor = true;
            this.btTatcaphaisangtrai.Click += new System.EventHandler(this.btTatcaphaisangtrai_Click);
            // 
            // btTatcatraisangphai
            // 
            this.btTatcatraisangphai.Location = new System.Drawing.Point(176, 211);
            this.btTatcatraisangphai.Name = "btTatcatraisangphai";
            this.btTatcatraisangphai.Size = new System.Drawing.Size(30, 23);
            this.btTatcatraisangphai.TabIndex = 8;
            this.btTatcatraisangphai.Text = ">>";
            this.btTatcatraisangphai.UseVisualStyleBackColor = true;
            this.btTatcatraisangphai.Click += new System.EventHandler(this.btTatcatraisangphai_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(71, 305);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.Location = new System.Drawing.Point(286, 305);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btKetthuc.TabIndex = 11;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = true;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 343);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTatcaphaisangtrai);
            this.Controls.Add(this.btTatcatraisangphai);
            this.Controls.Add(this.btPhaisangtrai);
            this.Controls.Add(this.btTraisangphai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btTraisangphai;
        private System.Windows.Forms.Button btPhaisangtrai;
        private System.Windows.Forms.Button btTatcaphaisangtrai;
        private System.Windows.Forms.Button btTatcatraisangphai;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btKetthuc;
    }
}

