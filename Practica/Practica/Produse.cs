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
    public partial class Produse : Form
    {
        OdbcConnection conexiune;
        DataSet dsDate;
        int nrTotalInregistrari;
        int indexInregistrareCurenta;
        string tipOperatiune;

        public Produse()
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
                comanda.CommandText = "SELECT * FROM produse";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblProduse;
                tblProduse = new DataTable("Produse");
                tblProduse.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblProduse);
                nrTotalInregistrari = dsDate.Tables["Produse"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Produse = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
        private void PopuleazaProduse()
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM produse ORDER BY idProdus";
            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();
            DataTable tblProd;
            tblProd = new DataTable("Prod");
            tblProd.Load(cititor);
            dsDate.Tables.Add(tblProd);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
        }
         private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdProdus.Text = dsDate.Tables["Produse"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtDenumireProdus.Text = dsDate.Tables["Produse"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtUMProdus.Text = dsDate.Tables["Produse"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtPretCatalog.Text = dsDate.Tables["Produse"].Rows[nrInregistrare].ItemArray[3].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdProdus.Enabled = false;
            txtDenumireProdus.Enabled = false;
            txtUMProdus.Enabled = false;
            txtPretCatalog.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdProdus.Enabled = true;
            txtDenumireProdus.Enabled = true;
            txtUMProdus.Enabled = true;
            txtPretCatalog.Enabled = true;
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
            txtIdProdus.Text = "";
            txtDenumireProdus.Text = "";
            txtUMProdus.Text = "";
            txtPretCatalog.Text = "";
            txtIdProdus.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false; 
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
                    comanda.CommandText = "INSERT INTO produse VALUES (?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idProdus", txtIdProdus.Text.ToString());
                    comanda.Parameters.AddWithValue("DenProdus", txtDenumireProdus.Text.ToString());
                    comanda.Parameters.AddWithValue("UM_Produs", txtUMProdus.Text.ToString());
                    comanda.Parameters.AddWithValue("PretCatalog", txtPretCatalog.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Produsul a fost adăugat cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdProdus.Visible = true;
                    btnModificare.Visible = true;
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
                    comanda.CommandText = "UPDATE produse SET DenProdus=?,UM_Produs=?,PretCatalog=? WHERE idProdus=?";
                    comanda.Parameters.AddWithValue("DenProdus", txtDenumireProdus.Text.ToString());
                    comanda.Parameters.AddWithValue("UM_Produs", txtUMProdus.Text.ToString());
                    comanda.Parameters.AddWithValue("PretCatalog", txtPretCatalog.Text.ToString());
                    comanda.Parameters.AddWithValue("idProdus", txtIdProdus.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat produsul cu codul: " + txtIdProdus.Text.ToString());
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
            if (MessageBox.Show("Sigur doriţi ştergerea produsului curent ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM produse WHERE idProdus=?";
                    comanda.Parameters.AddWithValue("idProdus", txtIdProdus.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters produsul !");
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
            txtIdProdus.Enabled = false; 
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
            txtIdProdus.Visible = true; 
        }
    }
}