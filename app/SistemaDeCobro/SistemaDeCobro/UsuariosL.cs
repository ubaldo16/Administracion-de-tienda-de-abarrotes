using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCobro
{
    public partial class UsuariosL : Form
    {
        public UsuariosL()
        {
            InitializeComponent();
        }

        private void UsuariosL_Load(object sender, EventArgs e)
        {
            generateTable();
        }

        private void generateTable()
        {
            try
            {

                DataTable results = new DataTable();
                using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))
                {
                    OleDbCommand cmd = new OleDbCommand(@"Select * from Empleado", conexion);
                    conexion.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(results);
                    conexion.Close();
                }

                //Solo si tienes las columnas creadas en tiempo de Diseño, descomentarizas la siguiente linea
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = results;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButDelete_Click(object sender, EventArgs e)
        {
            try

             {
                using(OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

                {
                    conexion.Open();
                   string SqlActions = "DELETE * FROM  Empleado WHERE RFC = @parametro";
                    OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
                    cmd.Parameters.AddWithValue("@parametro", dataGridView1.CurrentRow.Cells["RFC"].Value);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Registro Eliminado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            generateTable();
        }
    }
}
