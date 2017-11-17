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
    public partial class Clienti : Form
    {
        OdbcConnection conexiune;
        DataSet dsDate;
        int nrTotalInregistrari;
        int indexInregistrareCurenta;
        string tipOperatiune;

        public Clienti()
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
                comanda.CommandText = "SELECT * FROM clienti";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblClienti;
                tblClienti = new DataTable("Clienti");
                tblClienti.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblClienti);
                nrTotalInregistrari = dsDate.Tables["Clienti"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Clienti = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
        private void PopuleazaClienti()
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM clienti ORDER BY CodCl";
            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();
            DataTable tblClient;
            tblClient = new DataTable("Client");
            tblClient.Load(cititor);
            dsDate.Tables.Add(tblClient);
        }
        private void Clienti_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtCodCl.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtNumeCl.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtAdresaCl.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtLocCl.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtJudCl.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[4].ToString();
            txtSoldCurent.Text = dsDate.Tables["Clienti"].Rows[nrInregistrare].ItemArray[5].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtCodCl.Enabled = false;
            txtNumeCl.Enabled = false;
            txtAdresaCl.Enabled = false;
            txtLocCl.Enabled = false;
            txtJudCl.Enabled = false;
            txtSoldCurent.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtCodCl.Enabled = true;
            txtNumeCl.Enabled = true;
            txtAdresaCl.Enabled = true;
            txtLocCl.Enabled = true;
            txtJudCl.Enabled = true;
            txtSoldCurent.Enabled = true;
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
            txtCodCl.Text = "";
            txtNumeCl.Text = "";
            txtAdresaCl.Text = "";
            txtLocCl.Text = "";
            txtJudCl.Text = "";
            txtSoldCurent.Text = "";
            txtCodCl.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false;
            txtAdresaCl.Text = "Exemplu: Strada, Numar ";
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
                    comanda.CommandText = "INSERT INTO clienti VALUES (?,?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("CodCle", txtCodCl.Text.ToString());
                    comanda.Parameters.AddWithValue("NumeCl", txtNumeCl.Text.ToString());
                    comanda.Parameters.AddWithValue("AdresaCl", txtAdresaCl.Text.ToString());
                    comanda.Parameters.AddWithValue("LocCl", txtLocCl.Text.ToString());
                    comanda.Parameters.AddWithValue("JudCl", txtJudCl.Text.ToString());
                    comanda.Parameters.AddWithValue("SoldCurent", txtSoldCurent.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Clientul a fost adăugat cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtCodCl.Visible = true;
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
                    comanda.CommandText = "UPDATE clienti SET NumeCl=?,AdresaCl=?,LocCl=?,JudCl=?,SoldCurent=? WHERE CodCl=?";
                    comanda.Parameters.AddWithValue("NumeCl", txtNumeCl.Text.ToString());
                    comanda.Parameters.AddWithValue("AdresaCl", txtAdresaCl.Text.ToString());
                    comanda.Parameters.AddWithValue("LocCl", txtLocCl.Text.ToString());
                    comanda.Parameters.AddWithValue("JudCl", txtJudCl.Text.ToString());
                    comanda.Parameters.AddWithValue("SoldCurent", txtSoldCurent.Text.ToString());
                    comanda.Parameters.AddWithValue("CodCle", txtCodCl.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat clientul cu codul: " + txtCodCl.Text.ToString());
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
            if (MessageBox.Show("Sigur doriţi ştergerea clientului curent ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM clienti WHERE CodCl=?";
                    comanda.Parameters.AddWithValue("CodCl", txtCodCl.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters clientul !");
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
            txtCodCl.Enabled = false;
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
            txtCodCl.Visible = true; 
        }

        private void txtAdresaCl_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdresaCl.Enabled = true;
            txtAdresaCl.Text = "";
        }

        private void txtAdresaCl_MouseLeave(object sender, EventArgs e)
        {
            if (txtAdresaCl.Text == "")
            {
                txtAdresaCl.Text = "Exemplu: Strada, Numar";
            }
        }
    }
}
