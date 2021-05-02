using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class TarjetaServices : IServices<Tarjeta>
    {
        private TarjetaRepo repo = new TarjetaRepo();

        public bool create(Tarjeta t)
        {
            return repo.create(t);
        }

        public bool delete(Tarjeta t)
        {
            return repo.remove(t);
        }

        public List<Tarjeta> findAll()
        {
            return repo.findAll();
        }

        public Tarjeta findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(Tarjeta t)
        {
            return repo.edit(t);
        }

        //custom method
        public Tarjeta findByNumero(String numero)
        {
            return repo.findByNumero(numero);
        }

        public double saldo(String numero)
        {
            return repo.findByNumero(numero).saldo;
        }

        public double restarSaldo(String numero, double monto)
        {
            return repo.restarSaldo(numero, monto);
        }

        public double sumarSaldo(String numero, double monto)
        {
            return repo.sumarSaldo(numero, monto);
        }

    }
}
