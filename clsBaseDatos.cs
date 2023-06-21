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

        public void ListarClientes(DataGridView dgvClientes, string BaseDeDatos, string Tabla)
        {
            coneBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvClientes.Rows.Clear();
            try
            {
                commBD.Connection = coneBD;
                commBD.CommandText = Tabla;
                commBD.CommandType = CommandType.TableDirect;
                commBD.Connection.Open();

                lectorBD = commBD.ExecuteReader();

                while (lectorBD.Read())
                {
                    dgvClientes.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], lectorBD[8], lectorBD[9], lectorBD[10]);
                }

                commBD.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarPais(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbPais, ComboBox cmbCiudad)
        {
            if (cmbPais.SelectedIndex != -1)
            {
                coneBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvClientes.Rows.Clear();
                cmbCiudad.SelectedIndex = -1;
                try
                {
                    commBD.Connection = coneBD;
                    commBD.CommandText = Tabla;
                    commBD.CommandType = CommandType.TableDirect;
                    commBD.Connection.Open();

                    lectorBD = commBD.ExecuteReader();

                    while (lectorBD.Read())
                    {
                        if (lectorBD[8].ToString() == cmbPais.Text)
                        {
                            dgvClientes.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], lectorBD[8], lectorBD[9], lectorBD[10]);
                        }
                    }
                    commBD.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void ListarCiudad(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbCiudad, ComboBox cmbPais)
        {
            if (cmbCiudad.SelectedIndex != -1)
            {
                coneBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvClientes.Rows.Clear();
                cmbPais.SelectedIndex = -1;
                try
                {
                    commBD.Connection = coneBD;
                    commBD.CommandText = Tabla;
                    commBD.CommandType = CommandType.TableDirect;
                    commBD.Connection.Open();

                    lectorBD = commBD.ExecuteReader();

                    while (lectorBD.Read())
                    {
                        if (lectorBD[5].ToString() == cmbCiudad.Text)
                        {
                            dgvClientes.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6], lectorBD[7], lectorBD[8], lectorBD[9], lectorBD[10]);
                        }
                    }
                    commBD.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void CargarPaisCiudad(ComboBox cmbCiudad, ComboBox cmbPais, string BaseDeDatos, string Tabla)
        {
            coneBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            bool encontradoCiudad = false;
            bool encontradoPais = false;
            try
            {
                commBD.Connection = coneBD;
                commBD.CommandText = Tabla;
                commBD.CommandType = CommandType.TableDirect;
                commBD.Connection.Open();

                lectorBD = commBD.ExecuteReader();

                while (lectorBD.Read())
                {
                    for (int i = 0; i < cmbCiudad.Items.Count; i++)
                    {
                        if (lectorBD[5].ToString() == cmbCiudad.Items[i].ToString())
                        {
                            encontradoCiudad = true;
                        }
                    }
                    if (encontradoCiudad == false)
                    {
                        cmbCiudad.Items.Add(lectorBD[5]);
                    }
                    encontradoCiudad = false;

                    for (int i = 0; i < cmbPais.Items.Count; i++)
                    {
                        if (lectorBD[8].ToString() == cmbPais.Items[i].ToString())
                        {
                            encontradoPais = true;
                        }
                    }
                    if (encontradoPais == false)
                    {
                        cmbPais.Items.Add(lectorBD[8]);
                    }
                    encontradoPais = false;
                }
                commBD.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}

