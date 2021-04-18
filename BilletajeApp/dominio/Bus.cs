using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Bus : IBus
    {
        public int Id { get;}
        public int Numero { get; set; }
        public TipoBus Tipo { get; set; }
        public EmpresaTransporte Empresa { get; set; }

        public Bus(int id,int numero,TipoBus tipo,EmpresaTransporte empresa)
        {
            this.Id = id;
            this.Numero = numero;
            this.Tipo = tipo;
            this.Empresa = empresa;
        }

        public double cobroPasaje()
        {
            Console.WriteLine("Coche Nro.: "+this.Numero+" Cobrando Pasaje de tipo: "+
                this.Tipo.ToString()+" monto Gs."+Utils.calculaPasaje(this.Tipo)+"...");
            return Utils.calculaPasaje(this.Tipo);
        }

        public double devolucionPasaje()
        {
            return Utils.calculaPasaje(this.Tipo);
        }

        public override string ToString()
        {
            return "Id: "+this.Id+" Numero: "+this.Numero+" Tipo: "+this.Tipo+" Empresa: "+Empresa.Nombre;
        }
    }

}
