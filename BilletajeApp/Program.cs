using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletajeApp.dominio;
using BilletajeApp.test;

namespace BilletajeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBilletajeApp.testTarjetasRepo();

            Console.ReadKey();
        }
    }
}
