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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

       public  void verileri_cek()
        {
            string sec = "select * from personel_bılgılerı";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "personel_bılgılerı");
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        bool kontrol;
      

        private void personel_Load(object sender, EventArgs e)
        {
           
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From PERSONEL_BILGILERI", con);
            da.Fill(ds,"PERSONEL_BILGILERI");
            dataGridView1.DataSource = ds.Tables["PERSONEL_BILGILERI"];
            da.Dispose();
            con.Close();
        }

        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            personel_yeni_kayit personel_Yeni_Kayit = new personel_yeni_kayit();
            this.Hide();
            personel_Yeni_Kayit.ShowDialog();
            this.Show();
            

        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

         DialogResult   cevap = MessageBox.Show("Kaydı Silmek istediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)

            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [PERSONEL_BILGILERI] where PERSONEL_ID=@PERSONEL_ID",con);   
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("PERSONEL_ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                verileri_cek();
                con.Close();

               
            }
        }

        private void tbpersonelarama_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select*from PERSONEL_BILGILERI where TC like '%" + tbpersonelarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, con);
            ds.Clear();
            da.Fill(ds, "PERSONEL_BILGILERI");
        }

        private void btnduzenle_Click(object sender, EventArgs e)
        { if (kontrol == false)

            {
                MessageBox.Show("Lütfen Düzenlemek İstediğiniz Personeli Seçin!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                personel_güncelleme_formu personel_Güncelleme = new personel_güncelleme_formu();
                this.Hide();
                personel_Güncelleme.ShowDialog();
                this.Show();
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            personel_güncelleme_formu.personel_id = (dataGridView1.CurrentRow.Cells["PERSONEL_ID"].Value).ToString();
            kontrol = true;

        }
    }
}
