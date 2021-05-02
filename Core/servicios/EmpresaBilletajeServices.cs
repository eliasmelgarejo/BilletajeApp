using BilletajeApp.Core.dominio;
using BilletajeApp.Core.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.Core.servicios
{
    public class EmpresaBilletajeServices : IServices<EmpresaBilletaje>
    {
        private EmpresaBilletajeRepo repo = new EmpresaBilletajeRepo();

        public bool create(EmpresaBilletaje t)
        {
           return repo.create(t);
        }

        public bool delete(EmpresaBilletaje t)
        {
            return repo.remove(t);
        }

        public List<EmpresaBilletaje> findAll()
        {
            return repo.findAll();
        }

        public EmpresaBilletaje findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(EmpresaBilletaje t)
        {
            return repo.edit(t);
        }
    }
}
