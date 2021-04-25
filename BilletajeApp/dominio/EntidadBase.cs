using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class EntidadBase
    {
        //public String UUID { get { return this.UUID; } set { this.UUID = Guid.NewGuid().ToString(); } }//Guid.NewGuid().ToString()
        private Guid iid = System.Runtime.InteropServices.Marshal.GenerateGuidForType(typeof(EntidadBase));
        public string className{ get { return GetType().Name; } }
        public Guid UUID { get { return this.iid; } }
    }
}
