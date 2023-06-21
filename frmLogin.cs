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
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {
                frmBDTablas BDTablas = new frmBDTablas();
                this.Hide();
                BDTablas.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos, revise su Usuario o Contrasenia", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
