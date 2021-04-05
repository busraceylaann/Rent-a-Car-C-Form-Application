using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class Rapor3 : Form
    {
        public Rapor3()
        {
            InitializeComponent();
        }

        private void Rapor3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet3.MUSTERI_BILGILERI' table. You can move, or remove it, as needed.
            this.MUSTERI_BILGILERITableAdapter.Fill(this.finalDataSet3.MUSTERI_BILGILERI);

            this.reportViewer1.RefreshReport();
        }
    }
}
