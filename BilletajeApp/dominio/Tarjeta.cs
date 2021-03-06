using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Tarjeta : EntidadBase
    {        
        public string numero { get; set; }
        public Usuario usuario { get; set; } //numero de cédula
        public double saldo { get; set; }
        public EmpresaBilletaje empresa { get; set; }
        public bool activa { get; set; }

        public Tarjeta() { }

        public Tarjeta(string _numero,EmpresaBilletaje _empresa)
        {
            this.numero = _numero;
            this.empresa = _empresa;
            this.saldo = 0;
        }
        
    }
}
