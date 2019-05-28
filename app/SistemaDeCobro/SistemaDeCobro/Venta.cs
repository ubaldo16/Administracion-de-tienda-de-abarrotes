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
    public partial class Venta : Form
    {
        double Total;
        double sub_prod;
        Usuario usu;
        //private Usuario usu;
        public Venta(Usuario u)
        {

            usu = u;
            Total = 0;
            sub_prod = 0;

            InitializeComponent();
            inserta_dat_ventas();
            inserta_dat_detall();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sDCDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.sDCDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'sDCDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sDCDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sDCDataSet.Detalle_venta' Puede moverla o quitarla según sea necesario.
            this.detalle_ventaTableAdapter.Fill(this.sDCDataSet.Detalle_venta);

        }

        private void inserta_dat_detall()
        {
            try
            {

                DataTable results = new DataTable();
                using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))
                {
                    OleDbCommand cmd = new OleDbCommand(@"Select * from Detalle_venta", conexion);
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
        private void inserta_dat_Tabla()
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
                tabla_uso.AutoGenerateColumns = true;
                tabla_uso.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inserta_dat_ventas()
        {
            try
            {

                DataTable results = new DataTable();
                using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))
                {
                    OleDbCommand cmd = new OleDbCommand(@"Select * from Venta", conexion);
                    conexion.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    adapter.Fill(results);
                    conexion.Close();
                }

                //Solo si tienes las columnas creadas en tiempo de Diseño, descomentarizas la siguiente linea
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void limpiarBoxes()
        {
            Cantidad.Text = "";
            Precio.Text = "";
            Nombre.Text = "";
            Id_producto.Text = "";
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

            if (Cantidad.Text == "") { }
            else
            {
                sub_prod = (Int32.Parse(Cantidad.Text) * Convert.ToDouble(Precio.Text));
                
                Subtotal_box.Text = Convert.ToString(sub_prod);
               
            }
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            int idven;
            Total = sub_prod + Total;
            total_box.Text = Convert.ToString(Total);
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                cmd.Connection = conexion;
                conexion.Open();
                if (dataGridView2.RowCount > -1)
                {
                    
                    idven = dataGridView2.RowCount ;
                  //  MessageBox.Show("%d", Convert.ToString(idven));
                    Id_venta_tex.Text = Convert.ToString(idven);
                }
                else
                {
                    idven = 1;
                    Id_venta_tex.Text = Convert.ToString(idven);
                }
                string insertar = "INSERT INTO Detalle_venta(Id_DetalleVenta,Cantidad,Subtotal,Inventario_Id) VALUES ( '" + idven + "','" + Convert.ToDouble(Cantidad.Text) + "', '" + Convert.ToDouble(Subtotal_box.Text) + "', '" + Int32.Parse(Id_producto.Text) + "')";
                cmd.CommandText = @insertar;
                cmd.ExecuteNonQuery();
                limpiarBoxes();
                MessageBox.Show("Producto agregado", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            inserta_dat_detall();

        }

        private void Id_producto_TextChanged(object sender, EventArgs e)
        {
            int band = 0;
            int x;
            ID_emp_tex.Text = usu.Nombre;
            inserta_dat_Tabla();
            if (Id_producto.Text == "")
            {

            }
            else
            {
                for (x = 0; x < tabla_uso.RowCount;x++)
                {
                    if (Convert.ToString(tabla_uso.Rows[x].Cells[0].Value) == Id_producto.Text)
                    {
                        Nombre.Text = Convert.ToString(tabla_uso.Rows[x].Cells[2].Value);
                        Precio.Text = Convert.ToString(tabla_uso.Rows[x].Cells[5].Value);
                       // band = 1;
                        //break;
                    }
                   
                }

               
                
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            int idven;
            DialogResult respuesta; //Guarda la accion del messageBox.

            //Manda mensaje si está seguro de eliminar registro.
            respuesta = MessageBox.Show("Confirma pago", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {

                  try
              {
                  OleDbCommand cmd = new OleDbCommand();

                  OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                  cmd.Connection = conexion;
                  conexion.Open();
                  if (dataGridView2.RowCount==0)
                  {
                      idven=dataGridView2.RowCount+1;

                  }
                  else
                  {
                      idven = 1;
                  }

                  string insertar = "INSERT INTO Venta(IdVenta,Total,Fecha,Empleado_RFC,Id_DetalleVenta) VALUES ( '"+ Convert.ToInt32(Id_venta_tex.Text)+ "','" + Int32.Parse(total_box.Text) + "', '" + dateTimePicker1.Value + "' ,'" + ID_emp_tex.Text + "','" + Convert.ToInt32(Id_venta_tex.Text) + "')";
                  cmd.CommandText = @insertar;
                  cmd.ExecuteNonQuery();

                 // MessageBox.Show("Producto agregado", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                try
                {
                    using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

                    {
                        conexion.Open();
                        string SqlActions = "DELETE * FROM  Detalle_venta";
                        OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
                        // cmd.Parameters.AddWithValue("@parametro", dataGridView1.SelectedCells);
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                        //MessageBox.Show("Producto Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                inserta_dat_detall();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta; //Guarda la accion del messageBox.

            //Manda mensaje si está seguro de eliminar registro.
            respuesta = MessageBox.Show("¿Seguro deseas cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
            {

                try
                {
                    using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

                    {
                        conexion.Open();
                        string SqlActions = "DELETE * FROM  Detalle_venta";
                        OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
                        // cmd.Parameters.AddWithValue("@parametro", dataGridView1.SelectedCells);
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                        //MessageBox.Show("Producto Eliminado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                inserta_dat_detall();
            }
        }
    }
}
