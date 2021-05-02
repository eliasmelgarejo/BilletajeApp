using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class BusServices : IServices<Bus>
    {
        private BusRepo repo = new BusRepo();

        public bool create(Bus t)
        {
            return repo.create(t);
        }

        public bool delete(Bus t)
        {
            return repo.remove(t);
        }

        public List<Bus> findAll()
        {
            return repo.findAll();
        }

        public Bus findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(Bus t)
        {
            return repo.edit(t);
        }
    }
}
