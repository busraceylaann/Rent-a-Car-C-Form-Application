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
    public partial class uye_islem : Form
    {
        public uye_islem()
        {
            InitializeComponent();
        }
        public static string kulad { get; set; }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        void verilericek()
        {
            ds.Clear();
            string komut = "select * from UYE_KAYIT_OLMA where UYE_KULLANICI_ADI='" + kulad + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            da.Fill(ds, "UYE_KAYIT_OLMA");
        }
        void load()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["UYE_KAYIT_OLMA"];
            tbkullaniciadi.DataBindings.Clear(); tbsifre.DataBindings.Clear(); tbadi.DataBindings.Clear(); tbsoyadi.DataBindings.Clear(); tbgüvenliksorusu.DataBindings.Clear();
            tbkullaniciadi.DataBindings.Add("Text", bs, "UYE_KULLANICI_ADI");
            tbsifre.DataBindings.Add("Text", bs, "UYE_SİFRE");
            tbadi.DataBindings.Add("Text", bs, "UYE_ADI");
            tbsoyadi.DataBindings.Add("Text", bs, "UYE_SOYADI");
            tbgüvenliksorusu.DataBindings.Add("Text", bs, "GUVENLIK_SORUSU");
            tbgüvenliksorusu.Enabled = tbsifre.Enabled = tbadi.Enabled = tbsoyadi.Enabled = tbsifre .Enabled = false;
        }
       
       

        

       

        private void uye_islem_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnbilgileridüzenle_Click(object sender, EventArgs e)
        {
            if (btnbilgileridüzenle.Text == "Kaydet")
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "update  UYE_KAYIT_OLMA set UYE_KULLANICI_ADI=@UYE_KULLANICI_ADI,UYE_SİFRE=@UYE_SIFRE,UYE_ADI=@UYE_ADI,UYE_SOYADI=@UYE_SOYADI where UYE_KULLANICI_ADI='" + kulad + "'";
                cmd.Parameters.AddWithValue("@UYE_KULLANICI_ADI", tbkullaniciadi.Text);
                cmd.Parameters.AddWithValue("@UYE_SİFRE", tbsifre.Text);
                cmd.Parameters.AddWithValue("@UYE_ADI", tbadi.Text);
                cmd.Parameters.AddWithValue("@UYE_SOYADI", tbsoyadi.Text);
                cmd.Parameters.AddWithValue("@GUVENLIK_SORUSU", tbgüvenliksorusu.Text);
                cmd.ExecuteNonQuery();
                DialogResult Soru = MessageBox.Show("Kayıt Güncellendi.Başka Bir İşlem Yapmak İstermisiniz ?", "Soru", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == Soru)
                {
                    load();
                    btnbilgileridüzenle.Text = "Kaydet";
                }
                else if (DialogResult.No == Soru)
                {
                    ANASAYFA anm = new ANASAYFA();
                    this.Hide();

                }
                verilericek();
            }
            else if (btnbilgileridüzenle.Text == "Bilgileri Düzenle")
            {
                btnbilgileridüzenle.Text = "Kaydet";
                tbkullaniciadi.Enabled = tbsifre.Enabled = tbadi.Enabled = tbsoyadi.Enabled = tbgüvenliksorusu.Enabled = true;
            }
        }

        private void tbsifre_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbadi_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
         && !char.IsSeparator(e.KeyChar);
        }
    }
}


    

