namespace Lab4
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
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnListSuppliers = new System.Windows.Forms.Button();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(64, 58);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(119, 52);
            this.btnListProducts.TabIndex = 0;
            this.btnListProducts.Text = "List all Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListSuppliers
            // 
            this.btnListSuppliers.Location = new System.Drawing.Point(64, 145);
            this.btnListSuppliers.Name = "btnListSuppliers";
            this.btnListSuppliers.Size = new System.Drawing.Size(119, 54);
            this.btnListSuppliers.TabIndex = 1;
            this.btnListSuppliers.Text = "List all Suppliers";
            this.btnListSuppliers.UseVisualStyleBackColor = true;
            this.btnListSuppliers.Click += new System.EventHandler(this.btnListSuppliers_Click);
            // 
            // btnListCategories
            // 
            this.btnListCategories.Location = new System.Drawing.Point(64, 234);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(119, 54);
            this.btnListCategories.TabIndex = 2;
            this.btnListCategories.Text = "List all Categories";
            this.btnListCategories.UseVisualStyleBackColor = true;
            this.btnListCategories.Click += new System.EventHandler(this.btnListCategories_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 340);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.btnListSuppliers);
            this.Controls.Add(this.btnListProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.Button btnListSuppliers;
        private System.Windows.Forms.Button btnListCategories;
    }
}

