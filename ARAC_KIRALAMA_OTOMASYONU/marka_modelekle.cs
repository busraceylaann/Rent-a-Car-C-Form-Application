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
    public partial class marka_modelekle : Form
    {
        public marka_modelekle()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;
        int markaıd;

        void markacek()
        {
            comboBox1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand();
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select*from MARKA";
            dr = cmd.ExecuteReader();
            while(dr.Read())
                {
                comboBox1.Items.Add(dr["MARKA_ADI"]);
               }
        }
        private void marka_modelekle_Load(object sender, EventArgs e)
        {
            GBMARKA.Visible = false;
            markacek();
            comboBox1.Refresh();


        }

        private void LBMARKAEKLE_Click(object sender, EventArgs e)
        {
            GBMARKA.Visible = true;
            GBMODEL.Visible = true;
          
        }

        private void LBMODELEKLE_Click(object sender, EventArgs e)
        {
            GBMARKA.Visible = false;
            GBMODEL.Visible = true;
        }

        private void btneklee2_Click(object sender, EventArgs e)
        {
            if (TBMARKADI.Text == "")
            {
                MessageBox.Show("MARKA BOŞ GEÇİLEMEZ");
            }
            else
            {
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = con;
                cmdd.CommandText = "select * from MARKA where MARKA_ADI='" + TBMARKADI.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cc = MessageBox.Show("Aynı marka bulunmaktadır.Lütfen farklı marka adı seçiniz...");
                    if (cc == DialogResult.OK)
                    {
                        TBMARKADI.Clear();
                    }
                }
                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into MARKA (MARKA_ADI) values(@MARKA_ADI)";
                    cmd.Parameters.AddWithValue("@MARKA_ADI", TBMARKADI.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult cc = MessageBox.Show("KAYIT YAPILMIŞTIR,BAŞKA KAYIT EKLEMEK İSTİYOR MUSUNUZ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.No == cc)
                    {
                        marka_modelekle marka_Modelekle = new marka_modelekle();
                        this.Hide();
                        marka_Modelekle.ShowDialog();
                    }
                    else if (DialogResult.Yes == cc)
                    {
                        TBMARKADI.Clear();

                    }

                }

            }
                  
               
            
        }
                       
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            if (con.State == ConnectionState.Closed) con.Open();
            cmd.CommandText = "select MARKA_ID from MARKA where MARKA_ADI='" + comboBox1.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read()) 
            {
                markaıd = int.Parse(dr.GetValue(0).ToString());

            }
            dr.Close();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        { if (comboBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("MARKA ADI VE MODEL ADI BOŞ GEÇİLEMEZ MARKA ADI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand cmdd = new OleDbCommand();
                cmdd.Connection = con;
                cmdd.CommandText = "select * from MODEL where MODEL_ADI='" + textBox1.Text + "'";
                if (con.State == ConnectionState.Closed) con.Open();
                dr = cmdd.ExecuteReader();
                if (dr.Read())
                {
                    DialogResult cd = MessageBox.Show("Aynı Model bulunmaktadır.Lütfen farklı Model adı seçiniz...");
                    if (cd == DialogResult.OK)
                    {
                        textBox1.Clear();
                    }
                }
                else
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into MODEL(MODEL_ADI,MARKA_ID) values(@MODEL_ADI,@MARKA_ID)";
                    cmd.Parameters.AddWithValue("@MODEL_ADI", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MARKA_ID", markaıd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult cc = MessageBox.Show("KAYIT YAPILMIŞTIR,BAŞKA KAYIT EKLEMEK İSTİYOR MUSUNUZ?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult.No == cc)
                    {
                        Araç_kayıt marka_Modelekle = new Araç_kayıt();
                        this.Hide();
                        marka_Modelekle.ShowDialog();
                    }
                    else if (DialogResult.Yes == cc)
                    {
                        textBox1.Clear();

                    }
                }
            }

        }

        private void btngeri2_Click(object sender, EventArgs e)
        {
            marka_modelekle marka_Modelekle = new marka_modelekle();
            this.Hide();
            marka_Modelekle.ShowDialog();
        }

        private void TBMARKADI_TextChanged(object sender, EventArgs e)
        {
            TBMARKADI.Text = TBMARKADI.Text.ToUpper();
            TBMARKADI.SelectionStart = TBMARKADI.Text.Length;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            comboBox1.Text = comboBox1.Text.ToUpper();
            comboBox1.SelectionStart = comboBox1.Text.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void BTNGERİ_Click(object sender, EventArgs e)
        {
            Araç_kayıt araç_Kayıt = new Araç_kayıt();
            this.Hide();
            araç_Kayıt.ShowDialog();
        }
    }
}
