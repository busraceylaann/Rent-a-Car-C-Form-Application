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
    public partial class müsteri_kayıt_formu : Form
    {
        public müsteri_kayıt_formu()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        bool kontroltc = false;


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbgsm.Text == "" || tbil.Text == "" || tbdogumyeri.Text == "" || cbacikadres.Text == "" || dtpdogumtarihi.Text == "" || cbcinsiyet.Text == "")
            {
                MessageBox.Show("TÜM KISIMLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int girilentarih = int.Parse(dtpdogumtarihi.Value.ToString("yyyy"));
            if (girilentarih - 20 >= 1998)
            {
                MessageBox.Show("20 Yaşından Büyük Olmalısınız");
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select *from MUSTERI_BILGILERI where TC='" + tbtc.Text + "'";
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
                        cmd.CommandText = "INSERT INTO MUSTERI_BILGILERI ( ADI, SOYADI,TC,DOGUM_YERI,DOGUM_TARIHI,CINSIYET,GSM_NO,IL,ACIK_ADRES  " + ") " +

            "VALUES (@ADI, @SOYADI,@TC,@DOGUM_YERI,@DOGUM_TARIHI,@CINSIYET,@GSM_NO,@IL,@ACIK_ADRES)";


                        cmd.Parameters.AddWithValue("@ADI", tbadi.Text);
                        cmd.Parameters.AddWithValue("@SOYADI", tbsoyadi.Text);
                        cmd.Parameters.AddWithValue("@TC", tbtc.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_YERI", tbdogumyeri.Text);
                        cmd.Parameters.AddWithValue("@DOGUM_TARIHI", dtpdogumtarihi.Text);
                        cmd.Parameters.AddWithValue("@CINSIYET", cbcinsiyet.Text);
                        cmd.Parameters.AddWithValue("@GSM_NO,", tbgsm.Text);
                        cmd.Parameters.AddWithValue("@IL", tbil.Text);
                        cmd.Parameters.AddWithValue("@ACIK_ADRES", cbacikadres.Text);



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
   

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void müsteri_kayıt_formu_FormClosed(object sender, FormClosedEventArgs e)
        {
          müşteri_listesi  müşteri_Listesi = (müşteri_listesi)Application.OpenForms["müşteri_listesi"];
            müşteri_Listesi.listele();
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

        private void müsteri_kayıt_formu_Load(object sender, EventArgs e)
        {

        }

        private void dtpdogumtarihi_ValueChanged(object sender, EventArgs e)
        {
            
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

        private void tbadi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

