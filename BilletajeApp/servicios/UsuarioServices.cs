using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class UsuarioServices : IServices<Usuario>
    {
        private UsuarioRepo repo = new UsuarioRepo();

        public bool create(Usuario t)
        {
           return repo.create(t);
        }

        public bool delete(Usuario t)
        {
            return repo.remove(t);
        }

        public List<Usuario> findAll()
        {
            return repo.findAll();
        }

        public Usuario findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(Usuario t)
        {
            return repo.edit(t);
        }

        //
        public Usuario findById(string  cedula)
        {
            return repo.findByCedula(cedula);
        }
    }
}
