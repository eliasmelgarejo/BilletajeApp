using BilletajeApp.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.servicios
{
    public interface IServices<T>
    {
        bool create(T t);
        bool delete(T t);
        bool update(T t);
        List<T> findAll();
        T findById(Guid uuid);
    }
}
