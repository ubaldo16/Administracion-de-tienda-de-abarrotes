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
{/// <summary>
/// clase utilizada para la consulta de usuarios en el sistema
/// </summary>
    public partial class FormularioUsuarios : Form
    {
        /// <summary>
        /// constructor de la clase inicializacion de componentes
        /// </summary>
        public FormularioUsuarios()
        {
            InitializeComponent();
        }


        /// <summary>
        /// metodo de para inicilizar la ventana de busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSearch_Click(object sender, EventArgs e)
        {
            UsuariosL Ul = new UsuariosL();
            Ul.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// metodo realiza la accion de alta de usuarios
        /// </summary>
        private void WorkedRegister()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                OleDbConnection conexion = new OleDbConnection(Properties.Settings.Default.ConexionDB);
                cmd.Connection = conexion;
                conexion.Open();
                string insertar = "INSERT INTO Empleado(RFC,Nombre,[Apellido Materno],[Apellido Paterno],Numero_Telefónico,Calle,Colonia,Numero_Exterior,CP,Contraseña,Privilegio) VALUES ( '" + textRFC.Text + "', '" + textNombre.Text + "' ,'" + textApellidoM.Text + "', '" + textApellidoP.Text + "', '" + Int32.Parse(textTel.Text) + "', '" + textCalle.Text + "','" + textCol.Text + "','" + Int32.Parse(textNumExt.Text) + "','" + Int32.Parse(textCP.Text) + "','" + Pass.Text + "', '" + Privilegio.SelectedIndex + "')";
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


        /// <summary>
        /// metodo utilizado para añadir usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAdd_Click(object sender, EventArgs e)
        {
            if (camposvacios() == true)
            {
                MessageBox.Show("Porfavor llene todos los campos obligatorios\n" + redcampos());
            }
            else
            {

                WorkedRegister();
            }
        }

        private string redcampos()
        {
            string res = "";

            if(textRFC.Text != "")
            {
                res += "* falta llenar el campo usuario\n";

            }
            if (textApellidoM.Text != "")
            {
                res += "* falta llenar el campo apellido materno\n";
            }
            if (textNombre.Text != "")
            {
                res += "* falta llenar el campo nombre\n";
            }
            if (textApellidoP.Text != "")
            {
                res += "* falta llenar el campo apellido paterno\n";
            }
            if (textCalle.Text!= "")
            {
                res += "* falta llenar el campo calle\n";
            }
            if (textCol.Text != "")
            {
                res += "* falta llenar el campo colonia\n";
            }
            if (textNumExt.Text != "")
            {
                res += "* falta llenar el campo numero exterior\n";
            }
            if (textCP.Text != "")
            {
                res += "* falta llenar el campo codigo postal\n";
            }
            if (textTel.Text != "")
            {
                res += "* falta llenar el campo télefono\n";
            }
            if (Pass.Text != "")
            {
                res += "* falta llenar el campo contraseña\n";
            }

            return res;

        }

        private bool camposvacios()
        {
            bool ban = false;

            if(textRFC.Text!="" && textNombre.Text!="" && textApellidoM.Text!="" && textApellidoP.Text != "" && textCalle.Text!="" && textCol.Text!="" && textNumExt.Text!="" && textCP.Text!="" && textTel.Text != "" && Pass.Text!="")
            {
                ban = true;
            }

            return ban;
        }

        /// <summary>
        /// metodo de validar de telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if (!(e.KeyChar > 48 && e.KeyChar < 57))
            {
                MessageBox.Show("Este campo solo acepta numeros\nporfavor solo escriba los digitos del numero telefonico");
            }
        }

        /// <summary>
        /// metodo de validar numero exterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNumExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            if (!(e.KeyChar > 48 && e.KeyChar <57))
            {
                MessageBox.Show("Este campo solo acepta numeros\nporfavor solo escriba los digitos del numero exterior");
            }
        }

        /// <summary>
        /// metodo de validar codigo postal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
            
            if(!(e.KeyChar>48 && e.KeyChar < 57))
            {
                MessageBox.Show("Este campo solo acepta numeros\nporfavor solo escriba los puros digitos del codigo postal");
            }
            
        }


        /// <summary>
        /// metodo de validar del nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
            if (e.KeyChar > 48 && e.KeyChar <57)
            {
                MessageBox.Show("Este campo solo acepta letras");
            }

        }

        /// <summary>
        /// metodo de validar apellido paterno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
            if (e.KeyChar > 48 && e.KeyChar < 57)
            {
                MessageBox.Show("Este campo solo acepta letras");
            }

        }

        /// <summary>
        /// metodo de validar apellido materno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
            if (e.KeyChar > 48 && e.KeyChar < 57)
            {
                MessageBox.Show("Este campo no acepta numeros");
            }
        }

   

        private void textCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textCol_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
