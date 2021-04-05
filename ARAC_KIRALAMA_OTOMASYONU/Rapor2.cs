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
    public partial class Rapor2 : Form
    {
        public Rapor2()
        {
            InitializeComponent();
        }

        private void Rapor2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalDataSet2.ARAC_KIRALAMA' table. You can move, or remove it, as needed.
            this.ARAC_KIRALAMATableAdapter.Fill(this.finalDataSet2.ARAC_KIRALAMA);

            this.reportViewer1.RefreshReport();
        }
    }
}
