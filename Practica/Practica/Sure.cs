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
    public partial class Sure : Form
    {
        static Sure newMessageBox;
        static string Button_id; 

        public Sure()
        {
            InitializeComponent();
        }

        public static string ShowBox()
        {
            newMessageBox = new Sure();
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
            Button_id = "2";
        }
    }
}
