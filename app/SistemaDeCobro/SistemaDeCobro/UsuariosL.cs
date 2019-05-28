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
        string auxiliar = "";

        public UsuariosL()
        {
            InitializeComponent();
        }

        private void UsuariosL_Load(object sender, EventArgs e)
        {
            generateTable();
            TablaVisible(true, false);
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

        private void Modificar_Click(object sender, EventArgs e)
        {
            TablaVisible(false, true);
            llenarCampos();
			Cancel.Visible = true;
        }

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
            


        }

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

        private void ButAdd_Click(object sender, EventArgs e)
        {
            update();
            generateTable();
            TablaVisible(true, false);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            generateTable();
            TablaVisible(true, false);
			Cancel.Visible = false;
		}
    }
}
