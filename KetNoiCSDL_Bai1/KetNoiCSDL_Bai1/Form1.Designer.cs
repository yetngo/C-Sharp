namespace KetNoiCSDL_Bai1
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
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.btnDongkn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(64, 63);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(174, 23);
            this.btnKetNoi.TabIndex = 0;
            this.btnKetNoi.Text = "Kết Nói CSDL";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // btnDongkn
            // 
            this.btnDongkn.Location = new System.Drawing.Point(64, 160);
            this.btnDongkn.Name = "btnDongkn";
            this.btnDongkn.Size = new System.Drawing.Size(174, 23);
            this.btnDongkn.TabIndex = 1;
            this.btnDongkn.Text = "Đóng Kết Nối CSDL";
            this.btnDongkn.UseVisualStyleBackColor = true;
            this.btnDongkn.Click += new System.EventHandler(this.btnDongkn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 267);
            this.Controls.Add(this.btnDongkn);
            this.Controls.Add(this.btnKetNoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Button btnDongkn;
    }
}

