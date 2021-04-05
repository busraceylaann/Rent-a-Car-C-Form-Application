namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class SİFRE_UNUTTUM
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbsifrekullanıcı = new System.Windows.Forms.Label();
            this.lbsifregüvenliksorusu = new System.Windows.Forms.Label();
            this.tbsifreunutkullanici = new System.Windows.Forms.TextBox();
            this.tbsifreguvenlik = new System.Windows.Forms.TextBox();
            this.btntamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(157, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AŞAĞIDAKİ BİLGİLERİ DOLDURUNUZ";
            // 
            // lbsifrekullanıcı
            // 
            this.lbsifrekullanıcı.AutoSize = true;
            this.lbsifrekullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifrekullanıcı.Location = new System.Drawing.Point(137, 168);
            this.lbsifrekullanıcı.Name = "lbsifrekullanıcı";
            this.lbsifrekullanıcı.Size = new System.Drawing.Size(127, 18);
            this.lbsifrekullanıcı.TabIndex = 1;
            this.lbsifrekullanıcı.Text = "KULLANICI ADI:";
            // 
            // lbsifregüvenliksorusu
            // 
            this.lbsifregüvenliksorusu.AutoSize = true;
            this.lbsifregüvenliksorusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsifregüvenliksorusu.Location = new System.Drawing.Point(137, 240);
            this.lbsifregüvenliksorusu.Name = "lbsifregüvenliksorusu";
            this.lbsifregüvenliksorusu.Size = new System.Drawing.Size(176, 18);
            this.lbsifregüvenliksorusu.TabIndex = 2;
            this.lbsifregüvenliksorusu.Text = "GÜVENLİK SORUSU :";
            // 
            // tbsifreunutkullanici
            // 
            this.tbsifreunutkullanici.Location = new System.Drawing.Point(319, 165);
            this.tbsifreunutkullanici.Name = "tbsifreunutkullanici";
            this.tbsifreunutkullanici.Size = new System.Drawing.Size(148, 22);
            this.tbsifreunutkullanici.TabIndex = 3;
            this.tbsifreunutkullanici.TextChanged += new System.EventHandler(this.tbsifreunutkullanici_TextChanged);
            // 
            // tbsifreguvenlik
            // 
            this.tbsifreguvenlik.Location = new System.Drawing.Point(319, 233);
            this.tbsifreguvenlik.Name = "tbsifreguvenlik";
            this.tbsifreguvenlik.Size = new System.Drawing.Size(158, 22);
            this.tbsifreguvenlik.TabIndex = 4;
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(348, 343);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(129, 44);
            this.btntamam.TabIndex = 5;
            this.btntamam.Text = "TAMAM";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // SİFRE_UNUTTUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.tbsifreguvenlik);
            this.Controls.Add(this.tbsifreunutkullanici);
            this.Controls.Add(this.lbsifregüvenliksorusu);
            this.Controls.Add(this.lbsifrekullanıcı);
            this.Controls.Add(this.label1);
            this.Name = "SİFRE_UNUTTUM";
            this.Text = "SİFRE_UNUTTUM";
            this.Load += new System.EventHandler(this.SİFRE_UNUTTUM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbsifrekullanıcı;
        private System.Windows.Forms.Label lbsifregüvenliksorusu;
        private System.Windows.Forms.TextBox tbsifreunutkullanici;
        private System.Windows.Forms.TextBox tbsifreguvenlik;
        private System.Windows.Forms.Button btntamam;
    }
}