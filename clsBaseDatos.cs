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
            string Conexion = "";
            using (OpenFileDialog File = new OpenFileDialog())
            {
                if (File.ShowDialog() == DialogResult.OK)
                {
                    string archivo = File.FileName;
                    txtBDNombre.Text = Path.GetFileName(archivo);

                    if (Path.GetExtension(archivo) == ".accdb")
                    {
                        Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + archivo + ";Persist Security Info=False;";
                    }
                    else
                    {
                        Conexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source =" + archivo + ";";
                    }

                    coneBD.ConnectionString = Conexion;

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
            return Conexion;
        }

        public void MostrarTablas(ComboBox cmbTablas, string Conexion, DataGridView dgvTablas)
        {
            if (cmbTablas.SelectedIndex != -1)
            {
                coneBD.ConnectionString = Conexion;

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

