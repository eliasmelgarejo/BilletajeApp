using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EmpresaBilletaje : EntidadBase
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public EmpresaBilletaje() { }

        public EmpresaBilletaje(string _Nombre,string _Marca)
        {
            this.Nombre = _Nombre;
            this.Marca = _Marca;
        }
    }
}
