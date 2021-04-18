using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletajeApp.dominio;

namespace BilletajeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpresaBilletaje mas = new EmpresaBilletaje(1, "Empresa EPAS", "más");

            Console.WriteLine("Empresa: " + mas.Marca.ToString());

            Tarjetas tarjetas = new Tarjetas(1, "3600-0020-0031-9479", mas);
            Console.WriteLine(tarjetas.ToString()+" - "+ "Activa: "+tarjetas.Activa);

            tarjetas.ActivarTarjeta();
            Console.WriteLine(tarjetas.ToString() + " - " + "Activa: " + tarjetas.Activa);
            Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
            tarjetas.SumarSaldo(56000);
            Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);
            tarjetas.RestarSaldo(3400);
            Console.WriteLine(tarjetas.ToString() + " - " + "Saldo: " + tarjetas.Saldo);

            Console.ReadLine();
        }
    }
}
