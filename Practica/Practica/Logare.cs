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
    public partial class Logare : Form
    {
        int x;
        int y;
        bool check1 = false;
        bool check2 = false;
        OdbcConnection conexiune = new OdbcConnection("Driver={PostgreSQL ANSI};database=Cofetarie;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;socket=4096;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;optimizer=0;ksqo=1;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;cancelasfreestmt=0;extrasystableprefixes=dd_;lfconversion=1;updatablecursors=1;disallowpremature=0;trueisminus1=0;bi=0;byteaaslongvarbinary=0;useserversideprepare=0;lowercaseidentifier=0;gssauthusegss=0;xaopt=1;pwd=steaua10");

        public Logare()
        {
            InitializeComponent();
            
        }

        private void Logare_Load(object sender, EventArgs e)
        {
            FlashAnimation animatieForm = new FlashAnimation();
            this.Hide();
            animatieForm.ShowDialog();
            this.Show();
        }
        private void Executa()
        {
            if (txtUsername.Text == "")
            {
                check1 = false;
                MessageBox.Show("Trebuie sa introduceti un nume de utilizator!");
            }
            else
            {
                check1 = true;
            }
            if (txtParola.Text == "")
            {
                check2 = false;
                MessageBox.Show("Trebuie sa introduceti o parola!");
            }
            else
            {
                check2 = true;
            }
            if (check1 == true && check2 == true)
            {
                if (txtUsername.Text == "admin" && txtParola.Text == "parola")
                {
                    x = -1;
                    Main newform = new Main(x, 0);
                    Hide();
                    newform.Show();
                }
                else
                {
                    if (txtUsername.Text == "contabil" && txtParola.Text == "contabil")
                    {
                        x = 2;
                        y = 0;
                        Main newform = new Main(x, y);
                        Hide();
                        newform.Show();
                    }

                    else
                    {
                        if (txtUsername.Text == "manager" && txtParola.Text == "manager")
                        {
                            x = 1;
                            y = 0;
                            Main newform = new Main(x, y);
                            Hide();
                            newform.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nume de utilizator sau parola gresita!");
                        }
                    }
                    }
                }
            
            if (x == 0)
            {
                MessageBox.Show("Nume de utilizator sau parola gresita!");
            }
        }
       

        private void btnLogare_Click(object sender, EventArgs e)
        {
            Executa();
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Executa();
            }  
        }
    }
}
