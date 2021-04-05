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
    public partial class kullanıcı_kayıt_olma_formu : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        
        public kullanıcı_kayıt_olma_formu()
        {
            InitializeComponent();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            if (tbkullaniciadi.Text == "" || tbsifre.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbtekrarsifre.Text == "" || tbgüvenliksorusu.Text == "")
            {
                MessageBox.Show("Tüm Kısımları doldurunuz");
            }
            else
            {
                if (lbsifreuyarı.Visible == true || lbadiuyarı.Visible == true || lbkullanıcıuyarı.Visible == true || lbsoyadiuyari.Visible == true || lbtekrarsifreuyarı.Visible == true)
                {
                    MessageBox.Show("Lütfen Uyarılara Dikkat ediniz");
                }
                else
                {
                    OleDbCommand cmd2 = new OleDbCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "select * from UYE_KAYIT_OLMA where UYE_KULLANICI_ADI='" + tbkullaniciadi.Text + "'";
                    if (con.State == ConnectionState.Closed) con.Open();
                    dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        DialogResult cc = MessageBox.Show("Aynı Kullanıcı adı kullanılmaktadır.Lütfen farklı kullanıcı adı seçiniz...");
                        if (cc == DialogResult.OK)
                        {
                            tbkullaniciadi.Clear();
                        }
                    }
                    else
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "insert into UYE_KAYIT_OLMA (UYE_ADI,UYE_SOYADI,UYE_KULLANICI_ADI,UYE_SİFRE,GUVENLIK_SORUSU) Values(@UYE_ADI,@UYE_SOYADI,@UYE_KULLANICI_ADI,@UYE_SİFRE,@GUVENLIK_SORUSU)";
                        cmd.Parameters.AddWithValue("@UYE_ADI", tbadi.Text);
                        cmd.Parameters.AddWithValue("@UYE_SOYADI", tbsoyadi.Text);
                        cmd.Parameters.AddWithValue("@UYE_KULLANICI_ADI", tbkullaniciadi.Text);
                        cmd.Parameters.AddWithValue("@UYE_SİFRE", int.Parse(tbsifre.Text));
                        cmd.Parameters.AddWithValue("@GUVENLIK_SORUSU", tbgüvenliksorusu.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt yapıldı");
                        con.Close();

                        KULLANICI_GİRİŞİ f2 = new KULLANICI_GİRİŞİ();
                        this.Hide();
                        f2.ShowDialog();
                    }

                }
            }
        }

        private void tbsifre_TextChanged(object sender, EventArgs e)
        {
            int uzunluk = tbsifre.Text.Length;
            if (uzunluk < 8)
            {
                lbsifreuyarı.Visible = true;
                lbsifreuyarı.Text = "Şifreniz 8 karakterden\nuzun olmalıdır";
            }
            else
            {
                lbsifreuyarı.Visible = false;
            }
        }

        private void tbtekrarsifre_TextChanged(object sender, EventArgs e)
        {
            if (tbsifre.Text != tbtekrarsifre.Text)
            {
                lbtekrarsifreuyarı.Visible = true;
                lbtekrarsifreuyarı.Text = "Şifreler Eşleşmiyor";
            }
            else
            {
                lbtekrarsifreuyarı.Visible = false;
            }
        }

        private void tbkullaniciadi_TextChanged(object sender, EventArgs e)
        {
            if (tbkullaniciadi.Text == "")
            {
               lbkullanıcıuyarı .Visible = true;
                lbkullanıcıuyarı.Text = "Kullanıcı Adı Boş Geçilemez";
            }
            else
            {
                lbkullanıcıuyarı.Visible = false;
            }
        }

        private void tbadi_TextChanged(object sender, EventArgs e)
        {
            if (tbadi.Text == "")
            {
                lbadiuyarı.Visible = true;
                lbadiuyarı.Text = "Ad Kısmı Boş Geçilemez";
            }
            else
            {
                lbadiuyarı.Visible = false;
            }
        }

        private void tbsoyadi_TextChanged(object sender, EventArgs e)
        {

            if (tbsoyadi.Text == "")
            {
                lbsoyadiuyari.Visible = true;
                lbsoyadiuyari.Text = "Soyad Kısmı Boş Geçilemez";
            }
            else
            {
                lbsoyadiuyari.Visible = false;
            }
        }

        private void kullanıcı_kayıt_olma_formu_Load(object sender, EventArgs e)
        {
            tbkullaniciadi.Focus();
        }

        private void tbsifre_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbtekrarsifre_KeyPress(object sender, KeyPressEventArgs e)
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
