using BilletajeApp.dominio;
using BilletajeApp.repositorios;
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
                
                /*

                //recuperar el archivo y convertir en una lista de objetos
                String path = @"c:\bd\empresatransporte.json";
                string original = System.IO.File.ReadAllText(path);
                Console.WriteLine("Archivo JSon original");
                Console.WriteLine(original.ToString());
                
                //convertir a lista de objetos
                List<Linea15> archivoEmpTrans = JsonConvert.DeserializeObject<List<Linea15>>(original);
                Console.WriteLine("Lista original convertida a objetos");
                foreach (var item in archivoEmpTrans)
                {
                    Console.WriteLine(item.ToString());
                }

                long emp_id = archivoEmpTrans.LongCount()+1;

                Linea15 linea15 = new Linea15(emp_id);
                Console.WriteLine("Nuevo objeto creado");
                Console.WriteLine(linea15.ToString());

                archivoEmpTrans.Add(linea15);
                Console.WriteLine("nueva lista add obj nuevo");
                foreach (var item in archivoEmpTrans)
                {
                    Console.WriteLine(item.ToString());
                }

                string output = JsonConvert.SerializeObject(archivoEmpTrans);
                Console.WriteLine("Nuevo Json para guardar en file system");
                Console.WriteLine(output.ToString());

                System.IO.File.WriteAllText(path, output);
                
                IBus coche43 = new Bus(++keys,43,TipoBus.REGULAR,linea15);
                Console.WriteLine(coche43.ToString());

                linea15.AgregarBus((Bus) coche43);
                */

                EmpresaBilletaje mas = new EmpresaBilletaje(++keys, "Empresa EPAS", "más");
                Console.WriteLine("Empresa "+mas.ToString());

                Tarjeta tarjetas = new Tarjeta(++keys, "3600-0020-0031-9479", mas);
                Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);

                TarjetaRepo repo = new TarjetaRepo();

                if (repo.create(tarjetas))
                {
                    Console.WriteLine("Archivo creado con éxito!");
                }
                else
                {
                    Console.WriteLine("No se creo archivo");
                }

                /*
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

                */


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
