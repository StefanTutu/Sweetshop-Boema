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
    public partial class VanzariProprii_Incasari : Form
    {
        public VanzariProprii_Incasari()
        {
            InitializeComponent();
        }

        private void VanzariProprii_Incasari_Load(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
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

                this.cboProdus.DataSource = dsDate.Tables["Produse"];
                this.cboProdus.DisplayMember = "denProdus";
                this.cboProdus.ValueMember = "idProdus";
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void cboProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblBonuri;

                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select * from bonuri_fiscale_vanzari where idProdus=?";
                comanda.Connection = conexiune;

                string pIdProdus;
                pIdProdus = cboProdus.SelectedValue.ToString();
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idProdus", pIdProdus);

                cititor = comanda.ExecuteReader();
                tblBonuri = new DataTable("Bonuri");
                tblBonuri.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblBonuri);

                grdBonuri.DataSource = dsDate;
                grdBonuri.DataMember = "Bonuri";
                grdBonuri.Refresh();

                lblBonuri.Text = "Total bonuri = " + dsDate.Tables["Bonuri"].Rows.Count.ToString();
            }
            catch (Exception eroare)
            {
               // MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void grdBonuri_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblIncasari;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select distinct idIncasare,incasari.idbonfiscal,dataincasare,modplata,sumaincasata from incasari inner join bonuri_fiscale_vanzari on incasari.idbonfiscal=bonuri_fiscale_vanzari.idbf_vanzare where bonuri_fiscale_vanzari.idbf_vanzare=?";
                comanda.Connection = conexiune;

                int pIdBonFiscal;
                pIdBonFiscal = Int32.Parse(grdBonuri.CurrentRow.Cells[0].FormattedValue.ToString());
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idbonfiscal", pIdBonFiscal);

                cititor = comanda.ExecuteReader();
                tblIncasari = new DataTable("Incasari");
                tblIncasari.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblIncasari);

                grdIncasari.DataSource = dsDate;
                grdIncasari.DataMember = "Incasari";
                grdIncasari.Refresh();
                lblIncasari.Text = "Total incasari = " + dsDate.Tables["Incasari"].Rows.Count.ToString();
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }
    }
}
