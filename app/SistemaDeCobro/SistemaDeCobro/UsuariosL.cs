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
        /// <summary>
        /// variable auxiliar utilizada para guardar el usuario
        /// </summary>
        string auxiliar = "";

        /// <summary>
        ///declaracion de la clase de validaciones
        /// </summary>
        Validacion val =new Validacion();


        /// <summary>
        /// constructor de la forma donde inicializa el constructor
        /// </summary>
        public UsuariosL()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo utilizado para el cargador de la forma donde se carga la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsuariosL_Load(object sender, EventArgs e)
        {
            generateTable();
            TablaVisible(true, false);
        }


        /// <summary>
        /// Metodo que realiza la consulta de los empleados y lo carga en el datagridview
        /// </summary>
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


        /// <summary>
        /// metodo utilizado de button delete donde busca un registro y lo elimina de la base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// metodo utilizado para cambiar de ventana al modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modificar_Click(object sender, EventArgs e)
        {
            TablaVisible(false, true);
            llenarCampos();
			Cancel.Visible = true;
        }



        /// <summary>
        /// metodo el cual genera la actualizacion del registro en la base de datos
        /// </summary>
        private void update()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                cmd.Connection = conexion;
                conexion.Open();
                string update = "UPDATE Empleado SET RFC='"+textRFC.Text+"', Nombre='"+textNombre.Text+"', [Apellido Materno]='"+textApellidoM.Text+"', [Apellido Paterno]='" + textApellidoP.Text + "', Numero_Telefonico='"+Int32.Parse(textTel.Text)+ "', Calle='"+textCalle.Text+ "', Colonia='"+textCol.Text+ "', Numero_Exterior='"+ Int32.Parse( textNumExt.Text)+ "',CP='"+Int32.Parse(textCP.Text)+ "', Contraseña='"+Pass.Text+"',Privilegio='"+Privilegio.SelectedIndex+"' WHERE RFC='"+auxiliar+"';";
                cmd.CommandText = @update;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Modificado");
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


        /// <summary>
        /// metodo utilizado para habilitar la visibilidad de los componentes
        /// </summary>
        /// <param name="ban2">bandera para componente de muestra</param>
        /// <param name="ban"> bandera para componentes de modificar</param>
        private void TablaVisible(bool ban2,bool ban)
        {
            
                Modificar.Visible = ban2;
                ButDelete.Visible = ban2;
                buttonSelection.Visible = ban2;
                dataGridView1.Visible = ban2;
                label1.Visible = ban2;
           

                pictureBox1.Visible = ban;
                textRFC.Visible = ban;
                textNombre.Visible = ban;
                textApellidoM.Visible = ban;
                textApellidoP.Visible = ban;
                textCalle.Visible = ban;
                textCol.Visible = ban;
                textNumExt.Visible = ban;
                textTel.Visible = ban;
                textCP.Visible = ban;
                Pass.Visible = ban;
                Privilegio.Visible = ban;
                label2.Visible = ban;
                label3.Visible = ban;
                label4.Visible = ban;
                label5.Visible = ban;
                label6.Visible = ban;
                label7.Visible = ban;
                label8.Visible = ban;
                label9.Visible = ban;
                label10.Visible = ban;
                label11.Visible = ban;
                label12.Visible = ban;
                label13.Visible = ban;
                ButAdd.Visible = ban;
                Cancel.Visible = ban;



        }


        /// <summary>
        /// metodo utilizado para el llenado automatico de campos al modificar
        /// </summary>
        private void llenarCampos()
        {
            try

            {
                using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

                {
                    conexion.Open();
                    string SqlActions = "SELECT * FROM  Empleado WHERE RFC = @parametro";
                    OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
                    cmd.Parameters.AddWithValue("@parametro", dataGridView1.CurrentRow.Cells["RFC"].Value);
                    OleDbDataReader lector = cmd.ExecuteReader();

                    if (lector.Read())
                    {
                        
                        textRFC.Text = lector["RFC"].ToString();
                        auxiliar = textRFC.Text;
                        textNombre.Text = lector["Nombre"].ToString();
                        textApellidoM.Text = lector["Apellido Materno"].ToString();
                        textApellidoP.Text = lector["Apellido Paterno"].ToString();
                        textCalle.Text = lector["Calle"].ToString();
                        textCol.Text = lector["Colonia"].ToString();
                        textTel.Text = lector["Numero_Telefonico"].ToString();
                        textCP.Text = lector["CP"].ToString();
                        Pass.Text = lector["Contraseña"].ToString();
                        textNumExt.Text = lector["Numero_Exterior"].ToString();
                        Privilegio.SelectedIndex = Int32.Parse(lector["Privilegio"].ToString());
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// realiza la accion de modificar en base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAdd_Click(object sender, EventArgs e)
        {
            update();
            generateTable();
            TablaVisible(true, false);
        }

        /// <summary>
        /// realiza la accion de cancelar al modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Cancel_Click(object sender, EventArgs e)
        {
            generateTable();
            TablaVisible(true, false);
			Cancel.Visible = false;
		}

        private void textRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        /// <summary>
        /// metodo de validar del nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        /// <summary>
        /// metodo de validar de telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }


        /// <summary>
        /// metodo de validar numero exterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        /// <summary>
        /// metodo de validar codigo postal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }


        /// <summary>
        /// metodo de validar apellido paterno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }


        /// <summary>
        /// metodo de validar apellido materno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }
    }
}
