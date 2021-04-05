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
    public partial class müsteri_güncelleme_formu : Form
    {
        public müsteri_güncelleme_formu()
        {
            InitializeComponent();
        }
        public static string musteri_id { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        long kontroltc;
        OleDbDataReader dr;
        void verilericek()
        {
            ds.Clear();
            int a = int.Parse(musteri_id);
            string komut = "select*from MUSTERI_BILGILERI where MUSTERI_ID=" + musteri_id + "";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds, "MUSTERI_BILGILERI");
        }

        void güncelle()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update MUSTERI_BILGILERI set ADI=@ADI,SOYADI=@SOYADI,TC=@TC,DOGUM_YERI=@DOGUM_YERI,DOGUM_TARIHI=@DOGUM_TARIHI," +
                "CINSIYET=@CINSIYET,GSM_NO=@GSM_NO,IL=@IL,ACIK_ADRES=@ACIK_ADRES where MUSTERI_ID=" + musteri_id + "";


            cmd.Parameters.AddWithValue("@ADI", tbadi.Text);
            cmd.Parameters.AddWithValue("@SOYADI", tbsoyadi.Text);
            cmd.Parameters.AddWithValue("@TC", tbtc.Text);
            cmd.Parameters.AddWithValue("@DOGUM_YERI", tbdogumyeri.Text);
            cmd.Parameters.AddWithValue("@DOGUM_TARIHI", dtpdogumtarihi.Text);
            cmd.Parameters.AddWithValue("@CINSIYET", cbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@GSM_NO", tbgsm.Text);
            cmd.Parameters.AddWithValue("@IL", tbil.Text);
            cmd.Parameters.AddWithValue("@ACIK_ADRES", cbacikadres.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbgsm.Text == "" || tbil.Text == "" || tbdogumyeri.Text == "" || cbacikadres.Text == "" || dtpdogumtarihi.Text == "" || cbcinsiyet.Text == "")
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
                if (kontroltc != long.Parse(tbtc.Text))
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
                        güncelle();
                    }
                }
                else
                {
                    güncelle();
                }
                }
            }

        private void müsteri_güncelleme_formu_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["MUSTERI_BILGILERI"];
            tbtc.DataBindings.Clear();
            tbadi.DataBindings.Clear();
            tbsoyadi.DataBindings.Clear();
            tbgsm.DataBindings.Clear();
            dtpdogumtarihi.DataBindings.Clear();
            tbdogumyeri.DataBindings.Clear();
            tbil.DataBindings.Clear();
            cbacikadres.DataBindings.Clear();
            cbcinsiyet.DataBindings.Clear();

            tbtc.DataBindings.Add("Text", bs, "TC");
            tbsoyadi.DataBindings.Add("Text", bs, "SOYADI");
            tbil.DataBindings.Add("Text", bs, "IL");
            tbgsm.DataBindings.Add("Text", bs, "GSM_NO");
            cbacikadres.DataBindings.Add("Text", bs, "ACIK_ADRES");
            dtpdogumtarihi.DataBindings.Add("Text",bs,"DOGUM_TARIHI");
            tbdogumyeri.DataBindings.Add("Text",bs,"DOGUM_YERI");
            tbadi.DataBindings.Add("Text", bs, "ADI");
            cbcinsiyet.DataBindings.Add("Text", bs, "CINSIYET");
            con.Close(); kontroltc = long.Parse(tbtc.Text);
        }

        private void müsteri_güncelleme_formu_FormClosed(object sender, FormClosedEventArgs e)
        {


           müşteri_listesi  müşteri_Listesi = (müşteri_listesi)Application.OpenForms["müşteri_listesi"];
            müşteri_Listesi.listele();
        }

        private void BTNVAZGEC_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tbil_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }

        private void tbdogumyeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
        && !char.IsSeparator(e.KeyChar);
        }
    }
}
