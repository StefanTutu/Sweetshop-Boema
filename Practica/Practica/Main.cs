using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Main : RibbonForm
    {
        string x;
        int z;
        public int c;
        bool CursorPeRibbon = false;
        string user;

       public Main(int incoming, int cod)
        {
            InitializeComponent();
            z = incoming;
            c = cod;
            this.MouseWheel += new MouseEventHandler(ribbon_MouseWheel);
        }
      
        private void Restrictii_Contabil()
        {
            TabProduse.Visible = false;
            TabLivrari.Visible = false;
            TabAngajati.Visible = false;
            btnRaportComenziFiltrate.Visible = false;
            btnRaportCostTotalProductie.Visible = false;
            btnRaportComenziProductie.Visible = false;
        }


        private void Restrictii_Manager()
        {
            btnRaportBonuriFiscale.Visible = false;
            btnRaportTotalIncasari.Visible = false;
            TabIncasari.Visible = false;
        }

        public void ribbon_MouseWheel(object sender, MouseEventArgs e)
        {
            if (CursorPeRibbon == true)
            {
                if (e.Delta < 0)
                {
                    ribbon1.ActivateNextTab();
                }
                else
                {
                    ribbon1.ActivatePreviousTab();
                }
            }
        }

        private void btnInchideAplicatia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            Produse frm = new Produse();
            frm.ShowDialog();
        }

        private void btnProduseComenzi_Click(object sender, EventArgs e)
        {
            ProduseComenzi frm = new ProduseComenzi();
            frm.ShowDialog();
        }

        private void btnRaportProduse_Click(object sender, EventArgs e)
        {
            RaportProduse frm = new RaportProduse();
            frm.ShowDialog();
        }

        private void btnMateriiPrime_Click(object sender, EventArgs e)
        {
            MateriiPrime frm = new MateriiPrime();
            frm.ShowDialog();
        }

        private void btnMateriiPrimeProduse_Click(object sender, EventArgs e)
        {
            MateriiPrime_Produse frm = new MateriiPrime_Produse();
            frm.ShowDialog();
        }

        private void btnRaportMateriiPrime_Click(object sender, EventArgs e)
        {
            RaportMateriiPrime frm = new RaportMateriiPrime();
            frm.ShowDialog();
        }

        private void btnComenziProductie_Click(object sender, EventArgs e)
        {
            ComenziProductie frm = new ComenziProductie();
            frm.ShowDialog();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            Clienti frm = new Clienti();
            frm.ShowDialog();
        }

        private void btnClientiIncasari_Click(object sender, EventArgs e)
        {
            ClientiIncasari frm = new ClientiIncasari();
            frm.ShowDialog();
        }

        private void btnRaportClienti_Click(object sender, EventArgs e)
        {
            RaportClient frm = new RaportClient();
            frm.ShowDialog();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            Comenzi frm = new Comenzi();
            frm.ShowDialog();
        }

        private void btnClinetiComenzi_Click(object sender, EventArgs e)
        {
            LivrariComenzi frm = new LivrariComenzi();
            frm.ShowDialog();
        }

        private void btnRaportComenzi_Click(object sender, EventArgs e)
        {
            RaportComenzi frm = new RaportComenzi();
            frm.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Discount frm = new Discount();
            frm.ShowDialog();
        }

        private void btnSoferi_Click(object sender, EventArgs e)
        {
            Soferi frm = new Soferi();
            frm.ShowDialog();
        }

        private void btnRaportSoferi_Click(object sender, EventArgs e)
        {
            RaportSoferi frm = new RaportSoferi();
            frm.ShowDialog();
        }

        private void btnLivrari_Click(object sender, EventArgs e)
        {
            Livrari frm = new Livrari();
            frm.ShowDialog();
        }

        private void btnLivrariTransporturi_Click(object sender, EventArgs e)
        {
            LivrariTransporturi frm = new LivrariTransporturi();
            frm.ShowDialog();
        }

        private void btnRaportLivrari_Click(object sender, EventArgs e)
        {
            RaportLivrari frm = new RaportLivrari();
            frm.ShowDialog();
        }

        private void btnTransporturi_Click(object sender, EventArgs e)
        {
            Transporturi frm = new Transporturi();
            frm.ShowDialog();
        }

        private void btnRaportTranspoturi_Click(object sender, EventArgs e)
        {
            RaportTransporturi frm = new RaportTransporturi();
            frm.ShowDialog();
        }

        private void btnRetururi_Click(object sender, EventArgs e)
        {
            Retururi frm = new Retururi();
            frm.ShowDialog();
        }

        private void btnBonuriFiscale_Click(object sender, EventArgs e)
        {
            BonuriFiscale frm = new BonuriFiscale();
            frm.ShowDialog();
        }

        private void btnRaportBonFiscal_Click(object sender, EventArgs e)
        {
            RaportBonuriFiscale frm = new RaportBonuriFiscale();
            frm.ShowDialog();
        }

        private void btnIncasari_Click(object sender, EventArgs e)
        {
            Incasari frm = new Incasari();
            frm.ShowDialog();
        }

        private void btnVanzariProprii_Click(object sender, EventArgs e)
        {
            VanzariProprii_Incasari frm = new VanzariProprii_Incasari();
            frm.ShowDialog();
        }

        private void btnAngajati_Click(object sender, EventArgs e)
        {
            Angajati frm = new Angajati();
            frm.ShowDialog();
        }

        private void btnRaportAngajati_Click(object sender, EventArgs e)
        {
            RaportAngajati frm = new RaportAngajati();
            frm.ShowDialog();
        }

        private void btnDespre_Click(object sender, EventArgs e)
        {
            new Despre().ShowDialog();
        }

        private void ribbon1_MouseEnter(object sender, EventArgs e)
        {
            CursorPeRibbon = true;
        }

        private void ribbon1_MouseLeave(object sender, EventArgs e)
        {
            CursorPeRibbon = false;
        }

        private void BtnRaportSalariiAngajati_Click(object sender, EventArgs e)
        {
            RaportSalariiAngajati frm = new RaportSalariiAngajati();
            frm.ShowDialog();
        }

        private void btnRaportComenziFiltrate_Click(object sender, EventArgs e)
        {
            RaportLocalitatiLivrare frm = new RaportLocalitatiLivrare();
            frm.ShowDialog();
        }

        private void btnRaportBonuriFiscale_Click(object sender, EventArgs e)
        {
            RaportDiscountComenzi frm = new RaportDiscountComenzi();
            frm.ShowDialog();
        }

        private void btnRaportCostTotalProductie_Click(object sender, EventArgs e)
        {
            RaportCostProductie frm = new RaportCostProductie();
            frm.ShowDialog();
        }

        private void btnRaportComenziProductie_Click(object sender, EventArgs e)
        {
            RaportComenziProductie frm = new RaportComenziProductie();
            frm.ShowDialog();
        }

        private void btnRaportTotalIncasari_Click(object sender, EventArgs e)
        {
            RaportIncasariClienti frm = new RaportIncasariClienti();
            frm.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ribbon1.OrbDropDown.Visible = true;

            if (z == 2)
            {
                Restrictii_Contabil();
                user = c.ToString();
            }
            if (z == 1)
            {
                Restrictii_Manager();
                user = c.ToString();
            }
            if (c == 0)
            {
                user = "admin";
            }
        }

        private void Main_FormClosed_1(object sender, FormClosedEventArgs e)
        {
             if (x == "1")
           {
               Application.Exit();
           }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
         x = Sure.ShowBox();

           if (x == "2")
           {
               e.Cancel = true;
           }
        }
    }    
}
