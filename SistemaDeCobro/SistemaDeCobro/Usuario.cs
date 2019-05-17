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


        public Usuario(string id)
        {
            rfc = id;
        }
    }
}
