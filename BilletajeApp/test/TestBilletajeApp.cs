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
        public static bool testBusRepo()
        {
            bool R = false;
            try
            {
                BusRepo repo = new BusRepo();

                Linea15 linea15 = new Linea15();
                Console.WriteLine(linea15.ToString());
                
                Bus bus = new Bus(1, TipoBus.REGULAR);
                bus.Empresa = linea15;

                Console.WriteLine(bus.ToString());

                if (repo.create(bus))
                {
                    Console.WriteLine("Archivo creado!");
                }
                else
                {
                    Console.WriteLine("Error..");
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                R = false;
            }

            return R;
        }
        public static bool testEmpresaTransRepo()
        {
            bool R = false;

            try
            {
                EmpresaBilletajeRepo repo = new EmpresaBilletajeRepo();

                EmpresaBilletaje billetaje = new EmpresaBilletaje("ADF", "MASS");
                R = repo.create(billetaje);

                if (R)
                {
                    Console.WriteLine(billetaje.className + " creada: "+billetaje.ToString());
                }
                else
                {
                    Console.WriteLine("no se creo...");
                }
                
            }
            catch (Exception e)
            {

                R = false;
                Console.WriteLine("Error: " + e.Message);
            }

            return R;
        }
    }
}
