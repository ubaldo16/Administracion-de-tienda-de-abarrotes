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
	public partial class Proveedores : Form
	{
		
		public Proveedores()
		{
			InitializeComponent();
		}


		private void WorkedRegister()
		{
			try
			{
				OleDbCommand cmd = new OleDbCommand();

				OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
				cmd.Connection = conexion;
				conexion.Open();
				string insertar = "INSERT INTO Proveedor(RFC,Nombre,Calle,Colonia,Numero,CP,Numero_Telefonico,Inventario_Id) VALUES ( '" + textRFC.Text + "', '" + textNombre.Text + "' ,'" + textCalle.Text + "','" + textCol.Text + "','" + Int32.Parse(textNumExt.Text) + "','" + Int32.Parse(textCP.Text) + "','"+ textTel.Text + "', '" +"0"+ "')";
				cmd.CommandText = @insertar;
				cmd.ExecuteNonQuery();
				MessageBox.Show("Registro guardado");
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

		private void Proveedores_Load(object sender, EventArgs e)
		{

		}

		private void buttonBuscar_Click(object sender, EventArgs e)
		{
			

		}

		private void ButAdd_Click(object sender, EventArgs e)
		{
			WorkedRegister();
		}
	}
}
