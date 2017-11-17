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
    public partial class FlashAnimation : Form
    {
        public FlashAnimation()
        {
            InitializeComponent();
        }

        private void FlashAnimation_Load(object sender, EventArgs e)
        {
           chartFlashPlayer.LoadMovie(0, "D:\\Practica 2015\\Final\\Practica\\Practica\\Resources\\splash.swf");
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
