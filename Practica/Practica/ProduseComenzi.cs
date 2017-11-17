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
    public partial class ProduseComenzi : Form
    {
        public ProduseComenzi()
        {
            InitializeComponent();
        }

        private void ProduseComenzi_Load(object sender, EventArgs e)
        {
           try
            {

                grdComenzi.DataSource = "";
                grdBonuriFiscale.DataSource = "";
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10"; conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.CommandText = "SELECT * FROM produse";
                comanda.Connection = conexiune;
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataSet dsDate;
                dsDate = new DataSet();
                DataTable tblProduse;
                tblProduse = new DataTable("Produse");
                tblProduse.Load(cititor);
                dsDate.Tables.Add(tblProduse);

                this.cboProduse.DataSource = dsDate.Tables["Produse"];
                this.cboProduse.DisplayMember = "denProdus";
                this.cboProduse.ValueMember = "idProdus";
                cboProduse.Text = "";
                conexiune.Close();

                
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.ToString());
            }
        }

        private void cboProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblComenzi;

                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "SELECT * FROM cantitati_comandate WHERE idProdus=?";
                comanda.Connection = conexiune;

                string pIdProdus;
                pIdProdus = cboProduse.SelectedValue.ToString();

                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idProdus", pIdProdus);

                cititor = comanda.ExecuteReader();
                tblComenzi = new DataTable("Comenzi");
                tblComenzi.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblComenzi);
                cboProduse.SelectedItem = 0;

                grdComenzi.DataSource = dsDate;
                grdComenzi.DataMember = "Comenzi";
                grdComenzi.Refresh();

                lblTotalComenzi.Text = "Total comenzi = " + dsDate.Tables["Comenzi"].Rows.Count.ToString();
          }
            catch (Exception eroare)
            {
                //MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void grdComenzi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblBonuriFiscale;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select * from bonuri_fiscale inner join comenzi on bonuri_fiscale.idBonFiscal=comenzi.idBonFiscal where comenzi.nrComanda=? order by bonuri_fiscale.idBonFiscal";
                comanda.Connection = conexiune;

                int pNrComanda;
                pNrComanda = Int32.Parse(grdComenzi.CurrentRow.Cells[0].FormattedValue.ToString());
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@nrComanda", pNrComanda);

                cititor = comanda.ExecuteReader();
                tblBonuriFiscale = new DataTable("Bonuri");
                tblBonuriFiscale.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblBonuriFiscale);

                grdBonuriFiscale.DataSource = dsDate;
                grdBonuriFiscale.DataMember = "Bonuri";
                grdBonuriFiscale.Refresh();
                lblTotalBonuri.Text = "Total bonuri = " + dsDate.Tables["Bonuri"].Rows.Count.ToString();
                conexiune.Close();
            }

            catch (Exception eroare)
           {
                //MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }
    }
}
