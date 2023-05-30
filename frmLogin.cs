using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_NeptunoBD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "nico" && txtContraseña.Text == "nico")
            {
                frmLogin frm = new frmLogin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, revise su Usuario/Contrasenia", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
