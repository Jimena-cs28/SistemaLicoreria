using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using CryptSharp;

namespace DESIGNER
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string nombreUsuario = txtcorreo.Text;
            string contraseña = txtpassword.Text;

            dt = usuario.iniciarSesion(nombreUsuario);

            if(dt.Rows.Count > 0)
            {
                string claveEncriptada = dt.Rows[0][3].ToString();
                bool login = Crypter.CheckPassword(contraseña, claveEncriptada);

                if (login)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("No existe el usuario" + " " + nombreUsuario);
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            DataTable resultado = new DataTable();
            string Nombreusuario = txtcorreo.Text;
            string Claveacceso = txtpassword.Text;

            resultado = usuario.iniciarSesion(Nombreusuario);

            if (resultado.Rows.Count > 0)
            {
                string claveEncriptada = resultado.Rows[0][3].ToString();
                bool login = Crypter.CheckPassword(Claveacceso, claveEncriptada);
            }
            else
            {
                MessageBox.Show("No existe el usuario" + " " + Nombreusuario);
            }
        }

    }
}
