namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class müsteri_kayıt_formu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.cbacikadres = new System.Windows.Forms.TextBox();
            this.tbgsm = new System.Windows.Forms.TextBox();
            this.tbil = new System.Windows.Forms.TextBox();
            this.cbcinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.tbdogumyeri = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbtc = new System.Windows.Forms.TextBox();
            this.lbacikadres = new System.Windows.Forms.Label();
            this.lbgsm = new System.Windows.Forms.Label();
            this.lbil = new System.Windows.Forms.Label();
            this.lbcinsiyet = new System.Windows.Forms.Label();
            this.lbdogumtarihi = new System.Windows.Forms.Label();
            this.lbdogumyeri = new System.Windows.Forms.Label();
            this.lbsoyadı = new System.Windows.Forms.Label();
            this.lbadi = new System.Windows.Forms.Label();
            this.lbtc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.btnvazgec);
            this.groupBox1.Controls.Add(this.cbacikadres);
            this.groupBox1.Controls.Add(this.tbgsm);
            this.groupBox1.Controls.Add(this.tbil);
            this.groupBox1.Controls.Add(this.cbcinsiyet);
            this.groupBox1.Controls.Add(this.dtpdogumtarihi);
            this.groupBox1.Controls.Add(this.tbdogumyeri);
            this.groupBox1.Controls.Add(this.tbsoyadi);
            this.groupBox1.Controls.Add(this.tbadi);
            this.groupBox1.Controls.Add(this.tbtc);
            this.groupBox1.Controls.Add(this.lbacikadres);
            this.groupBox1.Controls.Add(this.lbgsm);
            this.groupBox1.Controls.Add(this.lbil);
            this.groupBox1.Controls.Add(this.lbcinsiyet);
            this.groupBox1.Controls.Add(this.lbdogumtarihi);
            this.groupBox1.Controls.Add(this.lbdogumyeri);
            this.groupBox1.Controls.Add(this.lbsoyadı);
            this.groupBox1.Controls.Add(this.lbadi);
            this.groupBox1.Controls.Add(this.lbtc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 639);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ KAYIT FORMU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "YAŞINIZ 20\'DEN BÜYÜK\r\n OLMALIDIR!";
            this.label1.Visible = false;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(141, 528);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(99, 46);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvazgec.Location = new System.Drawing.Point(261, 528);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(99, 43);
            this.btnvazgec.TabIndex = 2;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // cbacikadres
            // 
            this.cbacikadres.Location = new System.Drawing.Point(147, 388);
            this.cbacikadres.Multiline = true;
            this.cbacikadres.Name = "cbacikadres";
            this.cbacikadres.Size = new System.Drawing.Size(200, 98);
            this.cbacikadres.TabIndex = 17;
            // 
            // tbgsm
            // 
            this.tbgsm.Location = new System.Drawing.Point(147, 343);
            this.tbgsm.Name = "tbgsm";
            this.tbgsm.Size = new System.Drawing.Size(200, 24);
            this.tbgsm.TabIndex = 16;
            this.tbgsm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbgsm_KeyPress);
            // 
            // tbil
            // 
            this.tbil.Location = new System.Drawing.Point(147, 296);
            this.tbil.Name = "tbil";
            this.tbil.Size = new System.Drawing.Size(200, 24);
            this.tbil.TabIndex = 15;
            // 
            // cbcinsiyet
            // 
            this.cbcinsiyet.FormattingEnabled = true;
            this.cbcinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cbcinsiyet.Location = new System.Drawing.Point(147, 247);
            this.cbcinsiyet.Name = "cbcinsiyet";
            this.cbcinsiyet.Size = new System.Drawing.Size(200, 26);
            this.cbcinsiyet.TabIndex = 14;
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Location = new System.Drawing.Point(147, 206);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(200, 24);
            this.dtpdogumtarihi.TabIndex = 13;
            this.dtpdogumtarihi.ValueChanged += new System.EventHandler(this.dtpdogumtarihi_ValueChanged);
            // 
            // tbdogumyeri
            // 
            this.tbdogumyeri.Location = new System.Drawing.Point(147, 166);
            this.tbdogumyeri.Name = "tbdogumyeri";
            this.tbdogumyeri.Size = new System.Drawing.Size(200, 24);
            this.tbdogumyeri.TabIndex = 12;
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(147, 123);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(200, 24);
            this.tbsoyadi.TabIndex = 11;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(147, 77);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(200, 24);
            this.tbadi.TabIndex = 10;
            this.tbadi.TextChanged += new System.EventHandler(this.tbadi_TextChanged);
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(147, 36);
            this.tbtc.Name = "tbtc";
            this.tbtc.Size = new System.Drawing.Size(200, 24);
            this.tbtc.TabIndex = 9;
            this.tbtc.TextChanged += new System.EventHandler(this.tbtc_TextChanged);
            this.tbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtc_KeyPress);
            // 
            // lbacikadres
            // 
            this.lbacikadres.AutoSize = true;
            this.lbacikadres.Location = new System.Drawing.Point(24, 378);
            this.lbacikadres.Name = "lbacikadres";
            this.lbacikadres.Size = new System.Drawing.Size(111, 18);
            this.lbacikadres.TabIndex = 8;
            this.lbacikadres.Text = "AÇIK ADRES:";
            // 
            // lbgsm
            // 
            this.lbgsm.AutoSize = true;
            this.lbgsm.Location = new System.Drawing.Point(24, 343);
            this.lbgsm.Name = "lbgsm";
            this.lbgsm.Size = new System.Drawing.Size(81, 18);
            this.lbgsm.TabIndex = 7;
            this.lbgsm.Text = "GSM NO:";
            // 
            // lbil
            // 
            this.lbil.AutoSize = true;
            this.lbil.Location = new System.Drawing.Point(24, 299);
            this.lbil.Name = "lbil";
            this.lbil.Size = new System.Drawing.Size(26, 18);
            this.lbil.TabIndex = 6;
            this.lbil.Text = "İL:";
            // 
            // lbcinsiyet
            // 
            this.lbcinsiyet.AutoSize = true;
            this.lbcinsiyet.Location = new System.Drawing.Point(10, 247);
            this.lbcinsiyet.Name = "lbcinsiyet";
            this.lbcinsiyet.Size = new System.Drawing.Size(87, 18);
            this.lbcinsiyet.TabIndex = 5;
            this.lbcinsiyet.Text = "CİNSİYET:";
            // 
            // lbdogumtarihi
            // 
            this.lbdogumtarihi.AutoSize = true;
            this.lbdogumtarihi.Location = new System.Drawing.Point(7, 207);
            this.lbdogumtarihi.Name = "lbdogumtarihi";
            this.lbdogumtarihi.Size = new System.Drawing.Size(134, 18);
            this.lbdogumtarihi.TabIndex = 4;
            this.lbdogumtarihi.Text = "DOĞUM TARİHİ:";
            // 
            // lbdogumyeri
            // 
            this.lbdogumyeri.AutoSize = true;
            this.lbdogumyeri.Location = new System.Drawing.Point(7, 166);
            this.lbdogumyeri.Name = "lbdogumyeri";
            this.lbdogumyeri.Size = new System.Drawing.Size(119, 18);
            this.lbdogumyeri.TabIndex = 3;
            this.lbdogumyeri.Text = "DOĞUM YERİ:";
            // 
            // lbsoyadı
            // 
            this.lbsoyadı.AutoSize = true;
            this.lbsoyadı.Location = new System.Drawing.Point(7, 123);
            this.lbsoyadı.Name = "lbsoyadı";
            this.lbsoyadı.Size = new System.Drawing.Size(73, 18);
            this.lbsoyadı.TabIndex = 2;
            this.lbsoyadı.Text = "SOYADI:";
            // 
            // lbadi
            // 
            this.lbadi.AutoSize = true;
            this.lbadi.Location = new System.Drawing.Point(6, 80);
            this.lbadi.Name = "lbadi";
            this.lbadi.Size = new System.Drawing.Size(39, 18);
            this.lbadi.TabIndex = 1;
            this.lbadi.Text = "ADI:";
            // 
            // lbtc
            // 
            this.lbtc.AutoSize = true;
            this.lbtc.Location = new System.Drawing.Point(6, 39);
            this.lbtc.Name = "lbtc";
            this.lbtc.Size = new System.Drawing.Size(93, 18);
            this.lbtc.TabIndex = 0;
            this.lbtc.Text = "TC KİMLİK:";
            // 
            // müsteri_kayıt_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(640, 663);
            this.Controls.Add(this.groupBox1);
            this.Name = "müsteri_kayıt_formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "müsteri_kayıt_formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.müsteri_kayıt_formu_FormClosed);
            this.Load += new System.EventHandler(this.müsteri_kayıt_formu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cbacikadres;
        private System.Windows.Forms.TextBox tbgsm;
        private System.Windows.Forms.TextBox tbil;
        private System.Windows.Forms.ComboBox cbcinsiyet;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.TextBox tbdogumyeri;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbtc;
        private System.Windows.Forms.Label lbacikadres;
        private System.Windows.Forms.Label lbgsm;
        private System.Windows.Forms.Label lbil;
        private System.Windows.Forms.Label lbcinsiyet;
        private System.Windows.Forms.Label lbdogumtarihi;
        private System.Windows.Forms.Label lbdogumyeri;
        private System.Windows.Forms.Label lbsoyadı;
        private System.Windows.Forms.Label lbadi;
        private System.Windows.Forms.Label lbtc;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Label label1;
    }
}