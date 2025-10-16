using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modbus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string adresseIP = textBoxAdresseIP.Text;

            textBoxStatut.Text += $"Connexion au serveur {adresseIP}\r\n";

            textBoxStatut.SelectionStart = textBoxStatut.Text.Length;
            textBoxStatut.ScrollToCaret();
        }
    }
}
