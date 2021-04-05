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
    public partial class arac_listesi : Form
    {
        public arac_listesi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
       OleDbDataReader dr;
        bool kontrol;
        int markaid, modelid;
        public void listele()
        {
            string sec = "select * from ARAC";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "ARAC");
        }
        void arama(string aranan)
        {

            ds.Clear();
            if (ds.Tables["ARAC"] != null) ds.Tables["ARAC"].Clear();
            string seckomutu = aranan;
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, con);
            da.Fill(ds, "ARAC");
        }
        void verilericek()
        {
            ds.Clear();
            string komut = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMİ,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_KIRASI,A.DURUMU,A.RESIM from ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI and DURUMU='BOŞ'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, con);
            if (con.State == ConnectionState.Closed) con.Open();
            da.Fill(ds, "ARAC");
            bs.DataSource = ds.Tables["ARAC"];
            dataGridView1.DataSource = bs;
            con.Close();
        }
        void markacek()
        {
            CBMARKAARAMA.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from MARKA";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CBMARKAARAMA.Items.Add(dr["MARKA_ADI"]);
            }
        }

        private void arac_listesi_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From ARAC", con);
            da.Fill(ds, "ARAC");
            dataGridView1.DataSource = ds.Tables["ARAC"];
            da.Dispose();
            con.Close();
            cmbara.SelectedIndex = 0;
            markacek();
            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydı Silmek istediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)

            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [ARAC] where PLAKA=@PLAKA", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("PLAKA", dataGridView1.CurrentRow.Cells[1].Value);
                cmd.ExecuteNonQuery();
                listele();
                con.Close();


            }
        }

        private void aracarama_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select*from ARAC where PLAKA like '%" + aracarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, con);
            ds.Clear();
            da.Fill(ds, "ARAC");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            arac_güncelleme.plaka = (dataGridView1.CurrentRow.Cells["PLAKA"].Value).ToString();
            kontrol = true;
         
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            ANASAYFA an = new ANASAYFA();
            this.Hide();
            an.ShowDialog();
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Lütfen Düzenlemek İstediğiniz Aracı Seçiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                arac_güncelleme arac_Güncelleme = new arac_güncelleme();
                this.Hide();
                arac_Güncelleme.ShowDialog();
                this.Show();
                verilericek();
            }  
            
        }

        private void btnyenikayıtekle_Click(object sender, EventArgs e)
        {
            Araç_kayıt araç_Kayıt = new Araç_kayıt();
            this.Hide();
            araç_Kayıt.ShowDialog();
            this.Show();
        }

        private void checkBox1_TextChanged(object sender, EventArgs e)
        {
          //  if (checkBox1.Checked) listele();
        }

       private void cbdurumara_SelectedIndexChanged(object sender, EventArgs e)
        {
        //DAHA SONRA BAK
        }

        private void cmbara_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbara.SelectedIndex==0)
                {
                    listele();
                }
                if (cmbara.SelectedIndex==1)
                {
                    string sec = "select * from ARAC where DURUMU ='Boş'";
                    OleDbDataAdapter da2 = new OleDbDataAdapter(sec, con);
                    ds.Clear();
                    da2.Fill(ds,"ARAC");
                }
                if (cmbara.SelectedIndex == 2)
                {
                    string sec = "select * from ARAC where DURUMU ='Dolu'";
                    OleDbDataAdapter da2 = new OleDbDataAdapter(sec, con);
                    ds.Clear();
                    da2.Fill(ds, "ARAC");
                }
            }
            catch { }
        }

        private void CBMODELARAMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MODEL_ID from MODEL where MODEL_ADI='" + CBMODELARAMA.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                modelid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void BTNARAMA_Click(object sender, EventArgs e)
        {
            if (CBMODELARAMA.SelectedIndex > 0 || CBMARKAARAMA.SelectedIndex > 0 )
            {
                string seckomutu = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMİ,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_KIRASI,A.DURUMU,A.RESIM FROM ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI and MARKA_ADI like '" + CBMARKAARAMA.Text + "%' and MODEL_ADI like '" + CBMODELARAMA.Text +  "%'and DURUMU='BOŞ'";
                arama(seckomutu);
            }
            else if (CBMODELARAMA.SelectedIndex < 0 || CBMARKAARAMA.SelectedIndex < 0 )
            {
                string seckomutu = "select Ma.MARKA_ADI,M.MODEL_ADI,A.ARAC_ID,A.PLAKA,A.MODEL,A.MARKA,A.MOTOR_HACMİ,A.YAKIT_TURU,A.VITES_TURU,A.RENK,A.EKLEME_TARIHI,A.GUNCELLEME_TARIHI,A.RENK,A.MODEL_YILI,A.ARAC_KIRASI,A.DURUMU,A.RESIM FROM ARAC as [A],MARKA as [Ma],MODEL as [M] where M.MARKA_ID=Ma.MARKA_ID and A.MARKA=Ma.MARKA_ADI and MARKA_ADI like '" + CBMARKAARAMA.Text + "%'and DURUMU='BOŞ'";
                arama(seckomutu);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void BTNGERİ_Click(object sender, EventArgs e)
        {
            //arac_listesi arac = new arac_listesi();
            //this.Hide();
            //arac.ShowDialog();
            verilericek();
        }

        private void CBMARKAARAMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MARKA_ID from MARKA where MARKA_ADI='" + CBMARKAARAMA.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               markaid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from MODEL where MARKA_ID=" + markaid + "";
            dr = cmd.ExecuteReader();
            CBMODELARAMA.Items.Clear();
            while (dr.Read())
            {
                CBMODELARAMA.Items.Add(dr["MODEL_ADI"]);
                CBMODELARAMA.Text = "";
            }
            
        }
    }
}
