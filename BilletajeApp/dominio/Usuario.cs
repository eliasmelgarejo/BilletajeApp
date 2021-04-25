using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Usuario : EntidadBase
    {
        public string nombre { get; }
        public string cedula { get; }

        public Usuario() { }

        public Usuario(string nombre,string cedula)
        {
            this.nombre = nombre;
            this.cedula = cedula;
        }
    }
}
