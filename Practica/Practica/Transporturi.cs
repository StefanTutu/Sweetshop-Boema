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
    public partial class Transporturi : Form
    {
        public Transporturi()
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
                comanda.CommandText = "SELECT * FROM transporturi";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblTransporturi;
                tblTransporturi = new DataTable("Transporturi");
                tblTransporturi.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblTransporturi);
                nrTotalInregistrari = dsDate.Tables["Transporturi"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Transporturi = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
        private void PopuleazaSoferi()
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM Soferi ";
            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();
            DataTable tblSoferi;
            tblSoferi = new DataTable("Sof");
            tblSoferi.Load(cititor);
            dsDate.Tables.Add(tblSoferi);
            this.cmbIdSofer.DataSource = dsDate.Tables["Sof"];
            this.cmbIdSofer.DisplayMember = "idSofer";
            this.cmbIdSofer.ValueMember = "idSofer";
        }

        private void Transporturi_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            PopuleazaSoferi();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdTransport.Text = dsDate.Tables["Transporturi"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtDataPlecare.Text = dsDate.Tables["Transporturi"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtNrInmatr.Text = dsDate.Tables["Transporturi"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtDataSosire.Text = dsDate.Tables["Transporturi"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtIdSofer.Text = dsDate.Tables["Transporturi"].Rows[nrInregistrare].ItemArray[4].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdTransport.Enabled = false;
            txtDataPlecare.Enabled = false;
            txtNrInmatr.Enabled = false;
            txtDataSosire.Enabled = false;
            txtIdSofer.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdTransport.Enabled = true;
            txtDataPlecare.Enabled = true;
            txtNrInmatr.Enabled = true;
            txtDataSosire.Enabled = true;
            txtIdSofer.Enabled = true;
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
            txtIdTransport.Text = "";
            txtDataPlecare.Text = "";
            txtNrInmatr.Text = "";
            txtDataSosire.Text = "";
            txtIdSofer.Text = "";
            txtIdTransport.Focus();
            btnAdaugare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            btnStergere.Visible = false;
            dezactiveazaNavigare();
            btnModificare.Visible = false;
            tableLayoutPanel5.Visible = true;
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

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (tipOperatiune == "adaugare")
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "INSERT INTO transporturi VALUES (?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idTransport", txtIdTransport.Text.ToString());
                    comanda.Parameters.AddWithValue("DataPlecare", DataPlecare.Text.ToString());
                    comanda.Parameters.AddWithValue("NrInmatr", txtNrInmatr.Text.ToString());
                    comanda.Parameters.AddWithValue("DataSosire", DataSosire.Text.ToString());
                    comanda.Parameters.AddWithValue("idSofer", cmbIdSofer.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Transportul a fost adăugat cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdTransport.Visible = true;
                    btnModificare.Visible = true;
                    tableLayoutPanel4.Visible = false;
                    tableLayoutPanel5.Visible = false;
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
                    comanda.CommandText = "UPDATE transporturi SET DataPlecare=?,NrInmatr=?,DataSosire=?,idSofer=? WHERE idTransport=?";
                    comanda.Parameters.AddWithValue("DataPlecare", txtDataPlecare.Text.ToString());
                    comanda.Parameters.AddWithValue("NrInmatr", txtNrInmatr.Text.ToString());
                    comanda.Parameters.AddWithValue("DataSosire", txtDataSosire.Text.ToString());
                    comanda.Parameters.AddWithValue("idSofer", txtIdSofer.Text.ToString());
                    comanda.Parameters.AddWithValue("idTransp", txtIdTransport.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat transportul cu codul: " + txtIdTransport.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    btnModificare.Visible = true;
                    tableLayoutPanel5.Visible = false;
                    tableLayoutPanel4.Visible = false;
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
            if (MessageBox.Show("Sigur doriţi ştergerea transportului curent ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM transporturi WHERE idTransport=?";
                    comanda.Parameters.AddWithValue("idTransport", txtIdTransport.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters transportul !");
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
            txtIdSofer.Enabled = false;
            btnAdaugare.Visible = false;
            btnStergere.Visible = false;
            btnModificare.Visible = false;
            btnSalvare.Visible = true;
            btnAnulare.Visible = true;
            txtIdTransport.Enabled = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
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
            txtIdTransport.Visible = true;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel4.Visible = false;
        }
        private void schimbaretext()
        {
            txtNrInmatr.Text = "Exemplu: IS76ABC";
        }

        private void txtNrInmatr_MouseClick(object sender, MouseEventArgs e)
        {
            txtNrInmatr.Text = "";
        }

        private void txtNrInmatr_MouseLeave(object sender, EventArgs e)
        {
            if (txtNrInmatr.Text == "")
            {
                txtNrInmatr.Text = "Exemplu: IS76ABC";
            }
        }
    }
}
