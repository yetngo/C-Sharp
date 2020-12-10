
namespace LibraryProject
{
    partial class rBook
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsBook = new LibraryProject.dsBook();
            this.BooksTableAdapter = new LibraryProject.dsBookTableAdapters.BooksTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBook)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksBindingSource
            // 
            this.BooksBindingSource.DataMember = "Books";
            this.BooksBindingSource.DataSource = this.dsBook;
            // 
            // dsBook
            // 
            this.dsBook.DataSetName = "dsBook";
            this.dsBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BooksTableAdapter
            // 
            this.BooksTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BooksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryProject.rBook.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(773, 544);
            this.reportViewer1.TabIndex = 0;
            // 
            // rBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 544);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rBook";
            this.Text = "rBook";
            this.Load += new System.EventHandler(this.rBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BooksBindingSource;
        private dsBook dsBook;
        private dsBookTableAdapters.BooksTableAdapter BooksTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}