namespace Lab4Them_Bai4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.errSonguyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(108, 26);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(136, 20);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(284, 25);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 2;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.Location = new System.Drawing.Point(19, 69);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(120, 290);
            this.lstKetqua.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btXoaphantudau);
            this.groupBox1.Controls.Add(this.btXoaphantudangchon);
            this.groupBox1.Controls.Add(this.btLecuoi);
            this.groupBox1.Controls.Add(this.btChonchandau);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Location = new System.Drawing.Point(172, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.Location = new System.Drawing.Point(20, 235);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(147, 23);
            this.btXoaphantucuoi.TabIndex = 5;
            this.btXoaphantucuoi.Text = "xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.Location = new System.Drawing.Point(20, 193);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(147, 23);
            this.btXoaphantudau.TabIndex = 4;
            this.btXoaphantudau.Text = "xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = true;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.Location = new System.Drawing.Point(20, 152);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(147, 23);
            this.btXoaphantudangchon.TabIndex = 3;
            this.btXoaphantudangchon.Text = "xóa phần tử đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.Location = new System.Drawing.Point(20, 111);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(147, 23);
            this.btLecuoi.TabIndex = 2;
            this.btLecuoi.Text = "chọn số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = true;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.Location = new System.Drawing.Point(20, 70);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(147, 23);
            this.btChonchandau.TabIndex = 1;
            this.btChonchandau.Text = "chọn số chẵn đầu";
            this.btChonchandau.UseVisualStyleBackColor = true;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btTang2
            // 
            this.btTang2.Location = new System.Drawing.Point(20, 30);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(147, 23);
            this.btTang2.TabIndex = 0;
            this.btTang2.Text = "tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.Location = new System.Drawing.Point(69, 376);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(234, 23);
            this.btKetthuc.TabIndex = 5;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = true;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // errSonguyen
            // 
            this.errSonguyen.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 411);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btKetthuc;
        private System.Windows.Forms.ErrorProvider errSonguyen;
    }
}

