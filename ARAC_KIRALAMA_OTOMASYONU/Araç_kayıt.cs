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
    public partial class Araç_kayıt : Form
    {
        public Araç_kayıt()
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

        void markacek()
        {
            cbmarka.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from MARKA";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbmarka.Items.Add(dr["MARKA_ADI"]);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {    if(tbplakano.Text==""||tbmotorhacmi.Text==""||tbmodelyili.Text==""||tbarackırasi.Text==""||cbmarka.Text==""||cbmodel.Text==""||cbrenk.Text==""||cbvites.Text==""||cbyakittürü.Text==""||dtpeklemetarihi.Text==""||dtpgüncellemetarihi.Text==""||pictureBox1.ImageLocation==""|| kontrol==false)
            {
                MessageBox.Show("TÜM KISIMLARI DOLDURUNUZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con;
                cmd2.CommandText = "select*from ARAC  where PLAKA='" + tbplakano.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cevap = MessageBox.Show("AYNI PLAKA İLE KAYIT YAPILAMAZ.LÜTFEN FARKLI PLAKA KİMLİK NUMARASI GİRİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (cevap == DialogResult.OK)
                    {
                        tbplakano.Clear();
                    }

                }
                else
                {
                    con.Close();

                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO ARAC (PLAKA,MARKA,MODEL,MOTOR_HACMİ,YAKIT_TURU,MODEL_YILI,EKLEME_TARIHI,GUNCELLEME_TARIHI,RENK,VITES_TURU,ARAC_KIRASI,DURUMU,RESIM) " +

                    "VALUES (@PLAKA,@MARKA,@MODEL,@MOTOR_HACMİ,@YAKIT_TURU,@MODEL_YILI,@EKLEME_TARIHI,@GUNCELLEME_TARIHI,@RENK,@VITES_TURU,@ARAC_KIRASI,@DURUMU,@RESIM)";




                    cmd.Parameters.AddWithValue("@PLAKA", tbplakano.Text);

                    cmd.Parameters.AddWithValue("@MARKA", cbmarka.Text);

                    cmd.Parameters.AddWithValue("@MODEL", cbmodel.Text);

                    cmd.Parameters.AddWithValue("@MOTOR_HACMİ", tbmotorhacmi.Text);

                    cmd.Parameters.AddWithValue("@YAKIT_TURU", cbyakittürü.Text);

                    cmd.Parameters.AddWithValue("@MODEL_YILI", tbmodelyili.Text);

                    cmd.Parameters.AddWithValue("@EKLEME_TARIHI", dtpeklemetarihi.Text);

                    cmd.Parameters.AddWithValue("@GUNCELLEME_TARIHI", dtpgüncellemetarihi.Text);

                    cmd.Parameters.AddWithValue("@RENK", cbrenk.Text);

                    cmd.Parameters.AddWithValue("@VITES_TURU", cbvites.Text);

                    cmd.Parameters.AddWithValue("@ARAC_KIRASI", tbarackırasi.Text);

                    cmd.Parameters.AddWithValue("@DURUMU", "BOŞ");

                    cmd.Parameters.AddWithValue("@RESIM", pictureBox1.ImageLocation);



                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("KAYIT BAŞARIYLA GERÇEKLEŞTİ");
                }
            }
        }

        private void btnkaydettt_Click(object sender, EventArgs e)
        {
            arac_listesi arac_Listesi = new arac_listesi();
            this.Hide();
            arac_Listesi.ShowDialog();
        }

        private void Araç_kayıt_FormClosed(object sender, FormClosedEventArgs e)
        {

           arac_listesi arac_Listesi = (arac_listesi)Application.OpenForms["arac_listesi"];
            arac_Listesi.listele() ;
        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            kontrol = true;
        }

       

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MARKA_ID from MARKA where MARKA_ADI='" + cbmarka.Text + "'";
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
            cbmodel.Items.Clear();
            while (dr.Read())
            {
                cbmodel.Items.Add(dr["MODEL_ADI"]);
            }

        }

        private void cbmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MODEL_ID from MODEL where MODEL_ADI='" + cbmodel.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                modelid = int.Parse(dr.GetValue(0).ToString());
            }
            dr.Close();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            marka_modelekle marka_Modelekle = new marka_modelekle();
            this.Hide();
            marka_Modelekle.ShowDialog();
            this.Show();
        }

        private void tbmotorhacmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbplakano_TextChanged(object sender, EventArgs e)
        { 
            tbplakano.Text = tbplakano.Text.ToUpper();
            tbplakano.SelectionStart = tbplakano.Text.Length;
        }

       

        private void tbmodelyili_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rapor rp = new rapor();
            rp.Show();
        }

        private void Araç_kayıt_Load(object sender, EventArgs e)
        {
            markacek();
        }
    }
    }


