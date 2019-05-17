using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaDeCobro
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sDCDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.sDCDataSet.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'sDCDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sDCDataSet.Inventario);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarProd_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(Properties.Settings.Default.ConexionDB))
            // using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
            {
                try
                {
                    con.Open();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor
                    OleDbCommand query = con.CreateCommand();


                //Especifiamos la query a ejecutar
                query.CommandText = string.Format("INSERT INTO Tabla(id,Nombre,Cantidad,Caducidad,Precio,Perecedero) VALUES ({0},{1},{2},{3},{4},{5})", dataGridView2.Rows[0].Cells[0], dataGridView2.Rows[0].Cells[1], dataGridView2.Rows[0].Cells[2], dataGridView2.Rows[0].Cells[3], dataGridView2.Rows[0].Cells[4], dataGridView2.Rows[0].Cells[5]);

                //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                //devuelve el número de filas afectadas
                int fil = query.ExecuteNonQuery();

                if (fil > 0)
                {
                        MessageBox.Show("Todo ha ido bien");
                }
                else
                {
                        MessageBox.Show("No se ha ejecutado correctamente");
                }
            }
                catch
            {
                //Aqui recibimos las posibles excepciones
            }
            finally
            {
                //Nos aseguramos de cerrar la conexión
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(Properties.Settings.Default.ConexionDB))
            // using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
            {
                try
                {
                    con.Open();
                    //Creamos el comando que contendrá la query a ejecutar en el servidor
                    OleDbCommand query = new OleDbCommand(string.Format("INSERT INTO Inventario(id,Nombre,Cantidad,Caducidad,Precio,Perecedero) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", dataGridView2.Rows[0].Cells[0], dataGridView2.Rows[0].Cells[1], dataGridView2.Rows[0].Cells[2], dataGridView2.Rows[0].Cells[3], dataGridView2.Rows[0].Cells[4], dataGridView2.Rows[0].Cells[5]), con);


                    //Especifiamos la query a ejecutar
                  //  query.CommandText = string.Format("INSERT INTO Inventario(id,Nombre,Cantidad,Caducidad,Precio,Perecedero) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", dataGridView2.Rows[0].Cells[0], dataGridView2.Rows[0].Cells[1], dataGridView2.Rows[0].Cells[2], dataGridView2.Rows[0].Cells[3], dataGridView2.Rows[0].Cells[4], dataGridView2.Rows[0].Cells[5],con);

                    //Como es un INSERT, la query no devuelve resultados, asi que ejecutamos un ExecuteNonQuery que nos
                    //devuelve el número de filas afectadas
                    int fil = query.ExecuteNonQuery();

                    if (fil > 0)
                    {
                        MessageBox.Show("Todo ha ido bien");
                    }
                    else
                    {
                        MessageBox.Show("No se ha ejecutado correctamente");
                    }
                }
                catch
                {
                    //Aqui recibimos las posibles excepciones
                }
                finally
                {
                    //Nos aseguramos de cerrar la conexión
                    if (con.State != System.Data.ConnectionState.Closed)
                        con.Close();
                }
            }
        }
    }
}
