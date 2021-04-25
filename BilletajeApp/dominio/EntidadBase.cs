using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EntidadBase
    {
        private Guid uuid = System.Runtime.InteropServices.Marshal.GenerateGuidForType(typeof(EntidadBase));
        public string className{ get { return GetType().Name; } }
        public Guid UUID { get { return this.uuid; } }
                
    }
}
