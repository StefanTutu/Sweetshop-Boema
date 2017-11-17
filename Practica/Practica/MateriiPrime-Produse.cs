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
    public partial class MateriiPrime_Produse : Form
    {
        public MateriiPrime_Produse()
        {
            InitializeComponent();
        }

        private void MateriiPrime_Produse_Load(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.CommandText = "SELECT * FROM materii_prime";
                comanda.Connection = conexiune;
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataSet dsDate;
                dsDate = new DataSet();
                DataTable tblMateriiPrime;
                tblMateriiPrime = new DataTable("Materii prime");
                tblMateriiPrime.Load(cititor);
                dsDate.Tables.Add(tblMateriiPrime);

                this.cboMatPrima.DataSource = dsDate.Tables["Materii prime"];
                this.cboMatPrima.DisplayMember = "denmatprima";
                this.cboMatPrima.ValueMember = "idmatprima";
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void cboMatPrima_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblProduse;

                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select produse.idProdus,denProdus,um_produs,pretCatalog from materii_prime inner join reteta_produs on materii_prime.idMatPrima=reteta_produs.idMatPrima inner join produse on reteta_produs.idProdus=produse.idProdus WHERE materii_prime.idMatPrima=?";
                comanda.Connection = conexiune;

                string pIdMatPrima;
                pIdMatPrima = cboMatPrima.SelectedValue.ToString();
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idMatPrima", pIdMatPrima);

                cititor = comanda.ExecuteReader();
                tblProduse = new DataTable("Produse");
                tblProduse.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblProduse);

                grdProduse.DataSource = dsDate;
                grdProduse.DataMember = "Produse";
                grdProduse.Refresh();

                lblTotalProduse.Text = "Total Produse = " + dsDate.Tables["Produse"].Rows.Count.ToString();
            }
            catch (Exception eroare)
            {
                //MessageBox.Show("A aparut eroarea1 : " + eroare.Message.ToString());
            }
        }

        private void grdProduse_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblTVA;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select * from tva where idProdus=?";
                comanda.Connection = conexiune;

                int pIdProdus;
                pIdProdus = Int32.Parse(grdProduse.CurrentRow.Cells[0].FormattedValue.ToString());
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idProdus", pIdProdus);

                cititor = comanda.ExecuteReader();
                tblTVA = new DataTable("TVA");
                tblTVA.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblTVA);

                grdTva.DataSource = dsDate;
                grdTva.DataMember = "TVA";
                grdTva.Refresh();
                lblTotalTva.Text = "Total Tva = " + dsDate.Tables["TVA"].Rows.Count.ToString();
                conexiune.Close();
            }

            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea : " + eroare.Message.ToString());
            }
        }
    }
}
