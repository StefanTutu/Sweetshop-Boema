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
    public partial class Incasari : Form
    {
        public Incasari()
        {
            InitializeComponent();
        }
        OdbcConnection conexiune;
        DataSet dsDate;
        int nrTotalInregistrari;
        int indexInregistrareCurenta;
        string tipOperatiune;
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
                comanda.CommandText = "SELECT * FROM incasari";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblIncasari;
                tblIncasari = new DataTable("Incasari");
                tblIncasari.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblIncasari);
                nrTotalInregistrari = dsDate.Tables["Incasari"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Incasari = " + nrTotalInregistrari);
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

        private void Incasari_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            tableLayoutPanel4.Visible = false;
            populeazaBonFiscal();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdIncasare.Text = dsDate.Tables["Incasari"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtIdBonFiscal.Text = dsDate.Tables["Incasari"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtDataIncasare.Text = dsDate.Tables["Incasari"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtModPlata.Text = dsDate.Tables["Incasari"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtSumaIncasata.Text = dsDate.Tables["Incasari"].Rows[nrInregistrare].ItemArray[4].ToString();
		}
        private void dezactiveazaCaseteText()
        {
            txtIdIncasare.Enabled = false;
            txtIdBonFiscal.Enabled = false;
            txtDataIncasare.Enabled = false;
            txtModPlata.Enabled = false;
            txtSumaIncasata.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdIncasare.Enabled = true;
            txtIdBonFiscal.Enabled = true;
            txtDataIncasare.Enabled = true;
            txtModPlata.Enabled = true;
            txtSumaIncasata.Enabled = true;
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
            txtIdIncasare.Text = "";
            txtIdBonFiscal.Text = "";
            txtDataIncasare.Text = "";
            txtModPlata.Text = "";
            txtSumaIncasata.Text = "";
            txtIdIncasare.Focus();
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
                    comanda.CommandText = "INSERT INTO incasari VALUES (?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idIncasare", txtIdIncasare.Text.ToString());
                    comanda.Parameters.AddWithValue("idBonFiscal", cmbIdBF.Text.ToString());
                    comanda.Parameters.AddWithValue("DataIncasare", DataIncasare.Text.ToString());
                    comanda.Parameters.AddWithValue("ModPlata", cmbModPlata.Text.ToString());
                    comanda.Parameters.AddWithValue("SumaIncasata", txtSumaIncasata.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Încasarea a fost adăugată cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdIncasare.Visible = true;
                    btnModificare.Visible = true;
                    deschideConexiunea();
                    afisareInregistrareCurenta(indexInregistrareCurenta);
                    tableLayoutPanel4.Visible = false;
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
                    comanda.CommandText = "UPDATE incasari SET idBonFiscal=?,DataIncasare=?,ModPlata=?, SumaIncasata=? WHERE idIncasare=?";
                    comanda.Parameters.AddWithValue("idBonFiscal", txtIdBonFiscal.Text.ToString());
                    comanda.Parameters.AddWithValue("DataIncasare", txtDataIncasare.Text.ToString());
                    comanda.Parameters.AddWithValue("ModPlata", txtModPlata.Text.ToString());
                    comanda.Parameters.AddWithValue("SumaIncasata", txtSumaIncasata.Text.ToString());
                    comanda.Parameters.AddWithValue("idIncasare", txtIdIncasare.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat încasarea cu codul: " + txtIdIncasare.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    btnModificare.Visible = true;
                    deschideConexiunea();
                    tableLayoutPanel4.Visible = false;
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
            if (MessageBox.Show("Sigur doriţi ştergerea încasării curente ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM incasari WHERE idIncasare=?";
                    comanda.Parameters.AddWithValue("idIncasare", txtIdIncasare.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters încasarea !");
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
            txtIdIncasare.Enabled = false;
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
            txtIdIncasare.Visible = true;
            tableLayoutPanel4.Visible = false;
        }
    }
}
