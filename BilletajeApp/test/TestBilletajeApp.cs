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
        public static bool testTarjetasRepo()
        {
            bool R = false;
            try
            {
                
               


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
