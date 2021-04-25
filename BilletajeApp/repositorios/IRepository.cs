using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.repositorios
{
    public interface IRepository<T>
    {
        bool create(T t);
        bool remove(T t);
        List<T> findAll();
        T findById(Guid uuid);
    }
}
