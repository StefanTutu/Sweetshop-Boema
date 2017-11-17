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
    public partial class BonuriFiscale : Form
    {
        OdbcConnection conexiune;
        DataSet dsDate;
        int nrTotalInregistrari;
        int indexInregistrareCurenta;
        string tipOperatiune;

        public BonuriFiscale()
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
                comanda.CommandText = "SELECT * FROM bonuri_fiscale";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblBonuriFiscale;
                tblBonuriFiscale = new DataTable("Bonuri Fiscale");
                tblBonuriFiscale.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblBonuriFiscale);
                nrTotalInregistrari = dsDate.Tables["Bonuri Fiscale"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Bonuri Fiscale = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }


        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdBonFiscal.Text = dsDate.Tables["Bonuri Fiscale"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtDataVanzare.Text = dsDate.Tables["Bonuri Fiscale"].Rows[nrInregistrare].ItemArray[1].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdBonFiscal.Enabled = false;
            txtDataVanzare.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdBonFiscal.Enabled = true;
            txtDataVanzare.Enabled = true;
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

        private void btnAdaugare_Click_1(object sender, EventArgs e)
        {
            tipOperatiune = "adaugare";
            activeazaCaseteText();
            txtIdBonFiscal.Text = "";
            txtDataVanzare.Text = "";
            txtIdBonFiscal.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false;
            tableLayoutPanel4.Visible = true;
        }

        private void btnStergere_Click_1(object sender, EventArgs e)
        {
            //incerc stergerea, dupa confirmarea de la utilizator 
            if (MessageBox.Show("Sigur stergi bonul fiscal curent?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM bonuri_fiscale WHERE idBonFiscal=?";
                    comanda.Parameters.AddWithValue("idBonFiscal", txtIdBonFiscal.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a sters Bonul Fiscal!");
                    deschideConexiunea();
                    afisareInregistrareCurenta(indexInregistrareCurenta);
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                }
            }
        }

        private void btnModificare_Click_1(object sender, EventArgs e)
        {
            tipOperatiune = "modificare";
            dezactiveazaNavigare();
            activeazaCaseteText();
            btnAdaugare.Visible = false;
            btnStergere.Visible = false;
            btnModificare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            txtIdBonFiscal.Enabled = false;
            tableLayoutPanel4.Visible = false;
        }

        private void btnSalvare_Click_1(object sender, EventArgs e)
        {
            if (tipOperatiune == "adaugare")
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "INSERT INTO bonuri_fiscale VALUES (?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idBonFiscala", txtIdBonFiscal.Text.ToString());
                    comanda.Parameters.AddWithValue("DataVanzare", DataVanzare.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Bonul fiscal a fost adaugat in baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdBonFiscal.Visible = true;
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
                    comanda.CommandText = "UPDATE bonuri_fiscale SET DataVanzare=? WHERE idBonFiscal=?";
                    comanda.Parameters.AddWithValue("DataVanzare", txtDataVanzare.Text.ToString());
                    comanda.Parameters.AddWithValue("idBonFiscal", txtIdBonFiscal.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat bonul fiscal cu codul " + txtIdBonFiscal.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    deschideConexiunea();
                    tableLayoutPanel4.Visible = false;
                    btnModificare.Visible = true;
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                }
            }
        }

        private void btnAnulare_Click_1(object sender, EventArgs e)
        {
            activeazaNavigare();
            dezactiveazaCaseteText();
            btnAnulare.Visible = false;
            btnSalvare.Visible = false;
            btnAdaugare.Visible = true;
            btnStergere.Visible = true;
            btnModificare.Visible = true;
            afisareInregistrareCurenta(indexInregistrareCurenta);
            txtIdBonFiscal.Visible = true;
            tableLayoutPanel4.Visible = false;
        }

        private void BonuriFiscale_Load_1(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            tableLayoutPanel4.Visible = false;
        }

        private void btnPrimul_Click_1(object sender, EventArgs e)
        {
            indexInregistrareCurenta = 0;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
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
    }
}
