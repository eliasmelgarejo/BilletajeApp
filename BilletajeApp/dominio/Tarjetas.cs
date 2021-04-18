using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Tarjetas
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Usuario { get; set; } //numero de cédula
        public double Saldo { get; set; }
        public EmpresaBilletaje Empresa { get; set; }
        public bool Activa { get; set; }

        public Tarjetas(int _Id,string _Numero,EmpresaBilletaje _Empresa)
        {
            this.Id = _Id;
            this.Numero = _Numero;
            this.Empresa = _Empresa;
        }

        public void ActivarTarjeta()
        {
            this.Activa = true;
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
            return this.Saldo -= monto;
        }

        public void AsignarUsuario(string cedula)
        {
            this.Usuario = cedula;
        }

        public override string ToString()
        {
            return "Tarjeta Nro."+this.Numero+" de la Marca: "+this.Empresa.Marca;
        }

        public override bool Equals(object obj)
        {
            bool R = false;
            if (this.Numero == ((Tarjetas)obj).Numero)
            {
                R = true;
            }
            return R;
        }
    }
}
