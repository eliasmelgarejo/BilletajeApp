using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Bus : EntidadBase
    {
        public int Numero { get; set; }
        public TipoBus Tipo { get; set; }
        public EmpresaTransporte Empresa { get; set; }

        public Bus() { }

        public Bus(int numero,TipoBus tipo)
        {
            this.Numero = numero;
            this.Tipo = tipo;
        }

    }

}
