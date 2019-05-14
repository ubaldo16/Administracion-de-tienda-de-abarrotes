﻿using System;
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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

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
                    Menu m = new Menu();
                    m.Show();
                    this.Visible = false;

                }
                else
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");

                con.Close();
            }
        
		}
	}
}
