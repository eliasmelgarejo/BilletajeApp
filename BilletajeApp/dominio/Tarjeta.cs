using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Tarjeta : EntidadBase
    {
        
        public string Numero { get; set; }
        public Usuario Usuario { get; set; } //numero de cédula
        public double Saldo { get; set; }
        public EmpresaBilletaje Empresa { get; set; }
        public bool Activa { get; set; }

        public Tarjeta(string _Numero,EmpresaBilletaje _Empresa)
        {
            this.Numero = _Numero;
            this.Empresa = _Empresa;
        }

        public bool ActivarTarjeta()
        {
            if(this.Usuario != null)
            {
                this.Activa = true;
            }
            return this.Activa;
        }

        public void BloquearTarjeta()
        {
            this.Activa = false;
        }

        public double SumarSaldo(double monto)
        {
            return this.Saldo += monto;
        }

        public double RestarSaldo(double monto)
        {
            Console.WriteLine("Restando Gs."+monto+" de la tarjeta "+this.Numero);
            return this.Saldo -= monto;
        }

        public void AsignarUsuario(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public override string ToString()
        {
            return "Id: "+this.id+" Tarjeta Nro: "+this.Numero+" de la Marca: "+this.Empresa.Marca;
        }

    }
}
