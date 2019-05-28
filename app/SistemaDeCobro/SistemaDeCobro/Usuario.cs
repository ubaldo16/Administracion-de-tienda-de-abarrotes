using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCobro
{/// <summary>
/// clase utilizada para el usuario
/// </summary>
    public class Usuario
    {
        /// <summary>
        /// campo uyilizado para el RFC
        /// </summary>
        private string rfc;
        /// <summary>
        /// campo utilizado para el nombre
        /// </summary>
        private string nombre;

        /// <summary>
        /// campo tilizado para el privilego
        /// </summary>
        private int privilegio;

        /// <summary>
        /// campo utilizado para apellido materno
        /// </summary>
        private string apellidom;

        /// <summary>
        /// campo utilizado para apellido paterno
        /// </summary>
        private string apellidop;

        /// <summary>
        /// campo utilizado telefono
        /// </summary>
        private int telefono;

        /// <summary>
        /// campo utilizado calle
        /// </summary>
        private string calle;

        /// <summary>
        /// campo utilizado para la colonia
        /// </summary>
        private string colonia;

        /// <summary>
        /// campo utilizado para el numero exterior
        /// </summary>
        private int numero;

        /// <summary>
        /// campo utilizadopara codigo postal
        /// </summary>
        private int cp;

        /// <summary>
        /// campo utilizado para la contraseña
        /// </summary>
        private string contraseña;

        /// <summary>
        /// campo utilizado para el tipo
        /// </summary>
        private int tipo;
       
 


        public Usuario(string id, int p,string n)
        {
            rfc = id;
            privilegio = p;
			nombre = n;
        }

        public string  RFC  // Esta es su propiedad 
            { 
            get { return rfc;}
            set  { rfc = value ;} 
            }
        public string Nombre  // Esta es su propiedad 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Privilegio  // Esta es su propiedad 
        {
            get { return privilegio; }
            set { privilegio = value; }
        }
        public string ApellidoM  // Esta es su propiedad 
        {
            get { return apellidom; }
            set { apellidom = value; }
        }
        public string ApellidoP  // Esta es su propiedad 
        {
            get { return apellidop; }
            set { apellidop = value; }
        }
        public int Telefono  // Esta es su propiedad 
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Calle  // Esta es su propiedad 
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Colonia  // Esta es su propiedad 
        {
            get { return colonia; }
            set { colonia = value; }
        }
        public int Numero  // Esta es su propiedad 
        {
            get { return numero; }
            set { numero = value; }
        }
        public int CP  // Esta es su propiedad 
        {
            get { return cp; }
            set { cp = value; }
        }
        public string Contraseña  // Esta es su propiedad 
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public int Tipo  // Esta es su propiedad 
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
