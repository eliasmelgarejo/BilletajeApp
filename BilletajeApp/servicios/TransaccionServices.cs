using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class TransaccionServices : IServices<Transaccion>
    {
        private TransaccionRepo repo = new TransaccionRepo();

        public bool create(Transaccion t)
        {
            return repo.create(t);
        }

        public bool delete(Transaccion t)
        {
            return repo.remove(t);
        }

        public List<Transaccion> findAll()
        {
            return repo.findAll();
        }

        public Transaccion findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(Transaccion t)
        {
            return repo.edit(t);
        }

    }
}
