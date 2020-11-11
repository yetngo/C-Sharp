namespace KetNoiCSDL_Bai1
{
    partial class Form2
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
            this.btSoSV = new System.Windows.Forms.Button();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSoSV
            // 
            this.btSoSV.Location = new System.Drawing.Point(59, 101);
            this.btSoSV.Name = "btSoSV";
            this.btSoSV.Size = new System.Drawing.Size(163, 48);
            this.btSoSV.TabIndex = 0;
            this.btSoSV.Text = "Tính Số lượng sinh viên";
            this.btSoSV.UseVisualStyleBackColor = true;
            this.btSoSV.Click += new System.EventHandler(this.btSoSV_Click);
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(266, 119);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(13, 13);
            this.lblSoluong.TabIndex = 1;
            this.lblSoluong.Text = "?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 250);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.btSoSV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSoSV;
        private System.Windows.Forms.Label lblSoluong;
    }
}