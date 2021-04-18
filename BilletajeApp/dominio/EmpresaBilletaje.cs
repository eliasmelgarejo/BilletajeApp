using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EmpresaBilletaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }

        public EmpresaBilletaje(int _Id,string _Nombre,string _Marca)
        {
            this.Id = _Id;
            this.Nombre = _Nombre;
            this.Marca = _Marca;
        }
    }
}
