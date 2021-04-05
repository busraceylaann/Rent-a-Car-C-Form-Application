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
    public partial class arac_güncelleme : Form
    {
        public static string plaka { get; set; }

        public arac_güncelleme()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
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
        void verilericek()
        {
            ds.Clear();
            object b = plaka;
            string komut = "select*from ARAC where PLAKA = '" + plaka + "'";
            OleDbDataAdapter db = new OleDbDataAdapter(komut, con);
            db.Fill(ds, "ARAC");
        }

        private void btngüncelleme_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  ARAC set PLAKA=@PLAKA,MARKA=@MARKA,MODEL=@MODEL,MOTOR_HACMİ=@MOTOR_HACMİ," +
                "YAKIT_TURU=@YAKIT_TURU,MODEL_YILI=@MODEL_YILI,EKLEME_TARIHI=@EKLEME_TARIHI,GUNCELLEME_TARIHI=@GUNCELLEME_TARIHI,RENK=@RENK,VITES_TURU=@VITES_TURU," +
                "ARAC_KIRASI=@ARAC_KIRASI,RESIM=@RESIM where PLAKA = '" + plaka+ "'";


            cmd.Parameters.AddWithValue("@PLAKA", tbplakano.Text);

            cmd.Parameters.AddWithValue("@MARKA", cbmarka.Text);

            cmd.Parameters.AddWithValue("@MODEL", cbmodel.Text);

            cmd.Parameters.AddWithValue("@MOTOR_HACMİ", tbmotorhacmi.Text);

            cmd.Parameters.AddWithValue("@YAKIT_TURU", cbyakittürü.Text);

            cmd.Parameters.AddWithValue("@MODEL_YILI", tbmodelyili.Text);

            cmd.Parameters.AddWithValue("@EKLEME_TARIHI", dtpeklemetarihi.Text);

            cmd.Parameters.AddWithValue("@GUNCELLEME_TARIHI", dtpgüncellemetarihi.Text);

            cmd.Parameters.AddWithValue("@RENK", cbrenk.Text);

            cmd.Parameters.AddWithValue("@VITES_TURU", cbvites.SelectedItem);

            cmd.Parameters.AddWithValue("@ARAC_KIRASI", tbarackırasi.Text);         
            

            cmd.Parameters.AddWithValue("@RESIM", pictureBox1.ImageLocation);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("KAYIT GÜNCELLEMESİ GERÇEKLEŞTİ");


        }

        private void arac_güncelleme_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            verilericek();
            bs.DataSource = ds.Tables["ARAC"];
            tbplakano.DataBindings.Clear();
            cbmarka.DataBindings.Clear();
            cbmodel.DataBindings.Clear();
            tbmodelyili.DataBindings.Clear();
            tbmotorhacmi.DataBindings.Clear();
            cbrenk.DataBindings.Clear();
            cbvites.DataBindings.Clear();
            dtpeklemetarihi.DataBindings.Clear();
            dtpgüncellemetarihi.DataBindings.Clear();
            cbyakittürü.DataBindings.Clear();
            tbarackırasi.DataBindings.Clear();        
            pictureBox1.DataBindings.Clear();



            tbplakano.DataBindings.Add("Text", bs, "PLAKA");
            cbmarka.DataBindings.Add("Text", bs, "MARKA");
            cbmodel.DataBindings.Add("Text", bs, "MODEL");
            tbmodelyili.DataBindings.Add("Text", bs, "MODEL_YILI");
            tbmotorhacmi.DataBindings.Add("Text", bs, "MOTOR_HACMİ");
            cbrenk.DataBindings.Add("Text", bs, "RENK");
            cbvites.DataBindings.Add("Text", bs, "VITES_TURU");
            dtpgüncellemetarihi.DataBindings.Add("Text", bs, "GUNCELLEME_TARIHI");
            cbyakittürü.DataBindings.Add("Text", bs, "YAKIT_TURU");
            dtpeklemetarihi.DataBindings.Add("Text", bs, "EKLEME_TARIHI");
            tbarackırasi.DataBindings.Add("Text",bs,"ARAC_KIRASI");
          
            pictureBox1.DataBindings.Add("ImageLocation", bs,"RESIM");
            con.Close();
            markacek();
        }

        private void arac_güncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {

            arac_listesi arac_Listesi = (arac_listesi)Application.OpenForms["arac_Listesi"];
            arac_Listesi.listele();
        }

        private void btnvazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNRESİMGUNCELLE_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resim\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
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

        private void tbplakano_TextChanged(object sender, EventArgs e)
        {
            tbplakano.Text = tbplakano.Text.ToUpper();
            tbplakano.SelectionStart = tbplakano.Text.Length;
        }

        private void tbmodelyili_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbmotorhacmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
    }
}
