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
    public partial class Rapor4 : Form
    {
        public Rapor4()
        {
            InitializeComponent();
        }

        private void Rapor4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.PERSONEL_BILGILERI' table. You can move, or remove it, as needed.
            this.PERSONEL_BILGILERITableAdapter.Fill(this.finalDataSet.PERSONEL_BILGILERI);

            this.reportViewer1.RefreshReport();
        }
    }
}
