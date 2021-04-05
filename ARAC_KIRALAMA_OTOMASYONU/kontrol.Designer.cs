namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class kontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kontrol));
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btiptal = new System.Windows.Forms.Button();
            this.bttamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbsifre
            // 
            this.tbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsifre.Location = new System.Drawing.Point(174, 149);
            this.tbsifre.Multiline = true;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.PasswordChar = '*';
            this.tbsifre.Size = new System.Drawing.Size(226, 38);
            this.tbsifre.TabIndex = 4;
            this.tbsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bu Kısıma Giriş için Şifrenizi Giriniz.";
            // 
            // btiptal
            // 
            this.btiptal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btiptal.BackgroundImage")));
            this.btiptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btiptal.Location = new System.Drawing.Point(303, 268);
            this.btiptal.Name = "btiptal";
            this.btiptal.Size = new System.Drawing.Size(102, 45);
            this.btiptal.TabIndex = 5;
            this.btiptal.Text = "İptal";
            this.btiptal.UseVisualStyleBackColor = true;
            this.btiptal.Click += new System.EventHandler(this.btiptal_Click);
            // 
            // bttamam
            // 
            this.bttamam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttamam.BackgroundImage")));
            this.bttamam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttamam.Location = new System.Drawing.Point(174, 268);
            this.bttamam.Name = "bttamam";
            this.bttamam.Size = new System.Drawing.Size(102, 45);
            this.bttamam.TabIndex = 6;
            this.bttamam.Text = "Tamam";
            this.bttamam.UseVisualStyleBackColor = true;
            this.bttamam.Click += new System.EventHandler(this.bttamam_Click);
            // 
            // kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(588, 353);
            this.Controls.Add(this.btiptal);
            this.Controls.Add(this.bttamam);
            this.Controls.Add(this.tbsifre);
            this.Controls.Add(this.label1);
            this.Name = "kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kontrol";
            this.Load += new System.EventHandler(this.kontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btiptal;
        private System.Windows.Forms.Button bttamam;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.Label label1;
    }
}