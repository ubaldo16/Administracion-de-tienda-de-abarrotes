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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            habilitarAltas();
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deshabilitarAltas();
            dataGridView1.Visible = true;
            generateTable();
            buttonEliminarProd.Visible = true;
        }

        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deshabilitarAltas();
            dataGridView1.Visible = true;
            generateTable();
            buttonModificarProd.Visible = true;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deshabilitarAltas();
            dataGridView1.Visible = true;
            generateTable();
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            WorkedRegister();
        }

        private void buttonModificarProd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarProd_Click(object sender, EventArgs e)
        {
            DialogResult respuesta; //Guarda la accion del messageBox.

            //Manda mensaje si está seguro de eliminar registro.
            respuesta = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {

                try
                {
                    using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

                    {
                        conexion.Open();
                        string SqlActions = "DELETE * FROM  Inventario WHERE Id_inventario = @parametro";
                        OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
                        cmd.Parameters.AddWithValue("@parametro", dataGridView1.CurrentRow.Cells["Id_inventario"].Value);
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                        //MessageBox.Show("Producto Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                generateTable();
            }
        }

        private void generateTable()
        {
            try
            {

                DataTable results = new DataTable();
                using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))
                {
                    OleDbCommand cmd = new OleDbCommand(@"Select * from Inventario", conexion);
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

        void limpiarAltas()
        {
            textCantidad.Text = "";
            cBPerecedero.Text = "";
            textPrecio.Text = "";
            textProducto.Text = "";
            textProveedor.Text = "";
            monthCalendar1.Update();
        }

        void habilitarAltas()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            textProducto.Visible = true;
            textCantidad.Visible = true;
            monthCalendar1.Visible = true;
            textPrecio.Visible = true;
            cBPerecedero.Visible = true;
            textProveedor.Visible = true;

            pictureBox1.Visible = true;

            btn_agregarProducto.Visible = true;
            buttonEliminarProd.Visible = false;
        }

        void deshabilitarAltas()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            textProducto.Visible = false;
            textCantidad.Visible = false;
            monthCalendar1.Visible = false;
            textPrecio.Visible = false;
            cBPerecedero.Visible = false;
            textProveedor.Visible = false;

            pictureBox1.Visible = false;

            btn_agregarProducto.Visible = false;
            buttonEliminarProd.Visible = false;
            buttonModificarProd.Visible = false;
        }

        private void WorkedRegister()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                cmd.Connection = conexion;
                conexion.Open();
                string insertar = "INSERT INTO Inventario(Id_Proveedor,Nombre,Cantidad,Caducidad,Precio,Perecedero) VALUES ( '" + textProveedor.Text + "', '" + textProducto.Text + "', '" + Int32.Parse(textCantidad.Text) + "' ,'" + monthCalendar1.SelectionEnd.ToShortDateString() + "', '" + Int32.Parse(textPrecio.Text) + "', '" + cBPerecedero.SelectedIndex + "')";
                cmd.CommandText = @insertar;
                cmd.ExecuteNonQuery();
                limpiarAltas();
                MessageBox.Show("Producto guardado", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(""+monthCalendar1.SelectionEnd.ToShortDateString());
                conexion.Close();

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
