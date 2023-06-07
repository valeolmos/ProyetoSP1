using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyetoSP1
{


    public partial class frmInicio : Form
    {
        int intentos = 0;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 10;
            txtUsuario.ForeColor = Color.Blue;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 10;
            txtContraseña.PasswordChar = '#';
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContraseña.Text;
            string modulo = cboxMódulo.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(modulo))
            {

                if ((usuario == "Admin" && contrasenia == "@1a" && (modulo == "ADM" || modulo == "VTA" || modulo == "COM")) ||
                    (usuario == "Jhon" && contrasenia == "*2b" && (modulo == "SIST")) ||
                    (usuario == "Ceci" && contrasenia == "@3c" && (modulo == "ADM" || modulo == "VTA")) ||
                    (usuario == "God" && contrasenia == "@#4d" && (modulo == "ADM" || modulo == "VTA" || modulo == "COM" || modulo == "SIST")))
                {
                    MessageBox.Show("Bienvenido");
                    frmBienvenida f = new frmBienvenida();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                    intentos++;
                    if (intentos == 3)
                    {
                        this.Close();
                    }
                }

            }


        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}