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
    public partial class kontrol : Form
    {
        public static string guvkul { get; set; }
        public kontrol()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=final.mdb");
        DataSet ds = new DataSet();
        OleDbDataAdapter da = new OleDbDataAdapter();
        BindingSource bs = new BindingSource();
        OleDbDataReader dr;

        private void bttamam_Click(object sender, EventArgs e)
        {
            if (tbsifre.Text == "")
            {
                MessageBox.Show("Şifreyi Giriniz");
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from UYE_KAYIT_OLMA where UYE_KULLANICI_ADI ='" + guvkul + "' and UYE_SİFRE=" + int.Parse(tbsifre.Text) + "";
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    uye_islem uye_İslem = new uye_islem();
                    uye_islem.kulad = guvkul;
                    this.Hide();
                    uye_İslem.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre Girdiniz");
                }
                con.Close();
            }
            
        }

        private void btiptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
