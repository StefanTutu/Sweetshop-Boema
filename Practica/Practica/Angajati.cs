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
using System.Globalization;
using System.Threading;

namespace Practica
{
    public partial class Angajati : Form
    {
        public Angajati()
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
                comanda.CommandText = "SELECT * FROM angajati";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblMateriiPrime;
                tblMateriiPrime = new DataTable("Angajati");
                tblMateriiPrime.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblMateriiPrime);
                nrTotalInregistrari = dsDate.Tables["Angajati"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar materii prime = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
       /* private void PopuleazaAngajat()
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM angajati ORDER BY idAngajat";
            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();
            DataTable tblAngajat;
            tblAngajat = new DataTable("Angajat");
            tblAngajat.Load(cititor);
            dsDate.Tables.Add(tblAngajat);
        }*/

        private void Angajati_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            DataAngajare.Visible = false;
            DataNastere.Visible = false;
            tableLayoutPanel4.Visible = false;
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdAngajat.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtNumePrenAngajat.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtAdresaAngajat.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtTelefon.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtFunctie.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[4].ToString();
            txtDataAngajare.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[5].ToString();
            txtDataNastere.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[6].ToString();
            txtCNP.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[7].ToString();
            txtActIdentitate.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[8].ToString();
            txtObs.Text = dsDate.Tables["Angajati"].Rows[nrInregistrare].ItemArray[9].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdAngajat.Enabled = false;
            txtNumePrenAngajat.Enabled = false;
            txtAdresaAngajat.Enabled = false;
            txtTelefon.Enabled = false;
            txtFunctie.Enabled = false;
            txtDataAngajare.Enabled = false;
            txtDataNastere.Enabled = false;
            txtCNP.Enabled = false;
            txtActIdentitate.Enabled = false;
            txtObs.Enabled = false;

        }

        private void btnPrimul_Click(object sender, EventArgs e)
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

        private void activeazaCaseteText()
        {
            txtIdAngajat.Enabled = true;
            txtNumePrenAngajat.Enabled = true;
            txtAdresaAngajat.Enabled = true;
            txtTelefon.Enabled = true;
            txtFunctie.Enabled = true;
            txtDataAngajare.Enabled = true;
            txtDataNastere.Enabled = true;
            txtCNP.Enabled = true;
            txtActIdentitate.Enabled = true;
            txtObs.Enabled = true;
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            tipOperatiune = "adaugare";
            activeazaCaseteText();
            txtIdAngajat.Text = "";
            txtNumePrenAngajat.Text = "";
            txtAdresaAngajat.Text = "";
            txtTelefon.Text = "";
            txtFunctie.Text = "";
            txtDataAngajare.Text = "";
            txtDataNastere.Text = "";
            txtCNP.Text = "";
            txtActIdentitate.Text = "";
            txtObs.Text = "";
            txtIdAngajat.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false;
            DataNastere.Visible = true;
            DataAngajare.Visible = true;
            txtDataNastere.Visible = false;
            txtDataAngajare.Visible = false;
            tableLayoutPanel4.Visible = true;
            schimbaretext();

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

        private void btnStergere_Click(object sender, EventArgs e)
        {
            //incerc stergerea, dupa confirmarea de la utilizator 
            if (MessageBox.Show("Sigur stergi angajatul curent?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM angajati WHERE idAngajat=?";
                    comanda.Parameters.AddWithValue("idAngajat", txtIdAngajat.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Am sters Angajatul!");
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
            txtIdAngajat.Enabled = false;
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
            txtIdAngajat.Visible = true;
            DataAngajare.Visible = false;
            DataNastere.Visible = false;
            txtDataAngajare.Visible = true;
            txtDataNastere.Visible = true;
            tableLayoutPanel4.Visible = false;
            
        }
       /* private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        */
        
       // private void txtAdresaAngajat_GotFocus(object sender,EventArgs e)
        //{
          //  TextBox tb = (TextBox)sender;
           // tb.Text = string.Empty;
           // tb.GotFocus -= txtAdresaAngajat_GotFocus;
       // }
    
     
        private void schimbaretext()
        {
            txtAdresaAngajat.Text = "Exemplu: Strada, Numar, Localitate";
            //txtAdresaAngajat.Enabled=false;
            txtActIdentitate.Text = "Exemplu: IS000000";
            
        }

        private void txtAdresaAngajat_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdresaAngajat.Enabled = true;
            txtAdresaAngajat.Text = "";
            
        }

        private void txtAdresaAngajat_MouseLeave(object sender, EventArgs e)
        {
            if (txtAdresaAngajat.Text == "")
            {
                txtAdresaAngajat.Text = "Exemplu: Strada, Numar, Localitate";
            }
        }

        private void txtActIdentitate_MouseClick(object sender, MouseEventArgs e)
        {
            txtActIdentitate.Enabled = true;
            txtActIdentitate.Text = "";
        }

        private void txtActIdentitate_MouseLeave(object sender, EventArgs e)
        {
            if (txtActIdentitate.Text == "")
            {
                txtActIdentitate.Text = "Exemplu: IS000000";
            }
        }

        private void btnSalvare_Click_1(object sender, EventArgs e)
        {
            if (tipOperatiune == "adaugare")
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "INSERT INTO angajati VALUES (?,?,?,?,?,?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idAngajat", txtIdAngajat.Text.ToString());
                    comanda.Parameters.AddWithValue("NumePrenAngajat", txtNumePrenAngajat.Text.ToString());
                    comanda.Parameters.AddWithValue("AdresaAngajat", txtAdresaAngajat.Text.ToString());
                    comanda.Parameters.AddWithValue("Telefon", txtTelefon.Text.ToString());
                    comanda.Parameters.AddWithValue("Functie", cmbFunctie.Text.ToString());
                    comanda.Parameters.AddWithValue("DataAngajare", DataAngajare.Text.ToString());
                    comanda.Parameters.AddWithValue("DataNastere", DataNastere.Text.ToString());
                    comanda.Parameters.AddWithValue("CNP", txtCNP.Text.ToString());
                    comanda.Parameters.AddWithValue("ActIdentitate", txtActIdentitate.Text.ToString());
                    comanda.Parameters.AddWithValue("Observatii", txtObs.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Angajatul a fost adaugat in baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdAngajat.Visible = true;
                    btnModificare.Visible = true;
                    DataAngajare.Visible = true;
                    DataNastere.Visible = true;
                    txtDataAngajare.Visible = true;
                    txtDataNastere.Visible = true;
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
                    comanda.CommandText = "UPDATE angajati SET NumePrenAngajat=?,AdresaAngajat=?,Telefon=?,Functie=?,DataAngajare=?,DataNastere=?,CNP=?,ActIdentitate=?,Observatii=? WHERE idAngajat=?";
                    comanda.Parameters.AddWithValue("NumePrenAngajat", txtNumePrenAngajat.Text.ToString());
                    comanda.Parameters.AddWithValue("AdresaAngajat", txtAdresaAngajat.Text.ToString());
                    comanda.Parameters.AddWithValue("Telefon", txtTelefon.Text.ToString());
                    comanda.Parameters.AddWithValue("Functie", txtFunctie.Text.ToString());
                    comanda.Parameters.AddWithValue("DataAngajare", DataAngajare.Text.ToString());
                    comanda.Parameters.AddWithValue("DataNastere", DataNastere.Text.ToString());
                    comanda.Parameters.AddWithValue("CNP", txtCNP.Text.ToString());
                    comanda.Parameters.AddWithValue("ActIdentitate", txtActIdentitate.Text.ToString());
                    comanda.Parameters.AddWithValue("Observatii", txtObs.Text.ToString());
                    comanda.Parameters.AddWithValue("idAngajat", txtIdAngajat.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a angajat cu succes " + txtNumePrenAngajat.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    btnModificare.Visible = true;
                    tableLayoutPanel4.Visible = false;
                }
                catch (OdbcException eroare)
                {
                    MessageBox.Show("A aparut eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                }
            }
        }

       
    }
}


