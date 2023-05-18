using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyetoSP1
{
    public partial class frmBienvenida : Form
    {
        frmInicio inicio = new frmInicio();
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void cmdBienvenido_Click(object sender, EventArgs e)
        {
            inicio.Show();
            this.Hide();
        }
    }
}
