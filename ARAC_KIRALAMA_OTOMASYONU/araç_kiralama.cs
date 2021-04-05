using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    class araç_kiralama
    {
        OleDbConnection con = new OleDbConnection
   ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");

        public DataTable listele(OleDbDataAdapter adapter, string sorgu)
        {
            DataTable tablo = new DataTable();
            adapter = new OleDbDataAdapter(sorgu, con);
            adapter.Fill(tablo);
            con.Close();
            return tablo;



        }
        public void ekle_guncelle(OleDbCommand komut, string sorgu)
        
        {
            con.Open();
            komut.Connection = con;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }

        public void bosaraclar(ComboBox combo,string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu,con);
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                combo.Items.Add(oku["PLAKA"].ToString());

            }
            con.Close();
        }
        public void tcara( TextBox tc, TextBox ad, TextBox soyad, TextBox gsm, TextBox adres, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ad.Text = oku["ADI"].ToString();
                soyad.Text = oku["SOYADI"].ToString();
                gsm.Text = oku["GSM_NO"].ToString();
                adres.Text = oku["ACIK_ADRES"].ToString();

            }
            con.Close();
            
        }
        public void ücrethesapla(ComboBox combokirasekli, TextBox ucret, string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (combokirasekli.SelectedIndex == 0) ucret.Text =( int.Parse(oku["ARAC_KIRASI"].ToString()) * 1).ToString();
                if (combokirasekli.SelectedIndex == 1) ucret.Text = (int.Parse(oku["ARAC_KIRASI"].ToString()) * 0.80).ToString();
                if (combokirasekli.SelectedIndex == 2) ucret.Text=(int.Parse(oku["ARAC_KIRASI"].ToString()) * 0.70).ToString();



            }
            con.Close();
        }

            public void combodangetir(ComboBox araclar, TextBox marka, TextBox model, TextBox modelyili, TextBox yakıtürü, TextBox vitestürü, TextBox renk ,string sorgu)
        {
            con.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, con);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                marka.Text = oku["MARKA"].ToString();
                model.Text = oku["MODEL"].ToString();
                modelyili.Text = oku["MODEL_YILI"].ToString();
                yakıtürü.Text = oku["YAKIT_TURU"].ToString();
                vitestürü.Text = oku["VITES_TURU"].ToString();
                renk.Text = oku["RENK"].ToString();

            }
            con.Close();
        }
    }
}
