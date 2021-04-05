namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class personel_yeni_kayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbmaas = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.lbmaas = new System.Windows.Forms.Label();
            this.lbtc = new System.Windows.Forms.Label();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.tbacikadres = new System.Windows.Forms.TextBox();
            this.lbadi = new System.Windows.Forms.Label();
            this.lbadres = new System.Windows.Forms.Label();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.lbsoyadi = new System.Windows.Forms.Label();
            this.tbgsm = new System.Windows.Forms.TextBox();
            this.lbcinsiyet = new System.Windows.Forms.Label();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.lbgsm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbmaas);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.lbmaas);
            this.groupBox1.Controls.Add(this.lbtc);
            this.groupBox1.Controls.Add(this.cbcinsiyet);
            this.groupBox1.Controls.Add(this.tbtc);
            this.groupBox1.Controls.Add(this.tbacikadres);
            this.groupBox1.Controls.Add(this.lbadi);
            this.groupBox1.Controls.Add(this.lbadres);
            this.groupBox1.Controls.Add(this.tbadi);
            this.groupBox1.Controls.Add(this.lbsoyadi);
            this.groupBox1.Controls.Add(this.tbgsm);
            this.groupBox1.Controls.Add(this.lbcinsiyet);
            this.groupBox1.Controls.Add(this.tbsoyadi);
            this.groupBox1.Controls.Add(this.lbgsm);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 570);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL  BİLGİLERİ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(265, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 46);
            this.button2.TabIndex = 38;
            this.button2.Text = "VAZGEÇ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbmaas
            // 
            this.tbmaas.Location = new System.Drawing.Point(142, 412);
            this.tbmaas.Name = "tbmaas";
            this.tbmaas.Size = new System.Drawing.Size(202, 24);
            this.tbmaas.TabIndex = 36;
            this.tbmaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaas_KeyPress);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(142, 484);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(106, 46);
            this.btnkaydet.TabIndex = 37;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click_1);
            // 
            // lbmaas
            // 
            this.lbmaas.AutoSize = true;
            this.lbmaas.Location = new System.Drawing.Point(12, 412);
            this.lbmaas.Name = "lbmaas";
            this.lbmaas.Size = new System.Drawing.Size(58, 18);
            this.lbmaas.TabIndex = 35;
            this.lbmaas.Text = "MAAŞ:";
            // 
            // lbtc
            // 
            this.lbtc.AutoSize = true;
            this.lbtc.Location = new System.Drawing.Point(6, 52);
            this.lbtc.Name = "lbtc";
            this.lbtc.Size = new System.Drawing.Size(109, 18);
            this.lbtc.TabIndex = 0;
            this.lbtc.Text = "Tc Kimlik Nu:";
            // 
            // cbcinsiyet
            // 
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Items.AddRange(new object[] {
            "kadın",
            "erkek"});
            this.cbcinsiyet.Location = new System.Drawing.Point(142, 248);
            this.cbcinsiyet.Name = "cbcinsiyet";
            this.cbcinsiyet.Size = new System.Drawing.Size(202, 26);
            this.cbcinsiyet.TabIndex = 34;
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(142, 52);
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(202, 24);
            this.tbtc.TabIndex = 20;
            this.tbtc.TextChanged += new System.EventHandler(this.tbtc_TextChanged);
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // tbacikadres
            // 
            this.tbacikadres.Location = new System.Drawing.Point(142, 305);
            this.tbacikadres.Multiline = true;
            this.tbacikadres.Name = "tbacikadres";
            this.tbacikadres.Size = new System.Drawing.Size(202, 77);
            this.tbacikadres.TabIndex = 19;
            // 
            // lbadi
            // 
            this.lbadi.AutoSize = true;
            this.lbadi.Location = new System.Drawing.Point(6, 95);
            this.lbadi.Name = "lbadi";
            this.lbadi.Size = new System.Drawing.Size(36, 18);
            this.lbadi.TabIndex = 1;
            this.lbadi.Text = "Adı:";
            // 
            // lbadres
            // 
            this.lbadres.AutoSize = true;
            this.lbadres.Location = new System.Drawing.Point(6, 305);
            this.lbadres.Name = "lbadres";
            this.lbadres.Size = new System.Drawing.Size(111, 18);
            this.lbadres.TabIndex = 16;
            this.lbadres.Text = "AÇIK ADRES:";
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(142, 101);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(202, 24);
            this.tbadi.TabIndex = 21;
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // lbsoyadi
            // 
            this.lbsoyadi.AutoSize = true;
            this.lbsoyadi.Location = new System.Drawing.Point(6, 147);
            this.lbsoyadi.Name = "lbsoyadi";
            this.lbsoyadi.Size = new System.Drawing.Size(64, 18);
            this.lbsoyadi.TabIndex = 2;
            this.lbsoyadi.Text = "Soyadı:";
            // 
            // tbgsm
            // 
            this.tbgsm.Location = new System.Drawing.Point(142, 198);
            this.tbgsm.Name = "tbgsm";
            this.tbgsm.Size = new System.Drawing.Size(202, 24);
            this.tbgsm.TabIndex = 25;
            this.tbgsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbgsm_KeyPress);
            // 
            // lbcinsiyet
            // 
            this.lbcinsiyet.AutoSize = true;
            this.lbcinsiyet.Location = new System.Drawing.Point(6, 251);
            this.lbcinsiyet.Name = "lbcinsiyet";
            this.lbcinsiyet.Size = new System.Drawing.Size(73, 18);
            this.lbcinsiyet.TabIndex = 7;
            this.lbcinsiyet.Text = "Cinsiyet:";
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(142, 147);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(202, 24);
            this.tbsoyadi.TabIndex = 22;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // lbgsm
            // 
            this.lbgsm.AutoSize = true;
            this.lbgsm.Location = new System.Drawing.Point(6, 203);
            this.lbgsm.Name = "lbgsm";
            this.lbgsm.Size = new System.Drawing.Size(81, 18);
            this.lbgsm.TabIndex = 5;
            this.lbgsm.Text = "GSM NO:";
            // 
            // personel_yeni_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(603, 640);
            this.Controls.Add(this.groupBox1);
            this.Name = "personel_yeni_kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel_yeni_kayit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.personel_yeni_kayit_FormClosed);
            this.Load += new System.EventHandler(this.personel_yeni_kayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbmaas;
        private System.Windows.Forms.Label lbmaas;
        private System.Windows.Forms.Label lbtc;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.TextBox tbacikadres;
        private System.Windows.Forms.Label lbadi;
        private System.Windows.Forms.Label lbadres;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.Label lbsoyadi;
        private System.Windows.Forms.TextBox tbgsm;
        private System.Windows.Forms.Label lbcinsiyet;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.Label lbgsm;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button button2;
    }
}