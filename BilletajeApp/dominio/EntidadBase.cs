using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EntidadBase
    {
        private Guid uuid = Guid.NewGuid();
        public string className{ get { return GetType().Name; } }
        public Guid UUID { get { return this.uuid; } }

        public override string ToString()
        {
            return "Entiad: "+className+" UUID: "+UUID;
        }
    }
}
