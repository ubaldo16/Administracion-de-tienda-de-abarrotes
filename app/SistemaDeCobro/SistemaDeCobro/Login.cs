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
    /// <summary>
    /// clase utilizada para el login del usuario
    /// </summary>
	public partial class Login : Form
	{
        Usuario usu;

        /// <summary>
        /// constructor de la form
        /// </summary>
		public Login()
		{
			InitializeComponent();
		}


        /// <summary>
        /// metodo utilizado para realizar el logeo del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void buttonLog_Click(object sender, EventArgs e) //Login
		{           
            string cmdText = "select Count(*) from Empleado where RFC=? and [Contraseña]=?";
            using (OleDbConnection con = new OleDbConnection(Properties.Settings.Default.ConexionDB))
            using (OleDbCommand cmd = new OleDbCommand(cmdText, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@p1", textboxUser.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxPass.Text);  // <- is this a variable or a textbox?
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login Successful");
                    string comprobacion = "SELECT Privilegio, Nombre  FROM Empleado WHERE RFC = @rfc";
                    OleDbCommand comando = new OleDbCommand(comprobacion, con);
                    comando.Parameters.AddWithValue("@rfc", textboxUser.Text);

                    OleDbDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        
                        Menu m = new Menu(new Usuario(textboxUser.Text, Int32.Parse(lector["Privilegio"].ToString()), lector["Nombre"].ToString()));//checar logeo si es usuario o administrador
                        m.Show();
                        this.Visible = false;
                    }
                    

                }
                else
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");

                con.Close();
            }
			
		}
	}
}
