﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeCobro
{/// <summary>
/// Clase utilizada para validaciones
/// </summary>
	class Validacion
	{
		public static void SoloLetras(KeyPressEventArgs v)
		{
			if (char.IsLetter(v.KeyChar))
			{
				v.Handled = false;
			}
			else if (char.IsSeparator(v.KeyChar))
			{
				v.Handled = false;
			}
			else if (char.IsControl(v.KeyChar))
			{
				v.Handled = false;
			}
			else
			{
				v.Handled = true;
			}
		}

		public static void SoloNumeros(KeyPressEventArgs v)
		{
			if (char.IsDigit(v.KeyChar))
			{
				v.Handled = false;
			}
			else if (char.IsSeparator(v.KeyChar))
			{
				v.Handled = false;
			}
			else if (char.IsControl(v.KeyChar))
			{
				v.Handled = false;
			}
			else
			{
				v.Handled = true;
			}
		}
	}
}
