using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class EmpresaTransporteServices : IServices<EmpresaTransporte>
    {
        private EmpresaTransporteRepo repo = new EmpresaTransporteRepo();

        public bool create(EmpresaTransporte t)
        {
           return repo.create(t);
        }

        public bool delete(EmpresaTransporte t)
        {
            return repo.remove(t);
        }

        public List<EmpresaTransporte> findAll()
        {
            return repo.findAll();
        }

        public EmpresaTransporte findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(EmpresaTransporte t)
        {
            return repo.edit(t);
        }

        public EmpresaTransporte findByNombre(String nombre)
        {
            return repo.findByNombre(nombre);
        }
    }
}
