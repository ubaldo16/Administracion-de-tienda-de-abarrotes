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
	}
}
