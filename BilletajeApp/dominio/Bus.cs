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

        public Bus(int numero,TipoBus tipo,EmpresaTransporte empresa)
        {
            this.Numero = numero;
            this.Tipo = tipo;
            this.Empresa = empresa;
        }

        public override string ToString()
        {
            return "UUID: "+this.UUID+" Numero: "+this.Numero+" Tipo: "+this.Tipo+" Empresa: "+Empresa.Nombre;
        }
    }

}
