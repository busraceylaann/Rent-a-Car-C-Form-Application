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
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        private void rapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet.ARAC' table. You can move, or remove it, as needed.
            this.ARACTableAdapter.Fill(this.finalDataSet.ARAC);

            this.reportViewer1.RefreshReport();
        }
    }
}
