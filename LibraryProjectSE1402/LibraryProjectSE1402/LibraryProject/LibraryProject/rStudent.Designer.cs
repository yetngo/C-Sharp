
namespace LibraryProject
{
    partial class rStudent
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
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsStudent = new LibraryProject.dsStudent();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentTableAdapter = new LibraryProject.dsStudentTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataMember = "Student";
            this.StudentBindingSource.DataSource = this.dsStudent;
            // 
            // dsStudent
            // 
            this.dsStudent.DataSetName = "dsStudent";
            this.dsStudent.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibraryProject.rStudent.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(822, 589);
            this.reportViewer1.TabIndex = 0;
            // 
            // StudentTableAdapter
            // 
            this.StudentTableAdapter.ClearBeforeFill = true;
            // 
            // rStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 589);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rStudent";
            this.Text = "rStudent";
            this.Load += new System.EventHandler(this.rStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private dsStudent dsStudent;
        private dsStudentTableAdapters.StudentTableAdapter StudentTableAdapter;
    }
}