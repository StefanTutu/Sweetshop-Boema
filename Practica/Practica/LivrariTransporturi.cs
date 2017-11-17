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
    public partial class LivrariTransporturi : Form
    {
        public LivrariTransporturi()
        {
            InitializeComponent();
        }

        private void LivrariTransporturi_Load(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.CommandText = "select * from angajati where functie='Sofer'";
                comanda.Connection = conexiune;
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataSet dsDate;
                dsDate = new DataSet();
                DataTable tblSoferi;
                tblSoferi = new DataTable("Soferi");
                tblSoferi.Load(cititor);
                dsDate.Tables.Add(tblSoferi);

                this.cboSofer.DataSource = dsDate.Tables["Soferi"];
                this.cboSofer.DisplayMember = "numeprenangajat";
                this.cboSofer.ValueMember = "idAngajat";
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void cboSofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection conexiune;
                OdbcCommand comanda;
                DataSet dsDate;
                OdbcDataReader cititor;
                DataTable tblTransporturi;

                conexiune = new OdbcConnection();
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                comanda = new OdbcCommand();
                comanda.CommandText = "select transporturi.idTransport,dataplecare,nrinmatr,transporturi.idSofer from transporturi inner join soferi on transporturi.idSofer=soferi.idSofer inner join angajati on soferi.idSofer=angajati.idAngajat where idAngajat=?";
                comanda.Connection = conexiune;

                string pIdAngajat;
                pIdAngajat = cboSofer.SelectedValue.ToString();
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idAngajat", pIdAngajat);

                cititor = comanda.ExecuteReader();
                tblTransporturi = new DataTable("Transporturi");
                tblTransporturi.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblTransporturi);

                grdTransporturi.DataSource = dsDate;
                grdTransporturi.DataMember = "Transporturi";
                grdTransporturi.Refresh();

                lblTotalTransporturi.Text = "Total transporturi = " + dsDate.Tables["Transporturi"].Rows.Count.ToString();
            }
            catch (Exception eroare)
            {
                //MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }

        private void grdTransporturi_SelectionChanged(object sender, EventArgs e)
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
                comanda.CommandText = "select * from livrari where idTransport=?";
                comanda.Connection = conexiune;

                int pIdTransport;
                pIdTransport = Int32.Parse(grdTransporturi.CurrentRow.Cells[0].FormattedValue.ToString());
                comanda.Parameters.Clear();
                comanda.Parameters.AddWithValue("@idTransport", pIdTransport);

                cititor = comanda.ExecuteReader();
                tblLivrari = new DataTable("Livrari");
                tblLivrari.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblLivrari);

                grdLivrari.DataSource = dsDate;
                grdLivrari.DataMember = "Livrari";
                grdLivrari.Refresh();
                lblTotalLivrari.Text = "Total livrari = " + dsDate.Tables["Livrari"].Rows.Count.ToString();
                conexiune.Close();
            }

            catch (Exception eroare)
            {
                //MessageBox.Show("A aparut eroarea: " + eroare.Message.ToString());
            }
        }
    }
}
