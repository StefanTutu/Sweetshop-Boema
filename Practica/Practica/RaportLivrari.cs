using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class RaportLivrari : Form
    {
        public RaportLivrari()
        {
            InitializeComponent();
        }

        private void RaportLivrari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetLivrari.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetLivrari.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
