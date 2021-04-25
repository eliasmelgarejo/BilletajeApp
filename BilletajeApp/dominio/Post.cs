using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Post : EntidadBase
    {
        public Bus bus { get; set; }
        public double saldo { get; set; }

    }
}
