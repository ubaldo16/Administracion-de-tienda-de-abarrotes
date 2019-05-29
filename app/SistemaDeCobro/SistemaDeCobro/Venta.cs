using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;


namespace SistemaDeCobro
{
    public partial class Venta : Form
    {
        double Total;
        double sub_prod;
        Usuario usu;
		int total1;
		string canti, arti, subt;
		string articulos = "";
        /// <summary>
        /// Constructor de la ventana recibe una variable de tipo USUARIO para extraer los el ID del empleado
        /// 
        /// Las funciones llamadas inician las consultas en las tablas y las inserta
        /// inserta_dat_ventas();
        /// inserta_dat_detall();
        /// 
        /// </summary>
        /// <param name="u"></param>
        public Venta(Usuario u)
        {

            usu = u;
            Total = 0;
            sub_prod = 0;

            InitializeComponent();
            inserta_dat_ventas();
            inserta_dat_detall();
            llenaCombo();
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
        /// <summary>
        /// Esta funcion consulta si existe algo el la tabla Detalles de venta, y lo muestra
        /// </summary>
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

        /// <summary>
        /// Hace las consultas en la tabla de Inventario para el uso 
        /// </summary>
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
        /// <summary>
        /// Esta funcion consulta si existe algo el la tabla Venta
        /// </summary>
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

        /// <summary>
        /// limpia los campos de los cuadros de textos
        /// </summary>

        private void limpiarBoxes()
        {
            Cantidad.Text = "";
            Precio.Text = "";
            Nombre.Text = "";
           // Id_producto.Text = "";
           
        }
        private void limpiaPago()
        {
            Subtotal_box.Text = "";
            total_box.Text = "";
            efectiv_tex.Text = "";
            Cambio_tex.Text = "";
            Total = 0;
        }
        /// <summary>
        /// Evento del cuadro de texto Cantidad
        /// hace los calculos multiplicando la cantidad por el precio para tener un subtotal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

            if (Cantidad.Text == "") { }
            else
            {
                sub_prod = (Int32.Parse(Cantidad.Text) * Convert.ToDouble(Precio.Text));
                
                Subtotal_box.Text = Convert.ToString(sub_prod);
               
            }
        }
        /// <summary>
        /// Evento del boton Agregar Producto
        /// En esta funcion hace la insercion de los datos en la tabla de Detalles de venta de cada producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insertar_Click(object sender, EventArgs e)
        {
            int idven;
            Total = sub_prod + Total;
			canti = Cantidad.Text;
			subt = Precio.Text;
			arti = Nombre.Text;
			articulos += "      " + canti + "      " + arti + "     " + subt + "     " + total1.ToString() + "\n";
			total_box.Text = Convert.ToString(Total);
			total1 = Int32.Parse(Precio.Text) * Int32.Parse(Cantidad.Text);
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
                string insertar = "INSERT INTO Detalle_venta(Id_DetalleVenta,Cantidad,Subtotal,Inventario_Id) VALUES ( '" + idven + "','" + Convert.ToDouble(Cantidad.Text) + "', '" + Convert.ToDouble(Subtotal_box.Text) + "', '" + Convert.ToInt32(tabla_uso.Rows[comboBox1.SelectedIndex].Cells[0].Value) + "')";
                cmd.CommandText = @insertar;
                cmd.ExecuteNonQuery();
               
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
        /// <summary>
        /// Evento del boton del cuadro de texto del id del producto
        /// esta funcion busca en la tablade inventario el producto utilizando el contenido que se ingreso en el cuadro de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      /*  private void Id_producto_TextChanged(object sender, EventArgs e)
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
                for (x = 0; x < tabla_uso.RowCount; x++)
                {
                    if (Convert.ToString(tabla_uso.Rows[x].Cells[0].Value) == Id_producto.Text)
                    {
                        // Nombre.Text = Convert.ToString(tabla_uso.Rows[x].Cells[2].Value);
                        //Precio.Text = Convert.ToString(tabla_uso.Rows[x].Cells[5].Value);

                        band = 1;
                        break;
                    }

                }

                if (band == 1)
                {
                    MessageBox.Show("Producto agregado");
                    Nombre.Text = Convert.ToString(tabla_uso.Rows[x].Cells[2].Value);
                    Precio.Text = Convert.ToString(tabla_uso.Rows[x].Cells[5].Value);
                }
                else
                {
                    MessageBox.Show("No existe el producto, Introduce una clave valida");
                    limpiarBoxes();
                }




            }
        }*/

        /// <summary>
        /// Este es el evento del boton de pagar
        /// Esta funcion primero pide confirmacion del pago y si lo hace agrega los totales en la tabla de Venta con info del Empleado que lo hizo
        /// tambien borra los productos de la tabla de detalle de venta
        /// ademas arroja a pantalla un ticket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modificar_Click(object sender, EventArgs e)
        {
            int idven;
            int cantidad_mod = 0;
            int n1 = 0;
            int n2 = 0;
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
                    OleDbCommand cmd = new OleDbCommand();

                    OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                    cmd.Connection = conexion;
                    conexion.Open();
                    inserta_dat_detall();
                    for (int x = 0; x < dataGridView1.RowCount; x++)
                    {
                        MessageBox.Show("ID EN DETA"+Convert.ToString(dataGridView1.Rows[x].Cells[3].Value));
                         n1 = Convert.ToInt32(dataGridView1.Rows[x].Cells[1].Value);

                        for (int y = 0; y < tabla_uso.RowCount; y++)
                        {
                            MessageBox.Show("ID EN TABLA"+Convert.ToString(tabla_uso.Rows[x].Cells[0].Value));
                            if (Convert.ToInt32(tabla_uso.Rows[y].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[x].Cells[3].Value))
                            {

                                n2 = Convert.ToInt32(tabla_uso.Rows[y].Cells[3].Value);
                                MessageBox.Show("CANTI EN TABLA" + Convert.ToString(tabla_uso.Rows[y].Cells[3].Value));
                                cantidad_mod = n2 - n1;
                                MessageBox.Show("Cantidad a insertar" + Convert.ToString(cantidad_mod));
                                // string update = "UPDATE Inventario SET Cantidad='" + tabla_uso.Rows[x].Cells[3].Value + "' WHERE Id_Inventario='" + Convert.ToInt32(tabla_uso.Rows[y].Cells[0].Value) + "';";
                                string update = "UPDATE Inventario SET Id_Proveedor='" + Convert.ToInt32(tabla_uso.Rows[x].Cells[1].Value) + "' , Nombre='" + Convert.ToString(tabla_uso.Rows[x].Cells[2].Value) + "', Cantidad='" + Convert.ToInt32(tabla_uso.Rows[x].Cells[3].Value) + "', Caducidad='" + tabla_uso.Rows[x].Cells[4].Value + "', Precio='" + Convert.ToDouble(tabla_uso.Rows[x].Cells[5].Value) + "', Perecedero='" + Convert.ToInt32(tabla_uso.Rows[x].Cells[6].Value) + "' WHERE Id_Inventario='" + Convert.ToInt32(tabla_uso.Rows[y].Cells[0].Value) + "';";

                                cmd.CommandText = @update;
                                cmd.ExecuteNonQuery();
                            }
                           
                        }

                    }

                    MessageBox.Show("Producto Modificado", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			To_pdf();
            limpiaPago();

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

        private void efectiv_tex_TextChanged(object sender, EventArgs e)
        {
            double s=0;
            if (efectiv_tex.Text != "")
            {
                s = Convert.ToDouble(efectiv_tex.Text) - Total;
                Cambio_tex.Text = Convert.ToString(s);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int band = 0;
            int x;
            ID_emp_tex.Text = usu.Nombre;
         //   inserta_dat_Tabla();
            
         

                    MessageBox.Show("Producto agregado");
                    Nombre.Text = Convert.ToString(tabla_uso.Rows[comboBox1.SelectedIndex].Cells[2].Value);
                    Precio.Text = Convert.ToString(tabla_uso.Rows[comboBox1.SelectedIndex].Cells[5].Value);

            
        }
        private void llenaCombo()
        {
            inserta_dat_Tabla();
            for (int x = 0; x < tabla_uso.RowCount; x++)
            {
                comboBox1.Items.Add(Convert.ToString(tabla_uso.Rows[x].Cells[2].Value));
            }
        }
        /// <summary>
        /// Este evento es del boton Cancelar
        /// en esta funcion pide una confirmacion de cancelacion y si se quiere cancelar se borran los datos de Detalle de venta
        /// y no se agrega nada a las tablas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                limpiarBoxes();
                limpiaPago();
            }
        }
        /// <summary>
        /// Esta funcion es la que se utiliza para arrojar a pantalla el ticket
        /// </summary>
		private void To_pdf()
		{
			Document doc = new Document(PageSize.A5 , 10, 10, 10, 10);//Variable de tipo documento y su instancia
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();//instancia para guardar los datos
			string path = Directory.GetCurrentDirectory();
			saveFileDialog1.InitialDirectory = path;
			saveFileDialog1.Title = "Ticket";//Titulo del documento
			saveFileDialog1.DefaultExt = "pdf";//Extencion del documento
			saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";//Tipo de archivo
			saveFileDialog1.FilterIndex = 2;
			saveFileDialog1.RestoreDirectory = true;

			FileStream file = new FileStream("Ticket.pdf", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);//Creamos y escribimos en el PDF
			PdfWriter.GetInstance(doc, file);
			doc.Open();//Abrimos el docuemnto
			string remito = "Empleado: " + ID_emp_tex.Text;
			string fecha = "Fecha:" + DateTime.Now.ToString();

			/*
             *En las siguientes lineas creamos el diseño del boleto que se imprimira 
             */
			Chunk chunk = new Chunk("Tienda de abarrotes \"Los Pinos\" ", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
			doc.Add(new Paragraph(chunk));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
			doc.Add(new Paragraph("San Luis Potosi, San Luis Potosi"));
			doc.Add(new Paragraph("Direccion: Zaragoza #523"));
			doc.Add(new Paragraph("Telefono: (444)-507-66-83"));
			doc.Add(new Paragraph("E-mail: LosPinosAbarrotes@gmail.com"));
			doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph(remito));
			doc.Add(new Paragraph(fecha));
			doc.Add(new Paragraph("Caja: 1"));
			doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("cantidad" + "     " + "Articulo" + "     " + "Subtotal"+"     "+ "Total"));
			doc.Add(new Paragraph("                       "));			
			doc.Add(new Paragraph(articulos));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("			Total de la venta: " + Total));
			doc.Add(new Paragraph("			Pago un total de: " + total_box.Text));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("                       "));			
			doc.AddCreationDate();
			doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("                       "));
			doc.Add(new Paragraph("							Gracias Por su preferencia               "));
			doc.Add(new Paragraph("_______________________________________", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
			doc.Close();
			Process.Start("Ticket.pdf");//Esta parte se puede omitir, si solo se desea guardar el archivo, y que este no se ejecute al instante

		}
	}
}
