using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Usuario
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Cedula { get; }

        public Usuario(int id,string nombre,string cedula)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cedula = cedula;
        }

        public override string ToString()
        {
            return "Usuario id:"+Id+" Nombre: "+Nombre+" Cédula: "+Cedula;
        }

        public override bool Equals(object obj)
        {
            bool R = false;
            if (this.Cedula == ((Usuario)obj).Cedula)
            {
                R = true;
            }
            return R;
        }
    }
}
