using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;

namespace DESIGNER.Encriptar
{
    public partial class Encriptado : Form
    {
        public Encriptado()
        {
            InitializeComponent();
        }

        private void btnencriptar_Click(object sender, EventArgs e)
        {
            string claveoriginal = txtoriginal.Text;
            string claveencriptada = Crypter.Blowfish.Crypt(claveoriginal);
            txtencriptada.Text = claveencriptada;
        }

    }
}
