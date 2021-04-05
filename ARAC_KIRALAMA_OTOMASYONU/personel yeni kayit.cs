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
    public partial class personel_yeni_kayit : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbDataReader dr;
        bool kontroltc = false;
        

        public personel_yeni_kayit()
        {
            InitializeComponent();
        }

        

        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbgsm.Text == "" || tbacikadres.Text == "" || tbmaas.Text == "" || cbcinsiyet.Text == "")
            {
                MessageBox.Show("TÜM KISIMLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbtc.Text.Count() > 11)
            {
                MessageBox.Show("Tc no 11 haneden büyük olamaz");
            }
            else if (tbtc.Text.Count() < 11)
            {
                MessageBox.Show("Tc no 11 haneden küçük olamaz");
            }
            else
            { 
               
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select *from PERSONEL_BILGILERI where TC='" + tbtc.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {

                    DialogResult cevap = MessageBox.Show("AYNI TC İLE KAYIT YAPILAMAZ.LÜTFEN FARKLI TC KİMLİK NUMARASI GİRİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cevap == DialogResult.OK)
                    {
                        tbtc.Clear();
                    }
                }
                else
                {
                    if (kontroltc == true)
                    {

                        con.Close();
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO PERSONEL_BILGILERI (TC, ADI, SOYADI, GSM_NO,  CINSIYET,ACIK_ADRES,MAAS  " + ") " +

            "VALUES (@TC, @ADI, @SOYADI, @GSM_NO, @CINSIYET, " +

            " @ACIK_ADRES,@MAAS)";

                        cmd.Parameters.AddWithValue("@TC", tbtc.Text);
                        cmd.Parameters.AddWithValue("@ADI", tbadi.Text);
                        cmd.Parameters.AddWithValue("@SOYADI", tbsoyadi.Text);
                        cmd.Parameters.AddWithValue("@GSM_NO,", tbgsm.Text);
                        cmd.Parameters.AddWithValue("@CINSIYET", cbcinsiyet.Text);
                        cmd.Parameters.AddWithValue("@ACIK_ADRES", tbacikadres.Text);
                        cmd.Parameters.AddWithValue("@MAAS", tbmaas.Text);


                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ");
                    }

                    if (tbtc.Text.Count() == 11)
                    {
                        kontroltc = true;

                    }
                    else if (tbtc.Text.Count() > 11)

                    {
                        MessageBox.Show("TC NO 11 HANEYİ GEÇMEZ,KAYIT YAPILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }                  
                             
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personel_yeni_kayit_Load(object sender, EventArgs e)
        {
            //
        }

        private void personel_yeni_kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            personel personel = (personel)Application.OpenForms["personel"];
            personel.verileri_cek();
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tbtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbgsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbadi_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void tbsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }
    }
}
