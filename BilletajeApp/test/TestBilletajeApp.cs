using BilletajeApp.commons;
using BilletajeApp.dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

                string output = JsonConvert.SerializeObject(linea15);

                Console.Write(output.ToString());

                

                IBus coche43 = new Bus(++keys,43,TipoBus.REGULAR,linea15);
                Console.WriteLine(coche43.ToString());

                linea15.AgregarBus((Bus) coche43);
                
                EmpresaBilletaje mas = new EmpresaBilletaje(++keys, "Empresa EPAS", "más");
                Console.WriteLine("Empresa "+mas.ToString());

                Tarjeta tarjetas = new Tarjeta(++keys, "3600-0020-0031-9479", mas);
                Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);

                Usuario carmen = new Usuario(++keys, "Carmen", "123");
                tarjetas.AsignarUsuario(carmen);

                if (tarjetas.ActivarTarjeta())
                {
                    Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);
                    Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
                    tarjetas.SumarSaldo(56000);
                    Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);

                    //operaciones con tarjetas y buses
                    Console.WriteLine("El usuario sube al bus linea 15 coche 43 y paga el importe del paseje...");
                    tarjetas.RestarSaldo(coche43.cobroPasaje());
                    Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
                }
                else
                {
                    Console.WriteLine("La tarjeta no esta ACTIVA...");
                }

                using (StreamWriter sw =
                    new StreamWriter(@"C:\Users\Elias\source\repos\BilletajeApp\BilletajeApp\bd\tarjeta.json"));

                if (ManipularArchivosJson.exitsArchivo("", "")==false)
                {
                    ManipularArchivosJson.crearArchivo("", "");
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                R = false;
            }

            return R;
        }

    }
}
