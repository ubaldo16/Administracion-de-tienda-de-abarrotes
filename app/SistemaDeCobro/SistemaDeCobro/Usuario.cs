using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCobro
{
    public class Usuario
    {
        private string rfc;
        private string nombre;
        private int privilegio;
        private string apellidom;
        private string apellidop;
        private int telefono;
        private string calle;
        private string colonia;
        private int numero;
        private int cp;
        private string contraseña;
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
