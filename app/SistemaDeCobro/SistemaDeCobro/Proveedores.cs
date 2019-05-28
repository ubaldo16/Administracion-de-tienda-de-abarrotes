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
		Boolean vis1 = false, vis2 = false;
		string auxiliar = "";
		public Proveedores()
		{
			
			InitializeComponent();
			generateTable();

		}


		private void WorkedRegister()
		{
			try
			{
				OleDbCommand cmd = new OleDbCommand();

				OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
				cmd.Connection = conexion;
				conexion.Open();
				string insertar = "INSERT INTO Proveedor(RFC,Nombre,Calle,Colonia,Numero,CP,Numero_Telefonico) VALUES ( '" + textRFC.Text + "', '" + textNombre.Text + "' ,'" + textCalle.Text + "','" + textCol.Text + "','" + Int32.Parse(textNumExt.Text) + "','" + Int32.Parse(textCP.Text) + "','"+ textTel.Text + "')";
				cmd.CommandText = @insertar;
				cmd.ExecuteNonQuery();
				MessageBox.Show("Registro guardado");
				conexion.Close();
				generateTable();

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

		private void generateTable()
		{
			try
			{

				DataTable results = new DataTable();
				using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))
				{
					OleDbCommand cmd = new OleDbCommand(@"Select * from Proveedor", conexion);
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

		private void ListaProvee()
		{
			dataGridView1.Visible = true;
			buttonSelection.Visible = true;
			ButDelete.Visible = true;
			Modificar.Visible = true;
			button1.Visible = true;
			label1.Visible = true;
		}
		private void Provee()
		{
			pictureBox1.Visible = false;
			label10.Visible = false;
			label11.Visible = false;
			label2.Visible = false;
			label5.Visible = false;
			label7.Visible =  false;
			label8.Visible = false;
			label9.Visible = false;
			textCP.Visible = false;
			textCol.Visible = false;
			textCalle.Visible = false;
			textNombre.Visible = false;
			textNumExt.Visible = false;
			textRFC.Visible = false;
			textTel.Visible = false;
			buttonBuscar.Visible = false;
			ButAdd.Visible = false;
			label3.Visible = false;
		}


		private void Proveedores_Load(object sender, EventArgs e)
		{

		}

		private void buttonBuscar_Click(object sender, EventArgs e)
		{
			vis1 = true;
			ListaProvee();
			Provee();

		}

		private void buttonSelection_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			visibilidad();
		}

		public void visibilidad()
		{
			dataGridView1.Visible = false;
			buttonSelection.Visible = false;
			ButDelete.Visible = false;
			Modificar.Visible = false;
			button1.Visible = false;
			label1.Visible = false;

			pictureBox1.Visible = true;
			label10.Visible = true;
			label11.Visible = true;
			label2.Visible = true;
			label5.Visible = true;
			label7.Visible = true;
			label8.Visible = true;
			label9.Visible = true;
			textCP.Visible = true;
			textCol.Visible = true;
			textCalle.Visible = true;
			textNombre.Visible = true;
			textNumExt.Visible = true;
			textRFC.Visible = true;
			textTel.Visible = true;
			buttonBuscar.Visible = true;
			ButAdd.Visible = true;
			label3.Visible = true;
		}

		private void textTel_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}

		private void textNumExt_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}

		private void textCP_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloNumeros(e);
		}

		private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validacion.SoloLetras(e);
		}

        private void Modificar_Click(object sender, EventArgs e)
        {
			
			visibilidad();
			llenarCampos();
			Cancel.Visible = true;
			button2.Visible = true;
			ButAdd.Visible = false;
			buttonBuscar.Visible = false;
			label4.Visible = true;
			label3.Visible = false;
			label1.Visible = false;
		}

		private void textCP_TextChanged(object sender, EventArgs e)
		{

		}

		private void ButAdd_Click(object sender, EventArgs e)
		{
			WorkedRegister();
			vaciaText();
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			generateTable();
			ListaProvee();
			Provee();
			Cancel.Visible = false;
			button2.Visible = false;
			label4.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			update();
			generateTable();
			button2.Visible = false;
			ListaProvee();
			Provee();
			Cancel.Visible = false;
			label4.Visible = false;

		}

		private void update()
		{
			try
			{
				OleDbCommand cmd = new OleDbCommand();

				OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
				cmd.Connection = conexion;
				conexion.Open();
				string update = "UPDATE Proveedor SET RFC='" + textRFC.Text + "', Nombre='" + textNombre.Text + "', Calle='" + textCalle.Text + "', Colonia='" + textCol.Text + "', Numero='" + Int32.Parse(textNumExt.Text) + "',CP='" + Int32.Parse(textCP.Text) + "', Numero_Telefonico='" + textTel.Text + "' WHERE RFC='" + auxiliar + "';";
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

		private void vaciaText()
		{
			textCalle.Text = "";
			textCol.Text = "";
			textCP.Text = "";
			textNombre.Text = "";
			textRFC.Text = "";
			textTel.Text = "";
			textNumExt.Text = "";
		}

		private void llenarCampos()
		{
			try

			{
				using (OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB))

				{
					conexion.Open();
					string SqlActions = "SELECT * FROM  Proveedor WHERE RFC = @parametro";
					OleDbCommand cmd = new OleDbCommand(SqlActions, conexion);
					cmd.Parameters.AddWithValue("@parametro", dataGridView1.CurrentRow.Cells["RFC"].Value);
					OleDbDataReader lector = cmd.ExecuteReader();

					if (lector.Read())
					{

						textRFC.Text = lector["RFC"].ToString();
						auxiliar = textRFC.Text;
						textNombre.Text = lector["Nombre"].ToString();
						textCalle.Text = lector["Calle"].ToString();
						textCol.Text = lector["Colonia"].ToString();
						textTel.Text = lector["Numero_Telefonico"].ToString();
						textCP.Text = lector["CP"].ToString();
						textNumExt.Text = lector["Numero"].ToString();
						visibilidad();
					}
					conexion.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
