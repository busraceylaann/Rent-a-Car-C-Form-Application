namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class KULLANICI_GİRİŞİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KULLANICI_GİRİŞİ));
            this.lbkullaniciadi = new System.Windows.Forms.Label();
            this.lbsifre = new System.Windows.Forms.Label();
            this.tbkullanicigirisi = new System.Windows.Forms.TextBox();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbsaat = new System.Windows.Forms.Label();
            this.lbtarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btngiriş = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkullaniciadi
            // 
            this.lbkullaniciadi.AutoSize = true;
            this.lbkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkullaniciadi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbkullaniciadi.Location = new System.Drawing.Point(89, 261);
            this.lbkullaniciadi.Name = "lbkullaniciadi";
            this.lbkullaniciadi.Size = new System.Drawing.Size(148, 24);
            this.lbkullaniciadi.TabIndex = 0;
            this.lbkullaniciadi.Text = "Kullanıcı Girişi:";
            // 
            // lbsifre
            // 
            this.lbsifre.AutoSize = true;
            this.lbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsifre.Location = new System.Drawing.Point(143, 318);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(58, 24);
            this.lbsifre.TabIndex = 1;
            this.lbsifre.Text = "Şifre:";
            // 
            // tbkullanicigirisi
            // 
            this.tbkullanicigirisi.Location = new System.Drawing.Point(279, 261);
            this.tbkullanicigirisi.Name = "tbkullanicigirisi";
            this.tbkullanicigirisi.Size = new System.Drawing.Size(183, 22);
            this.tbkullanicigirisi.TabIndex = 2;
            this.tbkullanicigirisi.Text = "busracylan";
            this.tbkullanicigirisi.TextChanged += new System.EventHandler(this.tbkullanicigirisi_TextChanged);
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(279, 318);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.PasswordChar = '*';
            this.tbsifre.Size = new System.Drawing.Size(183, 22);
            this.tbsifre.TabIndex = 3;
            this.tbsifre.Text = "12345678";
            this.tbsifre.TextChanged += new System.EventHandler(this.tbsifre_TextChanged);
            this.tbsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbsifre_KeyDown);
            this.tbsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsifre_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbsaat);
            this.groupBox1.Controls.Add(this.lbtarih);
            this.groupBox1.Controls.Add(this.lbkullaniciadi);
            this.groupBox1.Controls.Add(this.tbkullanicigirisi);
            this.groupBox1.Controls.Add(this.btngiriş);
            this.groupBox1.Controls.Add(this.lbsifre);
            this.groupBox1.Controls.Add(this.tbsifre);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 632);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(397, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "ŞİFREMİ UNUTTUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "KAYIT OL";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Car-Rental.jpg");
            this.ımageList1.Images.SetKeyName(1, "images.jpg");
            this.ımageList1.Images.SetKeyName(2, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(3, "84-840048_feedback-customer-relationship-management-icon-png.png");
            this.ımageList1.Images.SetKeyName(4, "1774806.png");
            this.ımageList1.Images.SetKeyName(5, "60244472-rent-a-car-transportation-design-icon-with-long-shadow.jpg");
            this.ımageList1.Images.SetKeyName(6, "Admin-Login-Icon-12.jpg");
            this.ımageList1.Images.SetKeyName(7, "car-loan-thinkstock.jpg");
            this.ımageList1.Images.SetKeyName(8, "clint_icon.png");
            this.ımageList1.Images.SetKeyName(9, "crm-icon.png");
            this.ımageList1.Images.SetKeyName(10, "images (1).jpg");
            this.ımageList1.Images.SetKeyName(11, "images (1).png");
            this.ımageList1.Images.SetKeyName(12, "images.png");
            this.ımageList1.Images.SetKeyName(13, "giris-yap.jpg");
            // 
            // lbsaat
            // 
            this.lbsaat.AutoSize = true;
            this.lbsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbsaat.Location = new System.Drawing.Point(12, 70);
            this.lbsaat.Name = "lbsaat";
            this.lbsaat.Size = new System.Drawing.Size(53, 17);
            this.lbsaat.TabIndex = 8;
            this.lbsaat.Text = "SAAT:";
            // 
            // lbtarih
            // 
            this.lbtarih.AutoSize = true;
            this.lbtarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbtarih.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtarih.Location = new System.Drawing.Point(6, 39);
            this.lbtarih.Name = "lbtarih";
            this.lbtarih.Size = new System.Drawing.Size(59, 17);
            this.lbtarih.TabIndex = 7;
            this.lbtarih.Text = "TARİH:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ARAC_KIRALAMA_OTOMASYONU.Properties.Resources.Admin_Login_Icon_12;
            this.pictureBox1.Location = new System.Drawing.Point(290, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ARAC_KIRALAMA_OTOMASYONU.Properties.Resources.indir;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(416, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 117);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ARAC_KIRALAMA_OTOMASYONU.Properties.Resources.yeni_üyelik_2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(15, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 117);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btngiriş
            // 
            this.btngiriş.BackgroundImage = global::ARAC_KIRALAMA_OTOMASYONU.Properties.Resources.giris_yap;
            this.btngiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiriş.ImageList = this.ımageList1;
            this.btngiriş.Location = new System.Drawing.Point(320, 361);
            this.btngiriş.Name = "btngiriş";
            this.btngiriş.Size = new System.Drawing.Size(142, 49);
            this.btngiriş.TabIndex = 4;
            this.btngiriş.UseVisualStyleBackColor = true;
            this.btngiriş.Click += new System.EventHandler(this.btngiriş_Click);
            // 
            // KULLANICI_GİRİŞİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(625, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "KULLANICI_GİRİŞİ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI_GİRİŞİ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KULLANICI_GİRİŞİ_FormClosing);
            this.Load += new System.EventHandler(this.KULLANICI_GİRİŞİ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbkullaniciadi;
        private System.Windows.Forms.Label lbsifre;
        private System.Windows.Forms.TextBox tbkullanicigirisi;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.Button btngiriş;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbsaat;
        private System.Windows.Forms.Label lbtarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}