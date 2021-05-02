using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Transaccion : EntidadBase
    {
        public DateTime fechaHora { get; set; }
        public Bus bus { get; set; }
        public Tarjeta tarjeta { get; set; }
        public TipoBus tipoBus { get; set; }
        public double monto { get; set; }
        public TipoOperacion operacion { get; set; }

        public Transaccion() { }

        public Transaccion(Bus bus,Tarjeta tarjeta, TipoOperacion operacion)
        {
            this.fechaHora = new DateTime();
            this.bus = bus;
            this.tarjeta = tarjeta;
            this.tipoBus = bus.Tipo;
            this.monto = Utils.calculaPasaje(bus.Tipo);
            this.operacion = operacion;
        }
    }
}
