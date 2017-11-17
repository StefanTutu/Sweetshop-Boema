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
    public partial class MateriiPrime : Form
    {
        OdbcConnection conexiune; 
        DataSet dsDate; 
        int nrTotalInregistrari; 
        int indexInregistrareCurenta;
        string tipOperatiune;

        public MateriiPrime()
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
                comanda.CommandText = "SELECT * FROM materii_prime";
                //definesc cititor (reader) 
                OdbcDataReader cititor;
                cititor = comanda.ExecuteReader();
                DataTable tblMateriiPrime;
                tblMateriiPrime = new DataTable("Materii Prime");
                tblMateriiPrime.Load(cititor);
                dsDate = new DataSet();
                dsDate.Tables.Add(tblMateriiPrime);
                nrTotalInregistrari = dsDate.Tables["Materii Prime"].Rows.Count;
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
        private void PopuleazaMateriiPrime()
        {
            OdbcCommand comanda;
            comanda = new OdbcCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT * FROM materii_prime ORDER BY idMatPrima";
            OdbcDataReader cititor;
            cititor = comanda.ExecuteReader();
            DataTable tblMatPrime;
            tblMatPrime = new DataTable("Mat Prime");
            tblMatPrime.Load(cititor);
            dsDate.Tables.Add(tblMatPrime);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (indexInregistrareCurenta > 0)
                indexInregistrareCurenta--;
            afisareInregistrareCurenta(indexInregistrareCurenta);
        }

        private void MateriiPrime_Load(object sender, EventArgs e)
        {
            this.deschideConexiunea();
            this.afisareInregistrareCurenta(indexInregistrareCurenta);
            this.dezactiveazaCaseteText(); 
            btnSalvare.Visible = false; 
            btnAnulare.Visible = false;
        }
        private void afisareInregistrareCurenta(int nrInregistrare)
        {
            txtIdMateriePrima.Text = dsDate.Tables["Materii Prime"].Rows[nrInregistrare].ItemArray[0].ToString();
            txtDenumireMateriePrima.Text = dsDate.Tables["Materii Prime"].Rows[nrInregistrare].ItemArray[1].ToString();
            txtUMMateriePrima.Text = dsDate.Tables["Materii Prime"].Rows[nrInregistrare].ItemArray[2].ToString();
            txtPretUnitarMateriePrima.Text = dsDate.Tables["Materii Prime"].Rows[nrInregistrare].ItemArray[3].ToString();
        }
        private void dezactiveazaCaseteText()
        {
            txtIdMateriePrima.Enabled = false;
            txtDenumireMateriePrima.Enabled = false;
            txtUMMateriePrima.Enabled = false;
            txtPretUnitarMateriePrima.Enabled = false;
        }
        private void activeazaCaseteText()
        {
            txtIdMateriePrima.Enabled = true;
            txtDenumireMateriePrima.Enabled = true;
            txtUMMateriePrima.Enabled = true;
            txtPretUnitarMateriePrima.Enabled = true;
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
            txtIdMateriePrima.Text = "";    
            txtDenumireMateriePrima.Text= "";      
            txtUMMateriePrima.Text = "";
            txtPretUnitarMateriePrima.Text = "";
            txtIdMateriePrima.Focus();  
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
                    comanda.CommandText = "INSERT INTO materii_prime VALUES (?,?,?,?)";
                    comanda.Connection = conexiune;
                    comanda.Parameters.AddWithValue("idMatPrime", txtIdMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("DenMatPrima", txtDenumireMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("UM_MatPrima", txtUMMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("PretUnitMatPrima", txtPretUnitarMateriePrima.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("Materia prima a fost adaugata in baza de date !");
                    activeazaNavigare();
                    dezactiveazaCaseteText();
                    btnAdaugare.Visible = true;
                    btnSalvare.Visible = false;
                    btnAnulare.Visible = false;
                    btnStergere.Visible = true;
                    txtIdMateriePrima.Visible = true;
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
                    comanda.CommandText = "UPDATE materii_prime SET DenMatPrima=?,UM_MatPrima=?,PretUnitMatPrima=? WHERE idMatPrima=?";
                    comanda.Parameters.AddWithValue("DenMatPrima", txtDenumireMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("UM_MatPrima", txtUMMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("PretUnitMatPrima", txtPretUnitarMateriePrima.Text.ToString());
                    comanda.Parameters.AddWithValue("idMatPrime", txtIdMateriePrima.Text.ToString());
                    comanda.ExecuteNonQuery();
                    MessageBox.Show("S-a modificat materia prima cu codul "+ txtIdMateriePrima.Text.ToString());
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
            if (MessageBox.Show("Sigur stergi materia prima curenta?", "Decizie", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
            { 
                try     
                { 
                    OdbcCommand comanda = new OdbcCommand();  
                    comanda.CommandText = "DELETE FROM materii_prime WHERE idMatPrima=?";  
                    comanda.Parameters.AddWithValue("idMatPrima", txtIdMateriePrima.Text.ToString());   
                    comanda.Connection = conexiune;                   
                    comanda.ExecuteNonQuery(); 
                    MessageBox.Show("Am sters Materia Prima!");      
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
            txtIdMateriePrima.Enabled=false; 
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
            txtIdMateriePrima.Visible = true; 
        } 
    }
}
