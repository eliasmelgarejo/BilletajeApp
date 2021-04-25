using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Tarjeta : EntidadBase
    {
        
        public string nombre { get; set; }
        public Usuario usuario { get; set; } //numero de cédula
        public double saldo { get; set; }
        public EmpresaBilletaje empresa { get; set; }
        public bool activa { get; set; }

        public Tarjeta(string _numero,EmpresaBilletaje _empresa)
        {
            this.nombre = _numero;
            this.empresa = _empresa;
            this.saldo = 0;
        }

        public override string ToString()
        {
            return "UUID: "+this.UUID+" Tarjeta Nro: "+this.nombre+" de la Marca: "+this.empresa.Marca;
        }

    }
}
