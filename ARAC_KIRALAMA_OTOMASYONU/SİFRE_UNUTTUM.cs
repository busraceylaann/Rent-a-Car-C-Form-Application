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
    public partial class SİFRE_UNUTTUM : Form
    {
        
        

        public SİFRE_UNUTTUM()
        {

            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        string uyeıd;
        void verilericek()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            ds.Clear();
            string komut = "select * from UYE_KAYIT_OLMA";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            da.Fill(ds, "UYE_KAYIT_OLMA");         
            con.Close();
        }


        private void btntamam_Click(object sender, EventArgs e)
        {
            if (tbsifreunutkullanici.Text == "" && tbsifreguvenlik.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz");
            }
            else
            {
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = con;
                cmdd.CommandText = "select UYE_SİFRE from UYE_KAYIT_OLMA where UYE_KULLANICI_ADI='" + tbsifreunutkullanici.Text + "'and GUVENLIK_SORUSU='" + tbsifreguvenlik.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    uyeıd = dr.GetValue(0).ToString();
                    MessageBox.Show("Şifreniz : " + uyeıd);
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı adı yada güvenlik cevabı giriniz");
                    dr.Close();
                }
            }
        }

        private void SİFRE_UNUTTUM_Load(object sender, EventArgs e)
        {
            verilericek();
        }

        private void tbsifreunutkullanici_TextChanged(object sender, EventArgs e)
        {

            tbsifreunutkullanici.Text = tbsifreunutkullanici.Text.ToLower();
            tbsifreunutkullanici.SelectionStart = tbsifreunutkullanici.Text.Length;
        }
    }
}
