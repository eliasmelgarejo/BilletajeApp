using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public abstract class EmpresaTransporte : EntidadBase
    {
        public string nombre { get; set; }
        public List<Bus> flota { get; set; }
    }
}
