namespace Lab5Them_Bai1_Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBurgerBo = new System.Windows.Forms.Button();
            this.btnBergerGa = new System.Windows.Forms.Button();
            this.btnBurgerTom = new System.Windows.Forms.Button();
            this.btnBurgerCa = new System.Windows.Forms.Button();
            this.btnComGa = new System.Windows.Forms.Button();
            this.btnGaPhan = new System.Windows.Forms.Button();
            this.btnGaCola = new System.Windows.Forms.Button();
            this.btnTomCola = new System.Windows.Forms.Button();
            this.btnKhoaiTayChien = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btn7Up = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCam = new System.Windows.Forms.Button();
            this.btnLipton = new System.Windows.Forms.Button();
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbOrder = new System.Windows.Forms.DataGridView();
            this.btnOrder = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(184, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fastfood Order ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCam);
            this.groupBox1.Controls.Add(this.btnLipton);
            this.groupBox1.Controls.Add(this.btnCoca);
            this.groupBox1.Controls.Add(this.btnKhoaiTayChien);
            this.groupBox1.Controls.Add(this.btnCafe);
            this.groupBox1.Controls.Add(this.btn7Up);
            this.groupBox1.Controls.Add(this.btnPepsi);
            this.groupBox1.Controls.Add(this.btnComGa);
            this.groupBox1.Controls.Add(this.btnGaPhan);
            this.groupBox1.Controls.Add(this.btnGaCola);
            this.groupBox1.Controls.Add(this.btnTomCola);
            this.groupBox1.Controls.Add(this.btnBurgerCa);
            this.groupBox1.Controls.Add(this.btnBurgerTom);
            this.groupBox1.Controls.Add(this.btnBergerGa);
            this.groupBox1.Controls.Add(this.btnBurgerBo);
            this.groupBox1.Location = new System.Drawing.Point(20, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục món ăn";
            // 
            // btnBurgerBo
            // 
            this.btnBurgerBo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerBo.Location = new System.Drawing.Point(11, 28);
            this.btnBurgerBo.Name = "btnBurgerBo";
            this.btnBurgerBo.Size = new System.Drawing.Size(109, 23);
            this.btnBurgerBo.TabIndex = 0;
            this.btnBurgerBo.Text = "Burger Phô mai Bò";
            this.btnBurgerBo.UseVisualStyleBackColor = true;
            this.btnBurgerBo.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBergerGa
            // 
            this.btnBergerGa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBergerGa.Location = new System.Drawing.Point(11, 57);
            this.btnBergerGa.Name = "btnBergerGa";
            this.btnBergerGa.Size = new System.Drawing.Size(109, 23);
            this.btnBergerGa.TabIndex = 1;
            this.btnBergerGa.Text = "Burger Phô mai Gà";
            this.btnBergerGa.UseVisualStyleBackColor = true;
            this.btnBergerGa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBurgerTom
            // 
            this.btnBurgerTom.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerTom.Location = new System.Drawing.Point(11, 86);
            this.btnBurgerTom.Name = "btnBurgerTom";
            this.btnBurgerTom.Size = new System.Drawing.Size(109, 23);
            this.btnBurgerTom.TabIndex = 2;
            this.btnBurgerTom.Text = "Burger Phô mai Tôm";
            this.btnBurgerTom.UseVisualStyleBackColor = true;
            this.btnBurgerTom.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBurgerCa
            // 
            this.btnBurgerCa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBurgerCa.Location = new System.Drawing.Point(11, 115);
            this.btnBurgerCa.Name = "btnBurgerCa";
            this.btnBurgerCa.Size = new System.Drawing.Size(109, 23);
            this.btnBurgerCa.TabIndex = 3;
            this.btnBurgerCa.Text = "Burger Phô mai Cá";
            this.btnBurgerCa.UseVisualStyleBackColor = true;
            this.btnBurgerCa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnComGa
            // 
            this.btnComGa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnComGa.Location = new System.Drawing.Point(126, 115);
            this.btnComGa.Name = "btnComGa";
            this.btnComGa.Size = new System.Drawing.Size(103, 23);
            this.btnComGa.TabIndex = 7;
            this.btnComGa.Text = "Cơm gà Tender";
            this.btnComGa.UseVisualStyleBackColor = true;
            this.btnComGa.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGaPhan
            // 
            this.btnGaPhan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGaPhan.Location = new System.Drawing.Point(126, 86);
            this.btnGaPhan.Name = "btnGaPhan";
            this.btnGaPhan.Size = new System.Drawing.Size(103, 23);
            this.btnGaPhan.TabIndex = 6;
            this.btnGaPhan.Text = "Gà rán phần";
            this.btnGaPhan.UseVisualStyleBackColor = true;
            this.btnGaPhan.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnGaCola
            // 
            this.btnGaCola.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGaCola.Location = new System.Drawing.Point(126, 57);
            this.btnGaCola.Name = "btnGaCola";
            this.btnGaCola.Size = new System.Drawing.Size(103, 23);
            this.btnGaCola.TabIndex = 5;
            this.btnGaCola.Text = "Gà viên Cola";
            this.btnGaCola.UseVisualStyleBackColor = true;
            this.btnGaCola.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnTomCola
            // 
            this.btnTomCola.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTomCola.Location = new System.Drawing.Point(126, 28);
            this.btnTomCola.Name = "btnTomCola";
            this.btnTomCola.Size = new System.Drawing.Size(103, 23);
            this.btnTomCola.TabIndex = 4;
            this.btnTomCola.Text = "Tôm viên Cola";
            this.btnTomCola.UseVisualStyleBackColor = true;
            this.btnTomCola.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnKhoaiTayChien
            // 
            this.btnKhoaiTayChien.ForeColor = System.Drawing.Color.Lime;
            this.btnKhoaiTayChien.Location = new System.Drawing.Point(235, 115);
            this.btnKhoaiTayChien.Name = "btnKhoaiTayChien";
            this.btnKhoaiTayChien.Size = new System.Drawing.Size(98, 23);
            this.btnKhoaiTayChien.TabIndex = 11;
            this.btnKhoaiTayChien.Text = "Khoai tây chiên";
            this.btnKhoaiTayChien.UseVisualStyleBackColor = true;
            this.btnKhoaiTayChien.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.ForeColor = System.Drawing.Color.Red;
            this.btnCafe.Location = new System.Drawing.Point(235, 86);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(46, 23);
            this.btnCafe.TabIndex = 10;
            this.btnCafe.Text = "Cafe";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn7Up
            // 
            this.btn7Up.ForeColor = System.Drawing.Color.Red;
            this.btn7Up.Location = new System.Drawing.Point(235, 57);
            this.btn7Up.Name = "btn7Up";
            this.btn7Up.Size = new System.Drawing.Size(46, 23);
            this.btn7Up.TabIndex = 9;
            this.btn7Up.Text = "7 up";
            this.btn7Up.UseVisualStyleBackColor = true;
            this.btn7Up.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPepsi
            // 
            this.btnPepsi.ForeColor = System.Drawing.Color.Red;
            this.btnPepsi.Location = new System.Drawing.Point(235, 28);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(46, 23);
            this.btnPepsi.TabIndex = 8;
            this.btnPepsi.Text = " Pepsi";
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnCam
            // 
            this.btnCam.ForeColor = System.Drawing.Color.Red;
            this.btnCam.Location = new System.Drawing.Point(287, 86);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(46, 23);
            this.btnCam.TabIndex = 14;
            this.btnCam.Text = "Cam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnLipton
            // 
            this.btnLipton.ForeColor = System.Drawing.Color.Red;
            this.btnLipton.Location = new System.Drawing.Point(287, 57);
            this.btnLipton.Name = "btnLipton";
            this.btnLipton.Size = new System.Drawing.Size(46, 23);
            this.btnLipton.TabIndex = 13;
            this.btnLipton.Text = "Lipton";
            this.btnLipton.UseVisualStyleBackColor = true;
            this.btnLipton.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnCoca
            // 
            this.btnCoca.ForeColor = System.Drawing.Color.Red;
            this.btnCoca.Location = new System.Drawing.Point(287, 28);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(46, 23);
            this.btnCoca.TabIndex = 12;
            this.btnCoca.Text = "Coca";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(20, 280);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // tbOrder
            // 
            this.tbOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.food,
            this.num});
            this.tbOrder.Location = new System.Drawing.Point(20, 327);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(348, 150);
            this.tbOrder.TabIndex = 7;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(293, 280);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = " Order ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // food
            // 
            this.food.HeaderText = "Món ăn";
            this.food.Name = "food";
            // 
            // num
            // 
            this.num.HeaderText = "Số lượng";
            this.num.Name = "num";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 510);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.tbOrder);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Button btnLipton;
        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnKhoaiTayChien;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btn7Up;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.Button btnComGa;
        private System.Windows.Forms.Button btnGaPhan;
        private System.Windows.Forms.Button btnGaCola;
        private System.Windows.Forms.Button btnTomCola;
        private System.Windows.Forms.Button btnBurgerCa;
        private System.Windows.Forms.Button btnBurgerTom;
        private System.Windows.Forms.Button btnBergerGa;
        private System.Windows.Forms.Button btnBurgerBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView tbOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn food;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
    }
}

