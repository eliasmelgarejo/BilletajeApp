using BilletajeApp.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.test
{
    public static class TestBilletajeApp
    {
        public static bool test1()
        {
            bool R = false;
            try
            {
                //variable que simular id autoincrementables
                int keys = 0;

                EmpresaTransporte linea15 = new Linea15(++keys);
                Console.WriteLine(linea15.ToString());

                IBus coche43 = new Bus(++keys,43,TipoBus.REGULAR,linea15);
                Console.WriteLine(coche43.ToString());
                
                EmpresaBilletaje mas = new EmpresaBilletaje(++keys, "Empresa EPAS", "más");
                Console.WriteLine("Empresa "+mas.ToString());

                Tarjetas tarjetas = new Tarjetas(++keys, "3600-0020-0031-9479", mas);
                Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);

                tarjetas.ActivarTarjeta();
                Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);
                Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
                tarjetas.SumarSaldo(56000);
                Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);

                //operaciones con tarjetas y buses
                Console.WriteLine("El usuario sube al bus linea 15 coche 43 y paga el importe del paseje...");
                tarjetas.RestarSaldo(coche43.cobroPasaje());
                Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
                

            }catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                R = false;
            }

            return R;
        }

    }
}
