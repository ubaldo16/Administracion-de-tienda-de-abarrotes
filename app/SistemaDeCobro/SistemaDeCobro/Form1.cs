using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCobro
{
	public partial class Menu : Form
	{
        private Usuario usu;
		private bool ProvL;

		public Menu(Usuario u)
		{
			
            usu = u;
			InitializeComponent();
            if (u.Privilegio == 1)
            {
                buttonUsuarios.Visible = false;
                buttonRegistro.Visible = false;
            }
			label1.Text = u.Nombre;
			label1.Visible = true;
		}
		public Menu()
		{

			InitializeComponent();
		}

		public bool ProveeL
		{
		
			get
			{
				return ProvL;
			}
			set
			{
				ProvL = value;
			}

		}

		public void AbrirForm(object formHijo)
		{
			if (this.panelForm.Controls.Count > 0)
				this.panelForm.Controls.RemoveAt(0);
			Form fh = formHijo as Form;
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			this.panelForm.Controls.Add(fh);
			this.panelForm.Tag = fh;
			fh.Show();
		}

		private void buttonRegistro_Click(object sender, EventArgs e)
		{
			this.Text = "Registro";
			AbrirForm(new FormularioUsuarios());
		}

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
			this.Text = "Lista de usuarios";
			AbrirForm(new UsuariosL());
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
			this.Text = "Inventario";
			AbrirForm(new Inventario());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

		private void PanelMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void buttonProveedores_Click(object sender, EventArgs e)
		{
			this.Text = "Proveedores";
			AbrirForm(new Proveedores());
		}

		private void Menu_Activated(object sender, EventArgs e)
		{

			if (ProvL)
			{
				AbrirForm(new ProveedoresL());
			}

			ProvL = false;
		}

		private void panelForm_Paint(object sender, PaintEventArgs e)
		{

		}

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
