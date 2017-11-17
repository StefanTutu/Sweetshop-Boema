using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Practica
{
    public partial class RaportSalariiAngajati : Form
    {
        public RaportSalariiAngajati()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            deschideconexiune();
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
            
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.FillBy(this.DataSet1.DataTable1,comboBox1.Text);

            this.reportViewer1.RefreshReport();
           
        }
        private void deschideconexiune()
        {
            try
            {
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.CommandText = "SELECT DISTINCT functie FROM angajati";
                comanda.Connection = conexiune;
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataSet dsDate;
                dsDate = new DataSet();
                DataTable tblAngajati;
                tblAngajati = new DataTable("Angajati");
                tblAngajati.Load(cititor);
                dsDate.Tables.Add(tblAngajati);

                this.comboBox1.DataSource = dsDate.Tables["Angajati"];
                this.comboBox1.DisplayMember = "functie";
                this.comboBox1.ValueMember = "functie";
                conexiune.Close();
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());

            }
        }
      
    }
}
