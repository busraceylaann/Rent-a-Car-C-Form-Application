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
    public partial class müşteri_listesi : Form
    {
        public müşteri_listesi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        //OleDbDataReader dr;

        public void listele()
        {
            string sec = "select * from MUSTERI_BILGILERI";
            OleDbDataAdapter da = new OleDbDataAdapter(sec, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI_BILGILERI");
        }
        bool kontrol;
        private void btnyenikayıtekle_Click(object sender, EventArgs e)
        {
            müsteri_kayıt_formu müsteri_Kayıt_ = new müsteri_kayıt_formu();
            this.Hide();
            müsteri_Kayıt_.ShowDialog();
            this.Show();
        }

        private void müşteri_listesi_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * From MUSTERI_BILGILERI", con);
            da.Fill(ds, "MUSTERI_BILGILERI");
            dataGridView1.DataSource = ds.Tables["MUSTERI_BILGILERI"];
            da.Dispose();
            con.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Kaydı Silmek istediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)

            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("delete from [MUSTERI_BILGILERI] where MUSTERI_ID=@MUSTERI_ID", con);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("MUSTERI_BILGILERI", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                listele();
                con.Close();
            }
        }

        private void müsteriarama_TextChanged(object sender, EventArgs e)
        {
            string seckomutu = "select*from MUSTERI_BILGILERI where MUSTERI_ID like '%" + müsteriarama.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(seckomutu, con);
            ds.Clear();
            da.Fill(ds, "MUSTERI_BILGILERI");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            müsteri_güncelleme_formu.musteri_id = (dataGridView1.CurrentRow.Cells["MUSTERI_ID"].Value).ToString();
            kontrol = true;
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (kontrol == false)
            {
                MessageBox.Show("Lütfen Düzenlemek İstediğinz Müşteriyi Seçiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                müsteri_güncelleme_formu müsteri_Güncelleme_Formu = new müsteri_güncelleme_formu();
                this.Hide();
                müsteri_Güncelleme_Formu.ShowDialog();
                this.Show();
            }
        }
    }
}
