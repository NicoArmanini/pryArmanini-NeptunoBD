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
    public partial class frmFiltrar : Form
    {
        public frmFiltrar()
        {
            InitializeComponent();
        }

        private void frmFiltrar_Load(object sender, EventArgs e)
        {
            clsBaseDatos objPaisCiudad = new clsBaseDatos();
            objPaisCiudad.CargarPais(cmbCiudad, cmbPais, "NEPTUNO", "Clientes");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objClientes= new clsBaseDatos();
            objClientes.ListarClientes(dgvClientes, "NEPTUNO", "Clientes");
            mrcFiltros.Enabled = true;
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDatos objPais = new clsBaseDatos();
            objPais.ListarPais(dgvClientes, "NEPTUNO", "Clientes", cmbPais, cmbCiudad);
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDatos objCiudad= new clsBaseDatos();
            objCiudad.ListarCiudad(dgvClientes, "NEPTUNO", "Clientes", cmbCiudad);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmBDTablas menu = new frmBDTablas();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
