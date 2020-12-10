
namespace LibraryProject
{
    partial class rLog
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
            this.LogLibsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLog = new LibraryProject.dsLog();
            this.LogLibsTableAdapter = new LibraryProject.dsLogTableAdapters.LogLibsTableAdapter();
            this.dsBook = new LibraryProject.dsBook();
            this.BooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BooksTableAdapter = new LibraryProject.dsBookTableAdapters.BooksTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LogLibsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogLibsBindingSource
            // 
            this.LogLibsBindingSource.DataMember = "LogLibs";
            this.LogLibsBindingSource.DataSource = this.dsLog;
            // 
            // dsLog
            // 
            this.dsLog.DataSetName = "dsLog";
            this.dsLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LogLibsTableAdapter
            // 
            this.LogLibsTableAdapter.ClearBeforeFill = true;
            // 
            // dsBook
            // 
            this.dsBook.DataSetName = "dsBook";
            this.dsBook.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BooksBindingSource
            // 
            this.BooksBindingSource.DataMember = "Books";
            this.BooksBindingSource.DataSource = this.dsBook;
            // 
            // BooksTableAdapter
            // 
            this.BooksTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LogLibsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryProject.rLog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(847, 563);
            this.reportViewer1.TabIndex = 0;
            // 
            // rLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 563);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rLog";
            this.Text = "rLog";
            this.Load += new System.EventHandler(this.rLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogLibsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource LogLibsBindingSource;
        private dsLog dsLog;
        private dsLogTableAdapters.LogLibsTableAdapter LogLibsTableAdapter;
        private System.Windows.Forms.BindingSource BooksBindingSource;
        private dsBook dsBook;
        private dsBookTableAdapters.BooksTableAdapter BooksTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}