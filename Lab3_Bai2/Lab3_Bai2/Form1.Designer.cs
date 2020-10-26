namespace Lab3_Bai2
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.rbUSCLN = new System.Windows.Forms.RadioButton();
            this.rbBSCNN = new System.Windows.Forms.RadioButton();
            this.btTim = new System.Windows.Forms.Button();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(63, 18);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(168, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(63, 48);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(168, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(63, 19);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(225, 20);
            this.txtKetQua.TabIndex = 0;
            // 
            // rbUSCLN
            // 
            this.rbUSCLN.AutoSize = true;
            this.rbUSCLN.Checked = true;
            this.rbUSCLN.Location = new System.Drawing.Point(21, 21);
            this.rbUSCLN.Name = "rbUSCLN";
            this.rbUSCLN.Size = new System.Drawing.Size(64, 17);
            this.rbUSCLN.TabIndex = 0;
            this.rbUSCLN.TabStop = true;
            this.rbUSCLN.Text = "USCLN ";
            this.rbUSCLN.UseVisualStyleBackColor = true;
            // 
            // rbBSCNN
            // 
            this.rbBSCNN.AutoSize = true;
            this.rbBSCNN.Location = new System.Drawing.Point(21, 51);
            this.rbBSCNN.Name = "rbBSCNN";
            this.rbBSCNN.Size = new System.Drawing.Size(62, 17);
            this.rbBSCNN.TabIndex = 1;
            this.rbBSCNN.TabStop = true;
            this.rbBSCNN.Text = "BSCNN";
            this.rbBSCNN.UseVisualStyleBackColor = true;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(25, 64);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 1;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btBoQua
            // 
            this.btBoQua.Location = new System.Drawing.Point(144, 64);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(75, 23);
            this.btBoQua.TabIndex = 2;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(263, 62);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(70, 25);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbUSCLN);
            this.groupBox2.Controls.Add(this.rbBSCNN);
            this.groupBox2.Location = new System.Drawing.Point(264, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Tìm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetQua);
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.btTim);
            this.groupBox3.Controls.Add(this.btBoQua);
            this.groupBox3.Location = new System.Drawing.Point(1, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 210);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.RadioButton rbUSCLN;
        private System.Windows.Forms.RadioButton rbBSCNN;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

