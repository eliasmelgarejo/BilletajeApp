using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EntidadBase
    {
        public long id { get; set; }
        public string className{ get { return GetType().Name; } }                
    }
}
