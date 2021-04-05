namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class arac_güncelleme
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
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btngüncelleme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmarka = new System.Windows.Forms.ComboBox();
            this.cbmodel = new System.Windows.Forms.ComboBox();
            this.BTNRESİMGUNCELLE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbarackırasi = new System.Windows.Forms.TextBox();
            this.lbarackirasi = new System.Windows.Forms.Label();
            this.dtpeklemetarihi = new System.Windows.Forms.DateTimePicker();
            this.tbmodelyili = new System.Windows.Forms.TextBox();
            this.cbrenk = new System.Windows.Forms.ComboBox();
            this.cbvites = new System.Windows.Forms.ComboBox();
            this.cbyakittürü = new System.Windows.Forms.ComboBox();
            this.dtpgüncellemetarihi = new System.Windows.Forms.DateTimePicker();
            this.tbmotorhacmi = new System.Windows.Forms.TextBox();
            this.tbplakano = new System.Windows.Forms.TextBox();
            this.lbmarka = new System.Windows.Forms.Label();
            this.lbmodel = new System.Windows.Forms.Label();
            this.lbmotorhacmi = new System.Windows.Forms.Label();
            this.lbyakitturu = new System.Windows.Forms.Label();
            this.lbmodelyıl = new System.Windows.Forms.Label();
            this.lbeklemetarihi = new System.Windows.Forms.Label();
            this.lbgüncellemetarihi = new System.Windows.Forms.Label();
            this.lbrenk = new System.Windows.Forms.Label();
            this.lbvitesturu = new System.Windows.Forms.Label();
            this.lbplakano = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvazgec
            // 
            this.btnvazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvazgec.Location = new System.Drawing.Point(306, 568);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(101, 39);
            this.btnvazgec.TabIndex = 6;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btngüncelleme
            // 
            this.btngüncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelleme.Location = new System.Drawing.Point(162, 568);
            this.btngüncelleme.Name = "btngüncelleme";
            this.btngüncelleme.Size = new System.Drawing.Size(117, 39);
            this.btngüncelleme.TabIndex = 5;
            this.btngüncelleme.Text = "GÜNCELLE";
            this.btngüncelleme.UseVisualStyleBackColor = true;
            this.btngüncelleme.Click += new System.EventHandler(this.btngüncelleme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvazgec);
            this.groupBox1.Controls.Add(this.cbmarka);
            this.groupBox1.Controls.Add(this.btngüncelleme);
            this.groupBox1.Controls.Add(this.cbmodel);
            this.groupBox1.Controls.Add(this.BTNRESİMGUNCELLE);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tbarackırasi);
            this.groupBox1.Controls.Add(this.lbarackirasi);
            this.groupBox1.Controls.Add(this.dtpeklemetarihi);
            this.groupBox1.Controls.Add(this.tbmodelyili);
            this.groupBox1.Controls.Add(this.cbrenk);
            this.groupBox1.Controls.Add(this.cbvites);
            this.groupBox1.Controls.Add(this.cbyakittürü);
            this.groupBox1.Controls.Add(this.dtpgüncellemetarihi);
            this.groupBox1.Controls.Add(this.tbmotorhacmi);
            this.groupBox1.Controls.Add(this.tbplakano);
            this.groupBox1.Controls.Add(this.lbmarka);
            this.groupBox1.Controls.Add(this.lbmodel);
            this.groupBox1.Controls.Add(this.lbmotorhacmi);
            this.groupBox1.Controls.Add(this.lbyakitturu);
            this.groupBox1.Controls.Add(this.lbmodelyıl);
            this.groupBox1.Controls.Add(this.lbeklemetarihi);
            this.groupBox1.Controls.Add(this.lbgüncellemetarihi);
            this.groupBox1.Controls.Add(this.lbrenk);
            this.groupBox1.Controls.Add(this.lbvitesturu);
            this.groupBox1.Controls.Add(this.lbplakano);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 613);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAÇ GÜNCELLEME";
            // 
            // cbmarka
            // 
            this.cbmarka.FormattingEnabled = true;
            this.cbmarka.Items.AddRange(new object[] {
            "BMW",
            "AUDİ",
            "FİAT",
            "VOLVO",
            "FORD",
            "PEUGEOT",
            "OPEL",
            "NİSSAN",
            "SUZUKİ",
            "HYUNDA",
            "RENAULT",
            "SKODA",
            "TOYOTA",
            "VOLKSWAGEN"});
            this.cbmarka.Location = new System.Drawing.Point(159, 99);
            this.cbmarka.Name = "cbmarka";
            this.cbmarka.Size = new System.Drawing.Size(212, 26);
            this.cbmarka.TabIndex = 39;
            this.cbmarka.SelectedIndexChanged += new System.EventHandler(this.cbmarka_SelectedIndexChanged);
            // 
            // cbmodel
            // 
            this.cbmodel.FormattingEnabled = true;
            this.cbmodel.Location = new System.Drawing.Point(159, 143);
            this.cbmodel.Name = "cbmodel";
            this.cbmodel.Size = new System.Drawing.Size(212, 26);
            this.cbmodel.TabIndex = 35;
            this.cbmodel.SelectedIndexChanged += new System.EventHandler(this.cbmodel_SelectedIndexChanged);
            // 
            // BTNRESİMGUNCELLE
            // 
            this.BTNRESİMGUNCELLE.Location = new System.Drawing.Point(542, 204);
            this.BTNRESİMGUNCELLE.Name = "BTNRESİMGUNCELLE";
            this.BTNRESİMGUNCELLE.Size = new System.Drawing.Size(112, 49);
            this.BTNRESİMGUNCELLE.TabIndex = 34;
            this.BTNRESİMGUNCELLE.Text = "RESİM GÜNCELLE";
            this.BTNRESİMGUNCELLE.UseVisualStyleBackColor = true;
            this.BTNRESİMGUNCELLE.Click += new System.EventHandler(this.BTNRESİMGUNCELLE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(504, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // tbarackırasi
            // 
            this.tbarackırasi.Location = new System.Drawing.Point(159, 501);
            this.tbarackırasi.Name = "tbarackırasi";
            this.tbarackırasi.Size = new System.Drawing.Size(212, 24);
            this.tbarackırasi.TabIndex = 31;
            // 
            // lbarackirasi
            // 
            this.lbarackirasi.AutoSize = true;
            this.lbarackirasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbarackirasi.Location = new System.Drawing.Point(14, 504);
            this.lbarackirasi.Name = "lbarackirasi";
            this.lbarackirasi.Size = new System.Drawing.Size(95, 18);
            this.lbarackirasi.TabIndex = 29;
            this.lbarackirasi.Text = "Araç Kirası:";
            // 
            // dtpeklemetarihi
            // 
            this.dtpeklemetarihi.Location = new System.Drawing.Point(159, 323);
            this.dtpeklemetarihi.Name = "dtpeklemetarihi";
            this.dtpeklemetarihi.Size = new System.Drawing.Size(212, 24);
            this.dtpeklemetarihi.TabIndex = 22;
            // 
            // tbmodelyili
            // 
            this.tbmodelyili.Location = new System.Drawing.Point(159, 274);
            this.tbmodelyili.Name = "tbmodelyili";
            this.tbmodelyili.Size = new System.Drawing.Size(212, 24);
            this.tbmodelyili.TabIndex = 21;
            this.tbmodelyili.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmodelyili_KeyPress);
            // 
            // cbrenk
            // 
            this.cbrenk.FormattingEnabled = true;
            this.cbrenk.Items.AddRange(new object[] {
            "BEYAZ",
            "SİYAH",
            "KIRMIZI",
            "MAVİ",
            "GRİ",
            "BORDO",
            "KAHVERENGİ",
            "AÇIK MAVİ",
            "TURKUAZ",
            "TURUNCU",
            "SARI",
            "MOR",
            "YEŞİL",
            "PEMBE",
            "LACİVERT"});
            this.cbrenk.Location = new System.Drawing.Point(159, 402);
            this.cbrenk.Name = "cbrenk";
            this.cbrenk.Size = new System.Drawing.Size(212, 26);
            this.cbrenk.TabIndex = 20;
            // 
            // cbvites
            // 
            this.cbvites.FormattingEnabled = true;
            this.cbvites.Items.AddRange(new object[] {
            "MANUEL",
            "OTOMATİK",
            "YARI OTOMATİK"});
            this.cbvites.Location = new System.Drawing.Point(159, 455);
            this.cbvites.Name = "cbvites";
            this.cbvites.Size = new System.Drawing.Size(212, 26);
            this.cbvites.TabIndex = 19;
            // 
            // cbyakittürü
            // 
            this.cbyakittürü.FormattingEnabled = true;
            this.cbyakittürü.Items.AddRange(new object[] {
            "BENZİN",
            "LPG",
            "DİZEL"});
            this.cbyakittürü.Location = new System.Drawing.Point(159, 232);
            this.cbyakittürü.Name = "cbyakittürü";
            this.cbyakittürü.Size = new System.Drawing.Size(212, 26);
            this.cbyakittürü.TabIndex = 18;
            // 
            // dtpgüncellemetarihi
            // 
            this.dtpgüncellemetarihi.Location = new System.Drawing.Point(159, 357);
            this.dtpgüncellemetarihi.Name = "dtpgüncellemetarihi";
            this.dtpgüncellemetarihi.Size = new System.Drawing.Size(212, 24);
            this.dtpgüncellemetarihi.TabIndex = 17;
            // 
            // tbmotorhacmi
            // 
            this.tbmotorhacmi.Location = new System.Drawing.Point(159, 187);
            this.tbmotorhacmi.Name = "tbmotorhacmi";
            this.tbmotorhacmi.Size = new System.Drawing.Size(212, 24);
            this.tbmotorhacmi.TabIndex = 12;
            this.tbmotorhacmi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmotorhacmi_KeyPress);
            // 
            // tbplakano
            // 
            this.tbplakano.Location = new System.Drawing.Point(159, 54);
            this.tbplakano.Name = "tbplakano";
            this.tbplakano.Size = new System.Drawing.Size(212, 24);
            this.tbplakano.TabIndex = 11;
            this.tbplakano.TextChanged += new System.EventHandler(this.tbplakano_TextChanged);
            // 
            // lbmarka
            // 
            this.lbmarka.AutoSize = true;
            this.lbmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmarka.Location = new System.Drawing.Point(14, 105);
            this.lbmarka.Name = "lbmarka";
            this.lbmarka.Size = new System.Drawing.Size(60, 18);
            this.lbmarka.TabIndex = 2;
            this.lbmarka.Text = "Marka:";
            // 
            // lbmodel
            // 
            this.lbmodel.AutoSize = true;
            this.lbmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmodel.Location = new System.Drawing.Point(16, 149);
            this.lbmodel.Name = "lbmodel";
            this.lbmodel.Size = new System.Drawing.Size(59, 18);
            this.lbmodel.TabIndex = 3;
            this.lbmodel.Text = "Model:";
            // 
            // lbmotorhacmi
            // 
            this.lbmotorhacmi.AutoSize = true;
            this.lbmotorhacmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmotorhacmi.Location = new System.Drawing.Point(11, 187);
            this.lbmotorhacmi.Name = "lbmotorhacmi";
            this.lbmotorhacmi.Size = new System.Drawing.Size(111, 18);
            this.lbmotorhacmi.TabIndex = 4;
            this.lbmotorhacmi.Text = "Motor Hacmi:";
            // 
            // lbyakitturu
            // 
            this.lbyakitturu.AutoSize = true;
            this.lbyakitturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbyakitturu.Location = new System.Drawing.Point(11, 235);
            this.lbyakitturu.Name = "lbyakitturu";
            this.lbyakitturu.Size = new System.Drawing.Size(89, 18);
            this.lbyakitturu.TabIndex = 5;
            this.lbyakitturu.Text = "Yakıt Türü:";
            // 
            // lbmodelyıl
            // 
            this.lbmodelyıl.AutoSize = true;
            this.lbmodelyıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbmodelyıl.Location = new System.Drawing.Point(16, 279);
            this.lbmodelyıl.Name = "lbmodelyıl";
            this.lbmodelyıl.Size = new System.Drawing.Size(86, 18);
            this.lbmodelyıl.TabIndex = 6;
            this.lbmodelyıl.Text = "Model Yılı:";
            // 
            // lbeklemetarihi
            // 
            this.lbeklemetarihi.AutoSize = true;
            this.lbeklemetarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbeklemetarihi.Location = new System.Drawing.Point(11, 323);
            this.lbeklemetarihi.Name = "lbeklemetarihi";
            this.lbeklemetarihi.Size = new System.Drawing.Size(116, 18);
            this.lbeklemetarihi.TabIndex = 7;
            this.lbeklemetarihi.Text = "Ekleme Tarihi:";
            // 
            // lbgüncellemetarihi
            // 
            this.lbgüncellemetarihi.AutoSize = true;
            this.lbgüncellemetarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbgüncellemetarihi.Location = new System.Drawing.Point(11, 357);
            this.lbgüncellemetarihi.Name = "lbgüncellemetarihi";
            this.lbgüncellemetarihi.Size = new System.Drawing.Size(149, 18);
            this.lbgüncellemetarihi.TabIndex = 8;
            this.lbgüncellemetarihi.Text = "Güncelleme Tarihi:";
            // 
            // lbrenk
            // 
            this.lbrenk.AutoSize = true;
            this.lbrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbrenk.Location = new System.Drawing.Point(23, 409);
            this.lbrenk.Name = "lbrenk";
            this.lbrenk.Size = new System.Drawing.Size(52, 18);
            this.lbrenk.TabIndex = 9;
            this.lbrenk.Text = "Renk:";
            // 
            // lbvitesturu
            // 
            this.lbvitesturu.AutoSize = true;
            this.lbvitesturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbvitesturu.Location = new System.Drawing.Point(18, 462);
            this.lbvitesturu.Name = "lbvitesturu";
            this.lbvitesturu.Size = new System.Drawing.Size(89, 18);
            this.lbvitesturu.TabIndex = 10;
            this.lbvitesturu.Text = "Vites Türü:";
            // 
            // lbplakano
            // 
            this.lbplakano.AutoSize = true;
            this.lbplakano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbplakano.Location = new System.Drawing.Point(14, 56);
            this.lbplakano.Name = "lbplakano";
            this.lbplakano.Size = new System.Drawing.Size(82, 18);
            this.lbplakano.TabIndex = 0;
            this.lbplakano.Text = "Plaka No:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // arac_güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 637);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "arac_güncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arac_güncelleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.arac_güncelleme_FormClosed);
            this.Load += new System.EventHandler(this.arac_güncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btngüncelleme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpeklemetarihi;
        private System.Windows.Forms.TextBox tbmodelyili;
        private System.Windows.Forms.ComboBox cbrenk;
        private System.Windows.Forms.ComboBox cbvites;
        private System.Windows.Forms.ComboBox cbyakittürü;
        private System.Windows.Forms.DateTimePicker dtpgüncellemetarihi;
        private System.Windows.Forms.TextBox tbmotorhacmi;
        private System.Windows.Forms.TextBox tbplakano;
        private System.Windows.Forms.Label lbmarka;
        private System.Windows.Forms.Label lbmodel;
        private System.Windows.Forms.Label lbmotorhacmi;
        private System.Windows.Forms.Label lbyakitturu;
        private System.Windows.Forms.Label lbmodelyıl;
        private System.Windows.Forms.Label lbeklemetarihi;
        private System.Windows.Forms.Label lbgüncellemetarihi;
        private System.Windows.Forms.Label lbrenk;
        private System.Windows.Forms.Label lbvitesturu;
        private System.Windows.Forms.Label lbplakano;
        private System.Windows.Forms.Button BTNRESİMGUNCELLE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbarackırasi;
        private System.Windows.Forms.Label lbarackirasi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cbmodel;
        private System.Windows.Forms.ComboBox cbmarka;
    }
}