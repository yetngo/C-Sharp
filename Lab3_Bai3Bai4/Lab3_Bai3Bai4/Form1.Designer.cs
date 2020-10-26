namespace Lab3_Bai3Bai4
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
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.txtAccessLog = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access log:";
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Location = new System.Drawing.Point(104, 13);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.PasswordChar = '*';
            this.txtSecurityCode.ReadOnly = true;
            this.txtSecurityCode.Size = new System.Drawing.Size(165, 20);
            this.txtSecurityCode.TabIndex = 2;
            this.txtSecurityCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // txtAccessLog
            // 
            this.txtAccessLog.FormattingEnabled = true;
            this.txtAccessLog.Location = new System.Drawing.Point(29, 187);
            this.txtAccessLog.Name = "txtAccessLog";
            this.txtAccessLog.Size = new System.Drawing.Size(262, 95);
            this.txtAccessLog.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(111, 53);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(27, 25);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(179, 53);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(27, 25);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            this.btn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnC.Location = new System.Drawing.Point(212, 53);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(27, 25);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(144, 53);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(29, 25);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            this.btn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(144, 84);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(29, 25);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            this.btn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(179, 84);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(27, 25);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            this.btn6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(111, 84);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(27, 25);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            this.btn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheck.Location = new System.Drawing.Point(212, 84);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(27, 25);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "#";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(212, 115);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(27, 25);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(144, 115);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(29, 25);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            this.btn8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(179, 115);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(27, 25);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            this.btn9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(111, 115);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(27, 25);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Button_Click);
            this.btn7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn0_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 333);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtAccessLog);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Button_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.ListBox txtAccessLog;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
    }
}

