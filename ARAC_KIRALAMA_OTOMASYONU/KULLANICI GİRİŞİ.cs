using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class KULLANICI_GİRİŞİ : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        public KULLANICI_GİRİŞİ()
        {
            InitializeComponent();
        }

        private void KULLANICI_GİRİŞİ_Load(object sender, EventArgs e)
        {
            lbtarih.Text = "Tarih:" + DateTime.Now.ToLongDateString();
            lbsaat.Text = "Saat:" + DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbsaat.Text = "Saat:" + DateTime.Now.ToLongTimeString();
        }

        private void lbkullancigirişi_DoubleClick(object sender, EventArgs e)
        {
            kullanıcı_kayıt_olma_formu kullanıcı_Kayıt_Olma_Formu = new kullanıcı_kayıt_olma_formu();
            this.Hide();
            kullanıcı_Kayıt_Olma_Formu.ShowDialog();
            this.Show();

        }

        private void btngiriş_Click(object sender, EventArgs e)
        {
            if (tbkullanicigirisi.Text == "" && tbsifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from UYE_KAYIT_OLMA where UYE_KULLANICI_ADI='" + tbkullanicigirisi.Text + "' and UYE_SİFRE= " + int.Parse(tbsifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ANASAYFA f3= new ANASAYFA();
                    ANASAYFA.kullanici = tbkullanicigirisi.Text;
                    this.Hide();                  
                    f3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı adı şifre giriniz");
                }
                con.Close();
            }
        }

        private void tbsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lbsifreunuttum_DoubleClick(object sender, EventArgs e)
        {
            SİFRE_UNUTTUM SİFRE= new SİFRE_UNUTTUM();
            this.Hide();
            SİFRE.ShowDialog();
            this.Show();
        }

        private void KULLANICI_GİRİŞİ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbsifre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btngiriş_Click(sender, e);
            }

        }

        private void tbsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkullanicigirisi_TextChanged(object sender, EventArgs e)
        {
            tbkullanicigirisi.Text = tbkullanicigirisi.Text.ToLower();
            tbkullanicigirisi.SelectionStart = tbkullanicigirisi.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanıcı_kayıt_olma_formu kullanıcı_Kayıt_Olma_Formu = new kullanıcı_kayıt_olma_formu();
            this.Hide();
            kullanıcı_Kayıt_Olma_Formu.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SİFRE_UNUTTUM SİFRE = new SİFRE_UNUTTUM();
            this.Hide();
            SİFRE.ShowDialog();
            this.Show();
        }
    }
}
