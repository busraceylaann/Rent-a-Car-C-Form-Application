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
    public partial class SÖZLESME : Form
    {
        public SÖZLESME()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        araç_kiralama Araç_Kiralama = new araç_kiralama();
        private void SÖZLESME_Load(object sender, EventArgs e)
        {
            bosaraclar();
            yenile();
        }

        private void bosaraclar()
        {
            string sorgu2 = "select*from ARAC where DURUMU ='Boş'";
            Araç_Kiralama.bosaraclar(cbaracplakası, sorgu2);
        }

        private void yenile()
        {
            string sorgu3 = "select*from ARAC_KIRALAMA";
            OleDbDataAdapter adapter2 = new OleDbDataAdapter();
            dataGridView1.DataSource = Araç_Kiralama.listele(adapter2, sorgu3);
        }

        private void cbaracplakası_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select* from ARAC where PLAKA like '" + cbaracplakası.SelectedItem + "'";
            Araç_Kiralama.combodangetir(cbaracplakası, tbmarka, tbmodel, tbmodelyıl, tbyakittürü, tbvites, tbrenk, sorgu2);
        }

        private void cbkirasekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select* from ARAC where PLAKA like '" + cbaracplakası.SelectedItem + "'";
            Araç_Kiralama.ücrethesapla(cbkirasekli, tbkiraücreti, sorgu2);
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gün = (DateTime.Parse(dtpgiris.Text) - DateTime.Parse(dtpcıkıs.Text));
            int gün2 = gün.Days;
            tbgün.Text = gün2.ToString();
            tbtutar.Text = (gün2 * int.Parse(tbkiraücreti.Text)).ToString();
          
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            dtpcıkıs.Text = DateTime.Now.ToShortDateString();
            dtpgiris.Text = DateTime.Now.ToShortDateString();
            cbkirasekli.Text = "";
            tbgün.Text = "";
            tbkiraücreti.Text = "";
            tbtutar.Text = "";
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            if (tbtc.Text == "" || tbadi.Text == "" || tbsoyadi.Text == "" || tbgsm.Text == "" || tbadres.Text == "" || cbaracplakası.Text == "" || tbmarka.Text == "" || tbmodel.Text == "" || tbmodelyıl.Text == "" || tbyakittürü.Text == "" || tbvites.Text == "" || tbrenk.Text == "" || cbkirasekli.Text == "" || tbkiraücreti.Text == "" || tbgün.Text == "" || tbtutar.Text == "" || dtpcıkıs.Text == "" || dtpgiris.Text == "" )
            {
                MessageBox.Show("Tüm Alanları Doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = con;
                cmd3.CommandText = "select *from ARAC_KIRALAMA where PLAKA='" + cbaracplakası.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd3.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cevap = MessageBox.Show("ARAÇ KİRALANMIŞTIR LÜTFEN BOŞ BİR ARAÇ SEÇİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cevap == DialogResult.OK)
                    {
                        cbaracplakası.Items.Clear();
                    }
                }
                else
                {
                    string sorgu2 = "insert into ARAC_KIRALAMA(TC,AD,SOYAD,GSM_NO,ADRES,PLAKA,MARKA,MODEL,MODEL_YILI,YAKIT_TURU,VİTES_TURU,RENK,KIRA_SEKLI,KIRA_UCRETI,GUN,TUTAR,CIKIS,DONUS) " +
                     "values(@TC,@AD,@SOYAD,@GSM_NO,@ADRES,@PLAKA,@MARKA,@MODEL,@MODEL_YILI,@YAKIT_TURU,@VİTES_TURU,@RENK,@KIRA_SEKLI,@KIRA_UCRETI,@GUN,@TUTAR,@CIKIS,@DONUS) ";
                    OleDbCommand cmd = new OleDbCommand(sorgu2);

                    cmd.Parameters.AddWithValue("@TC", tbtc.Text);
                    cmd.Parameters.AddWithValue("@AD", tbadi.Text);
                    cmd.Parameters.AddWithValue("@SOYAD", tbsoyadi.Text);
                    cmd.Parameters.AddWithValue("@GSM_NO,", tbgsm.Text);
                    cmd.Parameters.AddWithValue("@ADRES", tbadres.Text);
                    cmd.Parameters.AddWithValue("@PLAKA", cbaracplakası.Text);
                    cmd.Parameters.AddWithValue("@MARKA", tbmarka.Text);
                    cmd.Parameters.AddWithValue("@MODEL", tbmodel.Text);
                    cmd.Parameters.AddWithValue("@MODEL_YILI", tbmodelyıl.Text);
                    cmd.Parameters.AddWithValue("@YAKIT_TURU", tbyakittürü.Text);
                    cmd.Parameters.AddWithValue("@VITES_TURU", tbvites.Text);
                    cmd.Parameters.AddWithValue("@RENK", tbrenk.Text);
                    cmd.Parameters.AddWithValue("@KIRA_SEKLI", cbkirasekli.Text);
                    cmd.Parameters.AddWithValue("@KIRA_UCRETI", tbkiraücreti.Text);
                    cmd.Parameters.AddWithValue("@GUN", tbgün.Text);
                    cmd.Parameters.AddWithValue("@TUTAR", tbtutar.Text);
                    cmd.Parameters.AddWithValue("@CIKIS", dtpcıkıs.Text);
                    cmd.Parameters.AddWithValue("@DONUS", dtpgiris.Text);
                     Araç_Kiralama.ekle_guncelle(cmd, sorgu2);

                    string sorgu3 = "update ARAC set DURUMU ='DOLU'where PLAKA='" + cbaracplakası.Text + "'";
                    OleDbCommand cmd2= new OleDbCommand();
                    Araç_Kiralama.ekle_guncelle(cmd2, sorgu3);
                    cbaracplakası.Items.Clear();
                    bosaraclar();
                    yenile();
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                    cbaracplakası.Text = "";
                    temizle();
                    MessageBox.Show("ARACINIZ KİRALANMIŞTIR","BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            if (tbtc.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from MUSTERI_BILGILERI where TC like '" + tbtc.Text + "'";
            Araç_Kiralama.tcara(tbtc, tbadi, tbsoyadi, tbgsm, tbadres, sorgu2);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update ARAC_KIRALAMA set TC=@TC,AD=@AD,SOYAD=@SOYAD,GSM_NO=@GSM_NO,ADRES=@ADRES,PLAKA=@PLAKA,MARKA=@MARKA,MODEL=@MODEL,MODEL_YILI=@MODEL_YILI,YAKIT_TURU=@YAKIT_TURU,VİTES_TURU=@VİTES_TURU,RENK=@RENK,KIRA_SEKLI=@KIRA_SEKLI,KIRA_UCRETI=@KIRA_UCRETI,GUN=@GUN,TUTAR=@TUTAR,CIKIS=@CIKIS,DONUS=@DONUS where PLAKA=@PLAKA";
            OleDbCommand cmd = new OleDbCommand(sorgu2);

            cmd.Parameters.AddWithValue("@TC", tbtc.Text);
            cmd.Parameters.AddWithValue("@AD", tbadi.Text);
            cmd.Parameters.AddWithValue("@SOYAD", tbsoyadi.Text);
            cmd.Parameters.AddWithValue("@GSM_NO,", tbgsm.Text);
            cmd.Parameters.AddWithValue("@ADRES", tbadres.Text);
            cmd.Parameters.AddWithValue("@PLAKA", cbaracplakası.Text);
            cmd.Parameters.AddWithValue("@MARKA", tbmarka.Text);
            cmd.Parameters.AddWithValue("@MODEL", tbmodel.Text);
            cmd.Parameters.AddWithValue("@MODEL_YILI", tbmodelyıl.Text);
            cmd.Parameters.AddWithValue("@YAKIT_TURU", tbyakittürü.Text);
            cmd.Parameters.AddWithValue("@VİTES_TURU", tbvites.Text);      
            cmd.Parameters.AddWithValue("@RENK", tbrenk.Text);
            cmd.Parameters.AddWithValue("@KIRA_SEKLI", cbkirasekli.Text);
            cmd.Parameters.AddWithValue("@KIRA_UCRETI", tbkiraücreti.Text);
            cmd.Parameters.AddWithValue("@GUN", tbgün.Text);
            cmd.Parameters.AddWithValue("@TUTAR", tbtutar.Text);
            cmd.Parameters.AddWithValue("@CIKIS", dtpcıkıs.Text);
            cmd.Parameters.AddWithValue("@DONUS", dtpgiris.Text);
            Araç_Kiralama.ekle_guncelle(cmd, sorgu2);

            cbaracplakası.Items.Clear();
            bosaraclar();
            yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cbaracplakası.Text = "";           
            temizle();
            MessageBox.Show("Güncelleme Tamamlandı","BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btntemizle.Enabled = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            tbtc.Text = satır.Cells[1].Value.ToString();
            tbadi.Text = satır.Cells[2].Value.ToString();
            tbsoyadi.Text = satır.Cells[3].Value.ToString();
            tbgsm.Text = satır.Cells[4].Value.ToString();
            tbadres.Text = satır.Cells[5].Value.ToString();
            cbaracplakası.Text = satır.Cells[6].Value.ToString();
            tbmarka.Text = satır.Cells[7].Value.ToString();
            tbmodel.Text = satır.Cells[8].Value.ToString();
            tbmodelyıl.Text = satır.Cells[9].Value.ToString();
            tbyakittürü.Text = satır.Cells[10].Value.ToString();
            tbvites.Text = satır.Cells[11].Value.ToString();
            tbrenk.Text = satır.Cells[12].Value.ToString();
            cbkirasekli.Text = satır.Cells[13].Value.ToString();
            tbkiraücreti.Text = satır.Cells[14].Value.ToString();
            tbgün.Text = satır.Cells[15].Value.ToString();
            tbtutar.Text = satır.Cells[16].Value.ToString();
            dtpcıkıs.Value = Convert.ToDateTime(satır.Cells[17].Value.ToString());
            dtpgiris.Value = Convert.ToDateTime(satır.Cells[18].Value.ToString());
            btntemizle.Enabled = false;

        }

        private void btnaracteslim_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string sorgu1 = "delete from ARAC_KIRALAMA where PLAKA='" + satır.Cells["PLAKA"].Value.ToString() + "'";
            OleDbCommand cmd1 = new OleDbCommand();
            Araç_Kiralama.ekle_guncelle(cmd1, sorgu1);
            string sorgu2 = "Update ARAC set DURUMU='BOŞ' where PLAKA='" + satır.Cells["PLAKA"].Value.ToString() + "'";
            OleDbCommand cmd2 = new OleDbCommand();
            Araç_Kiralama.ekle_guncelle(cmd2, sorgu2);
            MessageBox.Show("ARAÇ TESLİM EDİLDİ","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            cbaracplakası.Text = "";
            cbaracplakası.Items.Clear();
            bosaraclar();
            yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            cbaracplakası.Text = "";
            temizle();

        }

        private void tbadi_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void tbkiraücreti_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
