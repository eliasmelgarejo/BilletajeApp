using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.dominio
{
    public class Linea15 : EmpresaTransporte
    {
        public Linea15(long id)
        {
            Id = id;
            Nombre = this.GetType().Name; //reflexion
        }
    }
}
