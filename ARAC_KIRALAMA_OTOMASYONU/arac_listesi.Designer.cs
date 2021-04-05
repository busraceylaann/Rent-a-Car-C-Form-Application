namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class arac_listesi
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
            this.cmbara = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracarama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btndüzenle = new System.Windows.Forms.Button();
            this.btnyenikayıtekle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTNGERİ = new System.Windows.Forms.Button();
            this.BTNARAMA = new System.Windows.Forms.Button();
            this.CBMODELARAMA = new System.Windows.Forms.ComboBox();
            this.CBMARKAARAMA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbara);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.aracarama);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAÇ LİSTESİ VE ARAÇ ARAMA";
            // 
            // cmbara
            // 
            this.cmbara.FormattingEnabled = true;
            this.cmbara.Items.AddRange(new object[] {
            "TÜM ARAÇLAR",
            "BOŞ ARAÇLAR ",
            "DOLU ARAÇLAR"});
            this.cmbara.Location = new System.Drawing.Point(454, 46);
            this.cmbara.Name = "cmbara";
            this.cmbara.Size = new System.Drawing.Size(169, 24);
            this.cmbara.TabIndex = 3;
            this.cmbara.SelectedIndexChanged += new System.EventHandler(this.cmbara_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 289);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aracarama
            // 
            this.aracarama.Location = new System.Drawing.Point(207, 48);
            this.aracarama.Name = "aracarama";
            this.aracarama.Size = new System.Drawing.Size(193, 22);
            this.aracarama.TabIndex = 1;
            this.aracarama.TextChanged += new System.EventHandler(this.aracarama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARAÇ ARAMA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnvazgec);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btndüzenle);
            this.groupBox2.Controls.Add(this.btnyenikayıtekle);
            this.groupBox2.Location = new System.Drawing.Point(35, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İŞLEMLER";
            // 
            // btnvazgec
            // 
            this.btnvazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvazgec.Location = new System.Drawing.Point(610, 49);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(103, 49);
            this.btnvazgec.TabIndex = 3;
            this.btnvazgec.Text = "Vazgeç";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(426, 49);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(110, 49);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btndüzenle
            // 
            this.btndüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndüzenle.Location = new System.Drawing.Point(222, 53);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(115, 47);
            this.btndüzenle.TabIndex = 1;
            this.btndüzenle.Text = "Düzenle";
            this.btndüzenle.UseVisualStyleBackColor = true;
            this.btndüzenle.Click += new System.EventHandler(this.btndüzenle_Click);
            // 
            // btnyenikayıtekle
            // 
            this.btnyenikayıtekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyenikayıtekle.Location = new System.Drawing.Point(37, 53);
            this.btnyenikayıtekle.Name = "btnyenikayıtekle";
            this.btnyenikayıtekle.Size = new System.Drawing.Size(115, 45);
            this.btnyenikayıtekle.TabIndex = 0;
            this.btnyenikayıtekle.Text = "Yeni Kayıt Ekle";
            this.btnyenikayıtekle.UseVisualStyleBackColor = true;
            this.btnyenikayıtekle.Click += new System.EventHandler(this.btnyenikayıtekle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTNGERİ);
            this.groupBox3.Controls.Add(this.BTNARAMA);
            this.groupBox3.Controls.Add(this.CBMODELARAMA);
            this.groupBox3.Controls.Add(this.CBMARKAARAMA);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(790, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 556);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ARAMA VE FİLTRELEME";
            // 
            // BTNGERİ
            // 
            this.BTNGERİ.Location = new System.Drawing.Point(146, 384);
            this.BTNGERİ.Name = "BTNGERİ";
            this.BTNGERİ.Size = new System.Drawing.Size(85, 44);
            this.BTNGERİ.TabIndex = 6;
            this.BTNGERİ.Text = "YENİLE";
            this.BTNGERİ.UseVisualStyleBackColor = true;
            this.BTNGERİ.Click += new System.EventHandler(this.BTNGERİ_Click);
            // 
            // BTNARAMA
            // 
            this.BTNARAMA.Location = new System.Drawing.Point(33, 384);
            this.BTNARAMA.Name = "BTNARAMA";
            this.BTNARAMA.Size = new System.Drawing.Size(107, 44);
            this.BTNARAMA.TabIndex = 5;
            this.BTNARAMA.Text = "ARAMA";
            this.BTNARAMA.UseVisualStyleBackColor = true;
            this.BTNARAMA.Click += new System.EventHandler(this.BTNARAMA_Click);
            // 
            // CBMODELARAMA
            // 
            this.CBMODELARAMA.FormattingEnabled = true;
            this.CBMODELARAMA.Location = new System.Drawing.Point(110, 272);
            this.CBMODELARAMA.Name = "CBMODELARAMA";
            this.CBMODELARAMA.Size = new System.Drawing.Size(121, 26);
            this.CBMODELARAMA.TabIndex = 3;
            this.CBMODELARAMA.SelectedIndexChanged += new System.EventHandler(this.CBMODELARAMA_SelectedIndexChanged);
            // 
            // CBMARKAARAMA
            // 
            this.CBMARKAARAMA.FormattingEnabled = true;
            this.CBMARKAARAMA.Location = new System.Drawing.Point(110, 221);
            this.CBMARKAARAMA.Name = "CBMARKAARAMA";
            this.CBMARKAARAMA.Size = new System.Drawing.Size(121, 26);
            this.CBMARKAARAMA.TabIndex = 2;
            this.CBMARKAARAMA.SelectedIndexChanged += new System.EventHandler(this.CBMARKAARAMA_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "MODEL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MARKA:";
            // 
            // arac_listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1098, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "arac_listesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arac_listesi";
            this.Load += new System.EventHandler(this.arac_listesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox aracarama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.Button btnyenikayıtekle;
        private System.Windows.Forms.ComboBox cmbara;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTNGERİ;
        private System.Windows.Forms.Button BTNARAMA;
        private System.Windows.Forms.ComboBox CBMODELARAMA;
        private System.Windows.Forms.ComboBox CBMARKAARAMA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}