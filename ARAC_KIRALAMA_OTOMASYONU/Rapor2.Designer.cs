namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class Rapor2
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
            this.finalDataSet2 = new ARAC_KIRALAMA_OTOMASYONU.finalDataSet2();
            this.ARAC_KIRALAMABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARAC_KIRALAMATableAdapter = new ARAC_KIRALAMA_OTOMASYONU.finalDataSet2TableAdapters.ARAC_KIRALAMATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ARAC_KIRALAMABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ARAC_KIRALAMA_OTOMASYONU.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // finalDataSet2
            // 
            this.finalDataSet2.DataSetName = "finalDataSet2";
            this.finalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ARAC_KIRALAMABindingSource
            // 
            this.ARAC_KIRALAMABindingSource.DataMember = "ARAC_KIRALAMA";
            this.ARAC_KIRALAMABindingSource.DataSource = this.finalDataSet2;
            // 
            // ARAC_KIRALAMATableAdapter
            // 
            this.ARAC_KIRALAMATableAdapter.ClearBeforeFill = true;
            // 
            // Rapor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rapor2";
            this.Text = "Rapor2";
            this.Load += new System.EventHandler(this.Rapor2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARAC_KIRALAMABindingSource;
        private finalDataSet2 finalDataSet2;
        private finalDataSet2TableAdapters.ARAC_KIRALAMATableAdapter ARAC_KIRALAMATableAdapter;
    }
}