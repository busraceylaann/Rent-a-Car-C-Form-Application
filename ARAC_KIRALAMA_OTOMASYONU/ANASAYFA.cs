using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class ANASAYFA : Form
    {
        public static string kullanici { get; set; }
        public ANASAYFA()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           DialogResult cc = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİĞİNİZE EMİN MİSİNİZ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( DialogResult.Yes==cc)
            {
                Application.Exit();
            }
            else if (DialogResult.No==cc)
            {
                ANASAYFA aNASAYFA = new ANASAYFA();
                this.Hide();
                aNASAYFA.Show();
            }
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            if (kullanici != "")
            {
                lbkullaniciyapankisi.Text = "Giriş Yapan Kullanıcı : " + kullanici;
            }
            LBARACRAPORU.Visible = LBKİRARAPORU.Visible = false;

            LBMUSTERİRAPORU.Visible = LBPERSONELRAP.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            this.Hide();
            personel.ShowDialog();
            this.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            arac_listesi arac_Listesi = new arac_listesi();
            this.Hide();
            arac_Listesi.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            müşteri_listesi müşteri_Listesi = new müşteri_listesi();
            this.Hide();
            müşteri_Listesi.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SÖZLESME sÖZLESME = new SÖZLESME();
            this.Hide();
            sÖZLESME.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrol f6 = new kontrol();
            kontrol.guvkul = kullanici;
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }

        private void lbcıkısbtn_MouseLeave(object sender, EventArgs e)
        {
            lbcıkısbtn.BackColor = Color.Transparent;
            lbcıkısbtn.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void lbcıkısbtn_MouseEnter(object sender, EventArgs e)
        {
            lbcıkısbtn.BackColor = Color.White;
            lbcıkısbtn.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void lbcıkısbtn_DoubleClick(object sender, EventArgs e)
        {
            DialogResult cevapcıkıs = MessageBox.Show("Çıkış Yapılsın mı ?", "Çıkış", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == cevapcıkıs)
            {
                KULLANICI_GİRİŞİ kULLANICI = new KULLANICI_GİRİŞİ();
                this.Hide();
                kULLANICI.Show();
                
            }
        }

        private void lbcıkısbtn_Click(object sender, EventArgs e)
        {
            //
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.Font = new Font("Microsoft Sans Serif",14, FontStyle.Bold);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
           
            button4.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
         
            button4.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }


        private void label7_DoubleClick(object sender, EventArgs e)
        {

            LBARACRAPORU.Visible = LBKİRARAPORU.Visible = true;

            LBMUSTERİRAPORU.Visible = LBPERSONELRAP.Visible = true;
        }

        private void RAPORLAMA_MouseEnter(object sender, EventArgs e)
        {
            RAPORLAMA.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
        }

        private void RAPORLAMA_MouseLeave(object sender, EventArgs e)
        {
            RAPORLAMA.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void RAPORLAMA_Click(object sender, EventArgs e)
        {
            LBARACRAPORU.Visible = LBKİRARAPORU.Visible = false;

            LBMUSTERİRAPORU.Visible = LBPERSONELRAP.Visible = false;
        }

        private void LBARACRAPORU_Click(object sender, EventArgs e)
        {
            rapor R1 = new rapor();
            this.Hide();
            R1.ShowDialog();
            this.Show();
        }

        private void LBKİRARAPORU_Click(object sender, EventArgs e)
        {
            Rapor2 r2 = new Rapor2();
            this.Hide();
            r2.ShowDialog();
            this.Show();
        }

        private void LBMUSTERİRAPORU_Click(object sender, EventArgs e)
        {
            Rapor3 r3 = new Rapor3();
            this.Hide();
            r3.ShowDialog();
            this.Show();
        }

        private void LBPERSONELRAP_Click(object sender, EventArgs e)
        {
            Rapor4 r4 = new Rapor4();
            this.Hide();
            r4.ShowDialog();
            this.Show();
        }
    }
}
