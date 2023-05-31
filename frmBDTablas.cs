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
    public partial class frmBDTablas : Form
    {
        public frmBDTablas()
        {
            InitializeComponent();
        }

        public string Conexion;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDatos BDatos = new clsBaseDatos();
            BDatos.MostrarTablas(cmbTabla, Conexion, dgvTabla);
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            clsBaseDatos BDatos = new clsBaseDatos();
            Conexion = BDatos.ListarTablas(cmbTabla, dgvTabla, txtBDNombre);
            if (Conexion != "")
            {
                lblBaseDatos.Enabled = true;
                lblTabla.Enabled = true;
                cmbTabla.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltrar filtrar = new frmFiltrar();
            this.Hide();
            filtrar.ShowDialog();
            this.Close();
        }
    }
}
