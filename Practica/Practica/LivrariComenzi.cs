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
    public partial class LivrariComenzi : Form
    {
        public LivrariComenzi()
        {
            InitializeComponent();
        }

        private void LivrariComenzi_Load(object sender, EventArgs e)
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
                DataTable tblProduse;
                tblProduse = new DataTable("Clienti");
                tblProduse.Load(cititor);
                dsDate.Tables.Add(tblProduse);

                this.cboClienti.DataSource = dsDate.Tables["Clienti"];
                this.cboClienti.DisplayMember = "numeCl";
                this.cboClienti.ValueMember = "codCl";
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void cboClienti_SelectedIndexChanged(object sender, EventArgs e)
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
                comanda.CommandText = " select nrComanda,dataComanda,statusComanda,idLivrare,idBonfiscal from clienti_livrari where codcl=?";
                comanda.Connection = conexiune;

                string pCodCl;
                pCodCl = cboClienti.SelectedValue.ToString();
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@codCl", pCodCl);

                cititor = comanda.ExecuteReader();
                tblComenzi = new DataTable("Comenzi");
                tblComenzi.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblComenzi);

                grdComenzi.DataSource = dsDate;
                grdComenzi.DataMember = "Comenzi";
                grdComenzi.Refresh();
                lblTotalComenzi.Text = "Total comenzi = " + dsDate.Tables["Comenzi"].Rows.Count.ToString();
                conexiune.Close();
            }
            catch (Exception eroare)
            {
               // MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
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
                DataTable tblLivrari;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select livrari.idlivrare, loclivrare,judlivrare,datalivrare,idtransport from comenzi inner join livrari on comenzi.idlivrare=livrari.idlivrare where nrComanda=?";
                comanda.Connection = conexiune;

                int pNrComanda;
                pNrComanda = Int32.Parse(grdComenzi.CurrentRow.Cells[0].FormattedValue.ToString());
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@nrComanda", pNrComanda);

                cititor = comanda.ExecuteReader();
                tblLivrari = new DataTable("Livrari");
                tblLivrari.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblLivrari);

                grdLivrari.DataSource = dsDate;
                grdLivrari.DataMember = "Livrari";
                grdLivrari.Refresh();
                lblLivrari.Text = "Total Livrari = " + dsDate.Tables["Livrari"].Rows.Count.ToString();
                conexiune.Close();
            }

            catch (Exception eroare)
            {
                //MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }
    }
}
