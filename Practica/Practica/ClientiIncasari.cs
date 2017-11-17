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
    public partial class ClientiIncasari : Form
    {
        public ClientiIncasari()
        {
            InitializeComponent();
        }

        private void ClientiIncasari_Load(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.CommandText = "SELECT * FROM clienti";
                comanda.Connection = conexiune;
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataSet dsDate;
                dsDate = new DataSet();
                DataTable tblClienti;
                tblClienti = new DataTable("Clienti");
                tblClienti.Load(cititor);
                dsDate.Tables.Add(tblClienti);

                this.cboClient.DataSource = dsDate.Tables["Clienti"];
                this.cboClient.DisplayMember = "numecl";
                this.cboClient.ValueMember = "codcl";
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea1: " + eroare.Message.ToString());
            }
        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
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
                comanda.CommandText = "select idbf_comanda,nrliniebf_comanda,bonuri_fiscale_comenzi.idprodus,bonuri_fiscale_comenzi.iddiscount,pretcudiscount from clienti inner join adrese_livrare on clienti.codCl=adrese_livrare.codCl inner join comenzi on adrese_livrare.nrcomanda=comenzi.nrcomanda inner join bonuri_fiscale on comenzi.idbonfiscal=bonuri_fiscale.idbonfiscal inner join bonuri_fiscale_comenzi on bonuri_fiscale.idbonfiscal=bonuri_fiscale_comenzi.idbf_comanda where clienti.codcl=?";
                comanda.Connection = conexiune;

                string pCodCl;
                pCodCl = cboClient.SelectedValue.ToString();
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@codCl", pCodCl);

                cititor = comanda.ExecuteReader();
                tblBonuri = new DataTable("Bonuri");
                tblBonuri.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblBonuri);

                grdBonuri.DataSource = dsDate;
                grdBonuri.DataMember = "Bonuri";
                grdBonuri.Refresh();

                lblTotalBonuri.Text = "Total bonuri = " + dsDate.Tables["Bonuri"].Rows.Count.ToString();

                /*comanda.CommandText = "SELECT SUM(pretcudiscount) AS total clienti inner join adrese_livrare on clienti.codCl=adrese_livrare.codCl inner join comenzi on adrese_livrare.nrcomanda=comenzi.nrcomanda inner join bonuri_fiscale on comenzi.idbonfiscal=bonuri_fiscale.idbonfiscal inner join bonuri_fiscale_comenzi on bonuri_fiscale.idbonfiscal=bonuri_fiscale_comenzi.idbf_comanda where clienti.codcl=?";
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("codcl", pCodCl);
                cititor = comanda.ExecuteReader();
                //definim o tabela "locala"
                DataTable tblTotalBonuri;
                tblTotalBonuri = new DataTable("TOTALBonuri");
                tblTotalBonuri.Load(cititor);
                DataSet dsDateBonuri = new DataSet();
                dsDateBonuri.Tables.Add(tblTotalBonuri);
                lblTotalBonuri.Text = "Total Bonuri = " + dsDateBonuri.Tables["TOTALBonuri"].Rows[0].ItemArray[0].ToString();*/
            }
            catch (Exception eroare)
            {
               // MessageBox.Show("A aparut eroarea2: " + eroare.Message.ToString());
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
                comanda.CommandText = "select distinct idIncasare,incasari.idbonfiscal,dataincasare,modplata,sumaincasata from incasari inner join bonuri_fiscale_comenzi on incasari.idbonfiscal=bonuri_fiscale_comenzi.idbf_comanda where bonuri_fiscale_comenzi.idbf_comanda=?";
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
                lblTotalIncasari.Text = "Total incasari = " + dsDate.Tables["Incasari"].Rows.Count.ToString();
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea3: " + eroare.Message.ToString());
            }
        }
    }
}
