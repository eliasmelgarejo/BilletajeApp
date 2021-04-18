using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public static class Utils
    {
        public static double calculaPasaje(TipoBus tipo)
        {
            double R = 0;

            if (tipo == TipoBus.REGULAR) R = 2300;
            else if (tipo == TipoBus.EJECUTIVO) R = 3400;

            return R;
        }
    }
}
