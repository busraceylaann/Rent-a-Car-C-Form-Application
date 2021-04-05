namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class personel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbpersonelarama = new System.Windows.Forms.TextBox();
            this.lbpersonelarama = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.btnyenikayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbpersonelarama);
            this.groupBox1.Controls.Add(this.lbpersonelarama);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PERSONEL LİSTESİ VE PERSONEL ARAMA";
            // 
            // tbpersonelarama
            // 
            this.tbpersonelarama.Location = new System.Drawing.Point(231, 61);
            this.tbpersonelarama.Name = "tbpersonelarama";
            this.tbpersonelarama.Size = new System.Drawing.Size(278, 24);
            this.tbpersonelarama.TabIndex = 2;
            this.tbpersonelarama.TextChanged += new System.EventHandler(this.tbpersonelarama_TextChanged);
            // 
            // lbpersonelarama
            // 
            this.lbpersonelarama.AutoSize = true;
            this.lbpersonelarama.Location = new System.Drawing.Point(25, 61);
            this.lbpersonelarama.Name = "lbpersonelarama";
            this.lbpersonelarama.Size = new System.Drawing.Size(164, 18);
            this.lbpersonelarama.TabIndex = 1;
            this.lbpersonelarama.Text = "PERSONEL ARAMA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnvazgec);
            this.groupBox2.Controls.Add(this.btnduzenle);
            this.groupBox2.Controls.Add(this.btnyenikayit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1017, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(409, 43);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(126, 51);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnvazgec
            // 
            this.btnvazgec.Location = new System.Drawing.Point(595, 43);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(135, 51);
            this.btnvazgec.TabIndex = 2;
            this.btnvazgec.Text = "VAZGEÇ";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(216, 43);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(135, 51);
            this.btnduzenle.TabIndex = 1;
            this.btnduzenle.Text = "DÜZENLE";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // btnyenikayit
            // 
            this.btnyenikayit.Location = new System.Drawing.Point(21, 43);
            this.btnyenikayit.Name = "btnyenikayit";
            this.btnyenikayit.Size = new System.Drawing.Size(135, 51);
            this.btnyenikayit.TabIndex = 0;
            this.btnyenikayit.Text = "YENİ KAYIT EKLE";
            this.btnyenikayit.UseVisualStyleBackColor = true;
            this.btnyenikayit.Click += new System.EventHandler(this.btnyenikayit_Click);
            // 
            // personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1092, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "personel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "personel";
            this.Load += new System.EventHandler(this.personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbpersonelarama;
        private System.Windows.Forms.Label lbpersonelarama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button btnyenikayit;
        private System.Windows.Forms.Button btnsil;
    }
}