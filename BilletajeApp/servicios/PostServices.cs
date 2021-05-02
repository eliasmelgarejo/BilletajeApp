using BilletajeApp.dominio;
using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public class PostServices : IServices<Post>
    {
        private PostRepo repo = new PostRepo();

        public bool create(Post t)
        {
            return repo.create(t);
        }

        public bool delete(Post t)
        {
            return repo.remove(t);
        }

        public List<Post> findAll()
        {
            return repo.findAll();
        }

        public Post findById(Guid uuid)
        {
            return repo.findById(uuid);
        }

        public bool update(Post t)
        {
            return repo.edit(t);
        }
    }
}
