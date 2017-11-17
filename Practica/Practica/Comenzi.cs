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
    public partial class Comenzi : Form
    {
        OdbcConnection conexiune;
        DataSet dsDate;
        int nrTotalInregistrari;
        int indexInregistrareCurenta;
        string tipOperatiune;

        public Comenzi()
        {
            InitializeComponent();
        }
        private void deschideConexiunea()
        {
            try
            {
                //initializez o conexiune in mod explicit        
                conexiune = new OdbcConnection();
                //stabilesc stringul de conectare 
                conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
                conexiune.Open();
                OdbcCommand comanda;
                comanda = new OdbcCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM comenzi";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblComenzi;
                tblComenzi = new DataTable("Comenzi");
                tblComenzi.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblComenzi);
                nrTotalInregistrari = dsDate.Tables["Comenzi"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Comenzi = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
        private void populeazaBonFiscal()
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
            comanda.CommandText = "select * from bonuri_fiscale ";
            comanda.Connection = conexiune;

            dsDate = new DataSet();
            cititor = comanda.ExecuteReader();
            tblBonuriFiscale = new DataTable("BonuriFiscale");
            tblBonuriFiscale.Load(cititor);
            dsDate.Tables.Add(tblBonuriFiscale);
            this.cmbIdBF.DataSource = dsDate.Tables["BonuriFiscale"];
            this.cmbIdBF.DisplayMember = "idBonFiscal";
            this.cmbIdBF.ValueMember = "idBonFiscal";
            conexiune.Close();
        }
        private void populeazaLivrare()
        {
            OdbcConnection conexiune;
            OdbcCommand comanda;
            DataSet dsDate;
            OdbcDataReader cititor;
            DataTable tblLivrare;

            conexiune = new OdbcConnection();
            conexiune.ConnectionString = "Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10";
            conexiune.Open();
            comanda = new OdbcCommand();
            comanda.CommandText = "select * from livrari ";
            comanda.Connection = conexiune;

            dsDate = new DataSet();
            cititor = comanda.ExecuteReader();
            tblLivrare = new DataTable("IdLivrare");
            tblLivrare.Load(cititor);
            dsDate.Tables.Add(tblLivrare);
            this.cmbIdLivrare.DataSource = dsDate.Tables["IdLivrare"];
            this.cmbIdLivrare.DisplayMember = "idLivrare";
            this.cmbIdLivrare.ValueMember = "idLivrare";
            conexiune.Close();
        }

        private void Comenzi_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            tableLayoutPanel4.Visible = false;
            populeazaBonFiscal();
            populeazaLivrare();
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtNrComanda.Text = dsDate.Tables["Comenzi"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtDataComanda.Text = dsDate.Tables["Comenzi"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtStatusComanda.Text = dsDate.Tables["Comenzi"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtIdLivrare.Text = dsDate.Tables["Comenzi"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtIdBonFiscal.Text = dsDate.Tables["Comenzi"].Rows[nrInregistrare].ItemArray[4].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtNrComanda.Enabled = false;
            txtDataComanda.Enabled = false;
            txtStatusComanda.Enabled = false;
            txtIdLivrare.Enabled = false;
            txtIdBonFiscal.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtNrComanda.Enabled = true;
            txtDataComanda.Enabled = true;
            txtStatusComanda.Enabled = true;
            txtIdLivrare.Enabled = true;
            txtIdBonFiscal.Enabled = true;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void btnPrimul_Click(object sender, EventArgs e)
        {
            indexInregistrareCurenta = 0;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void btnUrmator_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta < nrTotalInregistrari - 1)
                indexInregistrareCurenta++;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void btnUltimul_Click(object sender, EventArgs e)
        {
            indexInregistrareCurenta = nrTotalInregistrari - 1;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            tipOperatiune = "adaugare";
            activeazaCaseteText();
            txtNrComanda.Text = "";
            txtDataComanda.Text = "";
            txtStatusComanda.Text = "";
            txtIdLivrare.Text = "";
            txtIdBonFiscal.Text = "";
            txtNrComanda.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false;
            tableLayoutPanel4.Visible = true;
        }
        private void dezactiveazaNavigare()
        {
            btnPrecedent.Visible = false;
            btnUrmator.Visible = false;
            btnPrimul.Visible = false;
            btnUltimul.Visible = false;
        }
        private void activeazaNavigare()
        {
            btnPrecedent.Visible = true;
            btnUrmator.Visible = true;
            btnPrimul.Visible = true;
            btnUltimul.Visible = true;
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            if (tipOperatiune == "adaugare")
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "INSERT INTO comenzi VALUES (?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("NrComanda", txtNrComanda.Text.ToString());
                    comanda.Parameters.AddWithValue("DataComanda", DataComanda.Text.ToString());
                    comanda.Parameters.AddWithValue("StatusComanda", CmbStatusComanda.Text.ToString());
                    comanda.Parameters.AddWithValue("IdLivrare", cmbIdLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("IdBonFiscal", cmbIdBF.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Comanda clientului a fost adăugată cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtNrComanda.Visible = true;
                    btnModificare.Visible = true;
                    tableLayoutPanel4.Visible = false;
                    deschideConexiunea();
                    afisareInregistrareCurenta(indexInregistrareCurenta);
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroare nr. " + eroare.ErrorCode.ToString() + " cu mesajul " +
                        eroare.Message.ToString());
                }
            }
            if (tipOperatiune == "modificare")
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "UPDATE comenzi SET DataComanda=?,StatusComanda=?,IdLivrare=?, IdBonFiscal=? WHERE NrComanda=?";
                    comanda.Parameters.AddWithValue("DataComanda", txtDataComanda.Text.ToString());
                    comanda.Parameters.AddWithValue("StatusComanda", txtStatusComanda.Text.ToString());
                    comanda.Parameters.AddWithValue("IdLivrare", txtIdLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("IdBonFiscal", txtIdBonFiscal.Text.ToString());
                    comanda.Parameters.AddWithValue("NrComanda", txtNrComanda.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat comanda cu codul: " + txtNrComanda.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    btnModificare.Visible = true;
                    deschideConexiunea();
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                }
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            //incerc stergerea, dupa confirmarea de la utilizator 
            if (MessageBox.Show("Sigur doriţi ştergerea comenzii curente ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM comenzi WHERE NrComanda=?";
                    comanda.Parameters.AddWithValue("NrComanda", txtNrComanda.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters comanda !");
                    deschideConexiunea();
                    afisareInregistrareCurenta(indexInregistrareCurenta);
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                }
            } 
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            tipOperatiune = "modificare";
            dezactiveazaNavigare();
            activeazaCaseteText();
            btnAdaugare.Visible = false;
            btnStergere.Visible = false;
            btnModificare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            txtNrComanda.Enabled = false;
            txtIdLivrare.Enabled = false;
            txtIdBonFiscal.Enabled = false;
            tableLayoutPanel4.Visible = false;
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            activeazaNavigare();
            dezactiveazaCaseteText();
            btnAnulare.Visible = false;
            btnSalvare.Visible = false;
            btnAdaugare.Visible = true;
            btnStergere.Visible = true;
            btnModificare.Visible = true;
            afisareInregistrareCurenta(indexInregistrareCurenta);
            txtNrComanda.Visible = true;
            tableLayoutPanel4.Visible = false;
        }
    }
}
