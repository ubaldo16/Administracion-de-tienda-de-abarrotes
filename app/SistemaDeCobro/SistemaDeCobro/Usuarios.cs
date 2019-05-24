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
	public partial class FormularioUsuarios : Form
	{
		public FormularioUsuarios()
		{
			InitializeComponent();
		}

		private void butSearch_Click(object sender, EventArgs e)
		{
			UsuariosL Ul = new UsuariosL();
			Ul.Show();
		}

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void WorkedRegister()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                
                OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                cmd.Connection = conexion;
                conexion.Open();
                string insertar = "INSERT INTO Empleado(RFC,Nombre,[Apellido Materno],[Apellido Paterno],Numero_Telefonico,Calle,Colonia,Numero_Exterior,CP,Contraseña,Privilegio) VALUES ( '"+ textRFC.Text+ "', '"+textNombre.Text+"' ,'"+textApellidoM.Text+"', '"+textApellidoP.Text+"', '"+Int32.Parse(textTel.Text)+"', '"+textCalle.Text+"','"+textCol.Text+"','"+Int32.Parse(textNumExt.Text)+"','"+Int32.Parse(textCP.Text)+"','"+Pass.Text+"', '"+Privilegio.SelectedIndex+"')";
                cmd.CommandText = @insertar;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                conexion.Close();

            }
            catch(DBConcurrencyException ex)
            {
                MessageBox.Show("Error de concurrencia:\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButAdd_Click(object sender, EventArgs e)
        {
            WorkedRegister();
        }

		private void textTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}

		private void textNumExt_TextChanged(object sender, EventArgs e)
		{

		}

		private void textNumExt_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}

		private void textCP_TextChanged(object sender, EventArgs e)
		{

		}

		private void textCP_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}
	}
}
