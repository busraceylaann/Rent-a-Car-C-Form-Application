namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class personel_güncelleme_formu
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
            this.lbtc = new System.Windows.Forms.Label();
            this.lbadi = new System.Windows.Forms.Label();
            this.lbsoyadi = new System.Windows.Forms.Label();
            this.lbgsm = new System.Windows.Forms.Label();
            this.lbcinsiyet = new System.Windows.Forms.Label();
            this.lbadres = new System.Windows.Forms.Label();
            this.tbacikadres = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbgsm = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbmaas = new System.Windows.Forms.TextBox();
            this.lbmaas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbtc
            // 
            this.lbtc.AutoSize = true;
            this.lbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbtc.Location = new System.Drawing.Point(6, 52);
            this.lbtc.Name = "lbtc";
            this.lbtc.Size = new System.Drawing.Size(109, 18);
            this.lbtc.TabIndex = 0;
            this.lbtc.Text = "Tc Kimlik Nu:";
            // 
            // lbadi
            // 
            this.lbadi.AutoSize = true;
            this.lbadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbadi.Location = new System.Drawing.Point(6, 95);
            this.lbadi.Name = "lbadi";
            this.lbadi.Size = new System.Drawing.Size(36, 18);
            this.lbadi.TabIndex = 1;
            this.lbadi.Text = "Adı:";
            // 
            // lbsoyadi
            // 
            this.lbsoyadi.AutoSize = true;
            this.lbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsoyadi.Location = new System.Drawing.Point(6, 147);
            this.lbsoyadi.Name = "lbsoyadi";
            this.lbsoyadi.Size = new System.Drawing.Size(64, 18);
            this.lbsoyadi.TabIndex = 2;
            this.lbsoyadi.Text = "Soyadı:";
            // 
            // lbgsm
            // 
            this.lbgsm.AutoSize = true;
            this.lbgsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbgsm.Location = new System.Drawing.Point(6, 203);
            this.lbgsm.Name = "lbgsm";
            this.lbgsm.Size = new System.Drawing.Size(81, 18);
            this.lbgsm.TabIndex = 5;
            this.lbgsm.Text = "GSM NO:";
            // 
            // lbcinsiyet
            // 
            this.lbcinsiyet.AutoSize = true;
            this.lbcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbcinsiyet.Location = new System.Drawing.Point(6, 251);
            this.lbcinsiyet.Name = "lbcinsiyet";
            this.lbcinsiyet.Size = new System.Drawing.Size(73, 18);
            this.lbcinsiyet.TabIndex = 7;
            this.lbcinsiyet.Text = "Cinsiyet:";
            // 
            // lbadres
            // 
            this.lbadres.AutoSize = true;
            this.lbadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbadres.Location = new System.Drawing.Point(6, 305);
            this.lbadres.Name = "lbadres";
            this.lbadres.Size = new System.Drawing.Size(111, 18);
            this.lbadres.TabIndex = 16;
            this.lbadres.Text = "AÇIK ADRES:";
            // 
            // tbacikadres
            // 
            this.tbacikadres.Location = new System.Drawing.Point(142, 305);
            this.tbacikadres.Multiline = true;
            this.tbacikadres.Name = "tbacikadres";
            this.tbacikadres.Size = new System.Drawing.Size(202, 77);
            this.tbacikadres.TabIndex = 19;
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
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(142, 101);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(202, 24);
            this.tbadi.TabIndex = 21;
            this.tbadi.TextChanged += new System.EventHandler(this.tbadi_TextChanged);
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(142, 147);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(202, 24);
            this.tbsoyadi.TabIndex = 22;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // tbgsm
            // 
            this.tbgsm.Location = new System.Drawing.Point(142, 198);
            this.tbgsm.Name = "tbgsm";
            this.tbgsm.Size = new System.Drawing.Size(202, 24);
            this.tbgsm.TabIndex = 25;
            this.tbgsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbgsm_KeyPress);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(118, 494);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(129, 47);
            this.btnkaydet.TabIndex = 32;
            this.btnkaydet.Text = "GÜNCELLE";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvazgec.Location = new System.Drawing.Point(274, 494);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(105, 47);
            this.btnvazgec.TabIndex = 33;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbmaas);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.btnvazgec);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 575);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL  BİLGİLERİ";
            // 
            // tbmaas
            // 
            this.tbmaas.Location = new System.Drawing.Point(142, 415);
            this.tbmaas.Name = "tbmaas";
            this.tbmaas.Size = new System.Drawing.Size(202, 24);
            this.tbmaas.TabIndex = 36;
            this.tbmaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmaas_KeyPress);
            // 
            // lbmaas
            // 
            this.lbmaas.AutoSize = true;
            this.lbmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmaas.Location = new System.Drawing.Point(29, 419);
            this.lbmaas.Name = "lbmaas";
            this.lbmaas.Size = new System.Drawing.Size(58, 18);
            this.lbmaas.TabIndex = 35;
            this.lbmaas.Text = "MAAŞ:";
            // 
            // personel_güncelleme_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(553, 630);
            this.Controls.Add(this.groupBox1);
            this.Name = "personel_güncelleme_formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel_güncelleme_formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.personel_güncelleme_formu_FormClosed);
            this.Load += new System.EventHandler(this.personel_güncelleme_formu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbtc;
        private System.Windows.Forms.Label lbadi;
        private System.Windows.Forms.Label lbsoyadi;
        private System.Windows.Forms.Label lbgsm;
        private System.Windows.Forms.Label lbcinsiyet;
        private System.Windows.Forms.Label lbadres;
        private System.Windows.Forms.TextBox tbacikadres;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbgsm;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbmaas;
        private System.Windows.Forms.Label lbmaas;
    }
}