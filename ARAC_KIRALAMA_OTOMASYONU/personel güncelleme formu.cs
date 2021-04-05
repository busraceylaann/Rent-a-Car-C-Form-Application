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
    public partial class personel_güncelleme_formu : Form
    {
        public static string personel_id { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        long kontroltc;
        OleDbDataReader dr;

        public personel_güncelleme_formu()
        {
            InitializeComponent();
        }
        void verilericek()
        {
            ds.Clear();
            int a = int.Parse(personel_id);
            string komut = "select*from PERSONEL_BILGILERI where PERSONEL_ID=" + personel_id + "";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds,"PERSONEL_BILGILERI");
        }
        void bultc()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  PERSONEL_BILGILERI set TC=@TC,ADI=@ADI,SOYADI=@SOYADI,GSM_NO=@GSM_NO," +
                "CINSIYET=@CINSIYET,ACIK_ADRES=@ACIK_ADRES,MAAS=@MAAS where PERSONEL_ID=" + personel_id + "";


            cmd.Parameters.AddWithValue("@TC", tbtc.Text);
            cmd.Parameters.AddWithValue("@ADI", tbadi.Text);
            cmd.Parameters.AddWithValue("@SOYADI", tbsoyadi.Text);
            cmd.Parameters.AddWithValue("@GSM_NO", tbgsm.Text);
            cmd.Parameters.AddWithValue("@CINSIYET", cbcinsiyet.Text);
            cmd.Parameters.AddWithValue("@ACIK_ADRES", tbacikadres.Text);
            cmd.Parameters.AddWithValue("@MAAS", tbmaas.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");
        }
        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbgsm.Text == "" || tbacikadres.Text == "" || cbcinsiyet.Text == "")
            {
                MessageBox.Show("TÜM KISIMLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbtc.Text.Count() > 11)
            {
                MessageBox.Show("Tc no 11 haneden büyük olamaz");
            }
            else if(tbtc.Text.Count()<11)
            {
                MessageBox.Show("Tc no 11 haneden küçük olamaz");
            }
            else
            {   if (kontroltc != long.Parse(tbtc.Text))
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "select *from PERSONEL_BILGILERI where TC='" + tbtc.Text + "'";
                    if (con.State == ConnectionState.Closed) con.Open();
                    dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        DialogResult cevap = MessageBox.Show("AYNI TC İLE GÜNCELLEME YAPILAMAZ.LÜTFEN FARKLI TC KİMLİK NUMARASI GİRİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (cevap == DialogResult.OK)
                        {
                            tbtc.Clear();
                        }
                        
                    }
                    else
                        {
                            bultc();
                        }
                }
                else
                {
                    bultc();
                }
                } 
            }
        private void personel_güncelleme_formu_Load(object sender, EventArgs e)
        {
            
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["PERSONEL_BILGILERI"];
            tbtc.DataBindings.Clear();
            tbadi.DataBindings.Clear();
            tbsoyadi.DataBindings.Clear();
            tbgsm.DataBindings.Clear();
            tbmaas.DataBindings.Clear();
            tbacikadres.DataBindings.Clear();
            cbcinsiyet.DataBindings.Clear();

            tbtc.DataBindings.Add("Text", bs, "TC");
            tbsoyadi.DataBindings.Add("Text", bs, "SOYADI");
            tbmaas.DataBindings.Add("Text", bs, "MAAS");
            tbgsm.DataBindings.Add("Text", bs, "GSM_NO");
            tbacikadres.DataBindings.Add("Text", bs, "ACIK_ADRES");
            tbadi.DataBindings.Add("Text", bs, "ADI");
            cbcinsiyet.DataBindings.Add("Text", bs, "CINSIYET");
            con.Close();
            kontroltc = long.Parse(tbtc.Text);
        }

        private void personel_güncelleme_formu_FormClosed(object sender, FormClosedEventArgs e)
        {
            personel personel = (personel)Application.OpenForms["personel"];
            personel.verileri_cek();
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            //
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

        private void tbadi_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void tbsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
     && !char.IsSeparator(e.KeyChar);
        }
    }
}
