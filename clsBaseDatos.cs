using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_NeptunoBD
{
    internal class clsBaseDatos
    {
        public OleDbCommand commBD = new OleDbCommand();
        public OleDbDataReader lectorBD;
        public OleDbConnection coneBD = new OleDbConnection();

        public string ListarTablas(ComboBox cmbTablas, DataGridView dgvTablas, TextBox txtBDNombre)
        {
            dgvTablas.DataSource = null;
            cmbTablas.SelectedIndex = -1;
            string cadenaConexion = "";
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string archivo = OpenFileDialog.FileName;
                    txtBDNombre.Text = Path.GetFileName(archivo);

                    if (Path.GetExtension(archivo) == ".accdb")
                    {
                        cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + archivo + ";Persist Security Info=False;";
                    }
                    else
                    {
                        cadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + archivo + ";";
                    }

                    coneBD.ConnectionString = cadenaConexion;

                    cmbTablas.Items.Clear();

                    try
                    {
                        coneBD.Open();

                        DataTable tablas = coneBD.GetSchema("Tables");

                        foreach (DataRow tabla in tablas.Rows)
                        {
                            if (tabla[3].ToString() == "TABLE")
                            {
                                cmbTablas.Items.Add(tabla[2].ToString());
                            }
                        }
                        coneBD.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            return cadenaConexion;
        }

        public void MostrarTablas(ComboBox cmbTablas, string cadenaConexion, DataGridView dgvTablas)
        {
            if (cmbTablas.SelectedIndex != -1)
            {
                coneBD.ConnectionString = cadenaConexion;

                try
                {
                    commBD.Connection = coneBD;
                    commBD.CommandText = cmbTablas.Text;
                    commBD.CommandType = CommandType.TableDirect;
                    commBD.Connection.Open();

                    lectorBD = commBD.ExecuteReader();

                    DataTable tabla = new DataTable();
                    tabla.Load(lectorBD);

                    dgvTablas.DataSource = tabla;

                    commBD.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}

