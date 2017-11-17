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
    public partial class Livrari : Form
    {
        public Livrari()
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
                comanda.CommandText = "SELECT * FROM livrari";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblLivrari;
                tblLivrari = new DataTable("Livrari");
                tblLivrari.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblLivrari);
                nrTotalInregistrari = dsDate.Tables["Livrari"].Rows.Count;
                this.indexInregistrareCurenta = 0;
                //MessageBox.Show("Numar Livrari = " + nrTotalInregistrari);
            }
            catch (OdbcException eroare)
            {
                MessageBox.Show("A aparut Eroarea nr. " + eroare.ErrorCode.ToString() + " cu mesajul " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
   
        private void Livrari_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText();
            btnSalvare.Visible = false;
            btnAnulare.Visible = false;
            tableLayoutPanel4.Visible = false;
            populeazaIdTransport();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdLivrare.Text = dsDate.Tables["Livrari"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtLocLivrare.Text = dsDate.Tables["Livrari"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtJudLivrare.Text = dsDate.Tables["Livrari"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtDataLivrare.Text = dsDate.Tables["Livrari"].Rows[nrInregistrare].ItemArray[3].ToString();
            txtIdTransport.Text = dsDate.Tables["Livrari"].Rows[nrInregistrare].ItemArray[4].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdLivrare.Enabled = false;
            txtLocLivrare.Enabled = false;
            txtJudLivrare.Enabled = false;
            txtDataLivrare.Enabled = false;
            txtIdTransport.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdLivrare.Enabled = true;
            txtLocLivrare.Enabled = true;
            txtJudLivrare.Enabled = true;
            txtDataLivrare.Enabled = true;
            txtIdTransport.Enabled = true;
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
            txtIdLivrare.Text = "";
            txtLocLivrare.Text = "";
            txtJudLivrare.Text = "";
            txtDataLivrare.Text = "";
            txtIdTransport.Text = "";
            txtIdLivrare.Focus();
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
                    comanda.CommandText = "INSERT INTO livrari VALUES (?,?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idLivrare", txtIdLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("LocLivrare", txtLocLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("JudLivrare", txtJudLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("DataLivrare", DataLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("idTransport", cmbIdTransport.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Livrarea a fost adăugată cu succes în baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdLivrare.Visible = true;
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
                    comanda.CommandText = "UPDATE livrari SET LocLivrare=?,JudLivrare=?,DataLivrare=?,idTransport=? WHERE idLivrare=?";
                    comanda.Parameters.AddWithValue("LocLivrare", txtLocLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("JudLivrare", txtJudLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("DataLivrare", txtDataLivrare.Text.ToString());
                    comanda.Parameters.AddWithValue("idTransport", txtIdTransport.Text.ToString());
                    comanda.Parameters.AddWithValue("idLivrare", txtIdLivrare.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat transportul cu codul: " + txtIdLivrare.Text.ToString());
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    btnModificare.Visible = true;
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
            if (MessageBox.Show("Sigur doriţi ştergerea livrării curente ?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    OdbcCommand comanda = new OdbcCommand();
                    comanda.CommandText = "DELETE FROM livrari WHERE idLivrare=?";
                    comanda.Parameters.AddWithValue("idLivrare", txtIdLivrare.Text.ToString());
                    comanda.Connection = conexiune;
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a şters livrarea !");
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
            txtIdLivrare.Enabled = false;
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
            txtIdLivrare.Visible = true;
            tableLayoutPanel4.Visible = false;
        }

        private void populeazaIdTransport()
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
            comanda.CommandText = "select * from transporturi ";
            comanda.Connection = conexiune;

            dsDate = new DataSet();
            cititor = comanda.ExecuteReader();
            tblTransporturi= new DataTable("Transporturi");
            tblTransporturi.Load(cititor);
            dsDate.Tables.Add(tblTransporturi);
            this.cmbIdTransport.DataSource = dsDate.Tables["Transporturi"];
            this.cmbIdTransport.DisplayMember = "idTransport";
            this.cmbIdTransport.ValueMember = "idTransport";
            conexiune.Close();
        }

        private void cmbIdTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
