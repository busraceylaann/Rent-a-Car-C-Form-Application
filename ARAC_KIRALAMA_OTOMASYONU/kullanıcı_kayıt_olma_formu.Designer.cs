namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class kullanıcı_kayıt_olma_formu
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
            this.llbkullaniciadi = new System.Windows.Forms.Label();
            this.lbsifre = new System.Windows.Forms.Label();
            this.lbtekrarsfire = new System.Windows.Forms.Label();
            this.lbadi = new System.Windows.Forms.Label();
            this.lbsoyadi = new System.Windows.Forms.Label();
            this.lbgüvenliksorusu = new System.Windows.Forms.Label();
            this.tbkullaniciadi = new System.Windows.Forms.TextBox();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.tbtekrarsifre = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbgüvenliksorusu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbsoyadiuyari = new System.Windows.Forms.Label();
            this.lbadiuyarı = new System.Windows.Forms.Label();
            this.lbtekrarsifreuyarı = new System.Windows.Forms.Label();
            this.lbsifreuyarı = new System.Windows.Forms.Label();
            this.lbkullanıcıuyarı = new System.Windows.Forms.Label();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbkullaniciadi
            // 
            this.llbkullaniciadi.AutoSize = true;
            this.llbkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbkullaniciadi.Location = new System.Drawing.Point(19, 49);
            this.llbkullaniciadi.Name = "llbkullaniciadi";
            this.llbkullaniciadi.Size = new System.Drawing.Size(127, 18);
            this.llbkullaniciadi.TabIndex = 0;
            this.llbkullaniciadi.Text = "KULLANICI ADI:";
            // 
            // lbsifre
            // 
            this.lbsifre.AutoSize = true;
            this.lbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifre.Location = new System.Drawing.Point(19, 106);
            this.lbsifre.Name = "lbsifre";
            this.lbsifre.Size = new System.Drawing.Size(87, 18);
            this.lbsifre.TabIndex = 1;
            this.lbsifre.Text = "ŞİFRENİZ:";
            // 
            // lbtekrarsfire
            // 
            this.lbtekrarsfire.AutoSize = true;
            this.lbtekrarsfire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbtekrarsfire.Location = new System.Drawing.Point(19, 154);
            this.lbtekrarsfire.Name = "lbtekrarsfire";
            this.lbtekrarsfire.Size = new System.Drawing.Size(158, 18);
            this.lbtekrarsfire.TabIndex = 2;
            this.lbtekrarsfire.Text = "TEKRAR ŞİFRENİZ:";
            // 
            // lbadi
            // 
            this.lbadi.AutoSize = true;
            this.lbadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbadi.Location = new System.Drawing.Point(19, 206);
            this.lbadi.Name = "lbadi";
            this.lbadi.Size = new System.Drawing.Size(39, 18);
            this.lbadi.TabIndex = 3;
            this.lbadi.Text = "ADI:";
            // 
            // lbsoyadi
            // 
            this.lbsoyadi.AutoSize = true;
            this.lbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsoyadi.Location = new System.Drawing.Point(19, 258);
            this.lbsoyadi.Name = "lbsoyadi";
            this.lbsoyadi.Size = new System.Drawing.Size(73, 18);
            this.lbsoyadi.TabIndex = 4;
            this.lbsoyadi.Text = "SOYADI:";
            // 
            // lbgüvenliksorusu
            // 
            this.lbgüvenliksorusu.AutoSize = true;
            this.lbgüvenliksorusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbgüvenliksorusu.Location = new System.Drawing.Point(19, 308);
            this.lbgüvenliksorusu.Name = "lbgüvenliksorusu";
            this.lbgüvenliksorusu.Size = new System.Drawing.Size(171, 18);
            this.lbgüvenliksorusu.TabIndex = 5;
            this.lbgüvenliksorusu.Text = "GÜVENLİK SORUSU:";
            // 
            // tbkullaniciadi
            // 
            this.tbkullaniciadi.Location = new System.Drawing.Point(197, 46);
            this.tbkullaniciadi.Name = "tbkullaniciadi";
            this.tbkullaniciadi.Size = new System.Drawing.Size(149, 22);
            this.tbkullaniciadi.TabIndex = 6;
            this.tbkullaniciadi.TextChanged += new System.EventHandler(this.tbkullaniciadi_TextChanged);
            // 
            // tbsifre
            // 
            this.tbsifre.Location = new System.Drawing.Point(197, 101);
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Size = new System.Drawing.Size(149, 22);
            this.tbsifre.TabIndex = 7;
            this.tbsifre.TextChanged += new System.EventHandler(this.tbsifre_TextChanged);
            this.tbsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsifre_KeyPress);
            // 
            // tbtekrarsifre
            // 
            this.tbtekrarsifre.Location = new System.Drawing.Point(197, 154);
            this.tbtekrarsifre.Name = "tbtekrarsifre";
            this.tbtekrarsifre.Size = new System.Drawing.Size(149, 22);
            this.tbtekrarsifre.TabIndex = 8;
            this.tbtekrarsifre.TextChanged += new System.EventHandler(this.tbtekrarsifre_TextChanged);
            this.tbtekrarsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtekrarsifre_KeyPress);
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(197, 206);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(149, 22);
            this.tbadi.TabIndex = 9;
            this.tbadi.TextChanged += new System.EventHandler(this.tbadi_TextChanged);
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadi_KeyPress);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(197, 258);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(149, 22);
            this.tbsoyadi.TabIndex = 10;
            this.tbsoyadi.TextChanged += new System.EventHandler(this.tbsoyadi_TextChanged);
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsoyadi_KeyPress);
            // 
            // tbgüvenliksorusu
            // 
            this.tbgüvenliksorusu.Location = new System.Drawing.Point(197, 308);
            this.tbgüvenliksorusu.Name = "tbgüvenliksorusu";
            this.tbgüvenliksorusu.Size = new System.Drawing.Size(149, 22);
            this.tbgüvenliksorusu.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbsoyadiuyari);
            this.groupBox1.Controls.Add(this.lbadiuyarı);
            this.groupBox1.Controls.Add(this.lbtekrarsifreuyarı);
            this.groupBox1.Controls.Add(this.lbsifreuyarı);
            this.groupBox1.Controls.Add(this.lbkullanıcıuyarı);
            this.groupBox1.Controls.Add(this.tbkullaniciadi);
            this.groupBox1.Controls.Add(this.tbgüvenliksorusu);
            this.groupBox1.Controls.Add(this.llbkullaniciadi);
            this.groupBox1.Controls.Add(this.lbgüvenliksorusu);
            this.groupBox1.Controls.Add(this.tbsoyadi);
            this.groupBox1.Controls.Add(this.tbsifre);
            this.groupBox1.Controls.Add(this.tbadi);
            this.groupBox1.Controls.Add(this.lbsoyadi);
            this.groupBox1.Controls.Add(this.lbsifre);
            this.groupBox1.Controls.Add(this.tbtekrarsifre);
            this.groupBox1.Controls.Add(this.lbtekrarsfire);
            this.groupBox1.Controls.Add(this.lbadi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 359);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICI BİLGİLERİ";
            // 
            // lbsoyadiuyari
            // 
            this.lbsoyadiuyari.AutoSize = true;
            this.lbsoyadiuyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsoyadiuyari.ForeColor = System.Drawing.Color.Snow;
            this.lbsoyadiuyari.Location = new System.Drawing.Point(376, 263);
            this.lbsoyadiuyari.Name = "lbsoyadiuyari";
            this.lbsoyadiuyari.Size = new System.Drawing.Size(56, 18);
            this.lbsoyadiuyari.TabIndex = 16;
            this.lbsoyadiuyari.Text = "UYARI";
            // 
            // lbadiuyarı
            // 
            this.lbadiuyarı.AutoSize = true;
            this.lbadiuyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbadiuyarı.ForeColor = System.Drawing.Color.Snow;
            this.lbadiuyarı.Location = new System.Drawing.Point(376, 211);
            this.lbadiuyarı.Name = "lbadiuyarı";
            this.lbadiuyarı.Size = new System.Drawing.Size(56, 18);
            this.lbadiuyarı.TabIndex = 15;
            this.lbadiuyarı.Text = "UYARI";
            // 
            // lbtekrarsifreuyarı
            // 
            this.lbtekrarsifreuyarı.AutoSize = true;
            this.lbtekrarsifreuyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbtekrarsifreuyarı.ForeColor = System.Drawing.Color.Snow;
            this.lbtekrarsifreuyarı.Location = new System.Drawing.Point(376, 159);
            this.lbtekrarsifreuyarı.Name = "lbtekrarsifreuyarı";
            this.lbtekrarsifreuyarı.Size = new System.Drawing.Size(56, 18);
            this.lbtekrarsifreuyarı.TabIndex = 14;
            this.lbtekrarsifreuyarı.Text = "UYARI";
            // 
            // lbsifreuyarı
            // 
            this.lbsifreuyarı.AutoSize = true;
            this.lbsifreuyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifreuyarı.ForeColor = System.Drawing.Color.Snow;
            this.lbsifreuyarı.Location = new System.Drawing.Point(376, 106);
            this.lbsifreuyarı.Name = "lbsifreuyarı";
            this.lbsifreuyarı.Size = new System.Drawing.Size(56, 18);
            this.lbsifreuyarı.TabIndex = 13;
            this.lbsifreuyarı.Text = "UYARI";
            // 
            // lbkullanıcıuyarı
            // 
            this.lbkullanıcıuyarı.AutoSize = true;
            this.lbkullanıcıuyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkullanıcıuyarı.ForeColor = System.Drawing.Color.Snow;
            this.lbkullanıcıuyarı.Location = new System.Drawing.Point(376, 52);
            this.lbkullanıcıuyarı.Name = "lbkullanıcıuyarı";
            this.lbkullanıcıuyarı.Size = new System.Drawing.Size(56, 18);
            this.lbkullanıcıuyarı.TabIndex = 12;
            this.lbkullanıcıuyarı.Text = "UYARI";
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.Transparent;
            this.btnkayitol.Location = new System.Drawing.Point(637, 381);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(119, 48);
            this.btnkayitol.TabIndex = 13;
            this.btnkayitol.Text = "KAYIT OL";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // kullanıcı_kayıt_olma_formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.groupBox1);
            this.Name = "kullanıcı_kayıt_olma_formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanıcı_kayıt_olma_formu";
            this.Load += new System.EventHandler(this.kullanıcı_kayıt_olma_formu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label llbkullaniciadi;
        private System.Windows.Forms.Label lbsifre;
        private System.Windows.Forms.Label lbtekrarsfire;
        private System.Windows.Forms.Label lbadi;
        private System.Windows.Forms.Label lbsoyadi;
        private System.Windows.Forms.Label lbgüvenliksorusu;
        private System.Windows.Forms.TextBox tbkullaniciadi;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.TextBox tbtekrarsifre;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbgüvenliksorusu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.Label lbsoyadiuyari;
        private System.Windows.Forms.Label lbadiuyarı;
        private System.Windows.Forms.Label lbtekrarsifreuyarı;
        private System.Windows.Forms.Label lbsifreuyarı;
        private System.Windows.Forms.Label lbkullanıcıuyarı;
    }
}