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
		public Menu()
		{
			InitializeComponent();
		}

		private void AbrirForm(object formHijo)
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
			AbrirForm(new FormularioUsuarios());
		}
	}
}
