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
    public partial class RaportAngajati : Form
    {
        public RaportAngajati()
        {
            InitializeComponent();
        }

        private void RaportAngajati_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAngajati.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetAngajati.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
