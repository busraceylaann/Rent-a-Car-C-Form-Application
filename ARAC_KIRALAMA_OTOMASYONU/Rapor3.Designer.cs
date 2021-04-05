namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class Rapor3
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.finalDataSet3 = new ARAC_KIRALAMA_OTOMASYONU.finalDataSet3();
            this.MUSTERI_BILGILERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MUSTERI_BILGILERITableAdapter = new ARAC_KIRALAMA_OTOMASYONU.finalDataSet3TableAdapters.MUSTERI_BILGILERITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI_BILGILERIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MUSTERI_BILGILERIBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ARAC_KIRALAMA_OTOMASYONU.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // finalDataSet3
            // 
            this.finalDataSet3.DataSetName = "finalDataSet3";
            this.finalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MUSTERI_BILGILERIBindingSource
            // 
            this.MUSTERI_BILGILERIBindingSource.DataMember = "MUSTERI_BILGILERI";
            this.MUSTERI_BILGILERIBindingSource.DataSource = this.finalDataSet3;
            // 
            // MUSTERI_BILGILERITableAdapter
            // 
            this.MUSTERI_BILGILERITableAdapter.ClearBeforeFill = true;
            // 
            // Rapor3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rapor3";
            this.Text = "Rapor3";
            this.Load += new System.EventHandler(this.Rapor3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUSTERI_BILGILERIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MUSTERI_BILGILERIBindingSource;
        private finalDataSet3 finalDataSet3;
        private finalDataSet3TableAdapters.MUSTERI_BILGILERITableAdapter MUSTERI_BILGILERITableAdapter;
    }
}