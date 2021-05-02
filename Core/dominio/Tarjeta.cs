using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.Core.dominio
{
    public class Tarjeta : EntidadBase
    {        
        public string nombre { get; set; }
        public Usuario usuario { get; set; } //numero de cédula
        public double saldo { get; set; }
        public EmpresaBilletaje empresa { get; set; }
        public bool activa { get; set; }

        public Tarjeta() { }

        public Tarjeta(string _numero,EmpresaBilletaje _empresa)
        {
            this.nombre = _numero;
            this.empresa = _empresa;
            this.saldo = 0;
        }
        
    }
}
