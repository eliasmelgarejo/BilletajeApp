using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletajeApp.Core.dominio
{
    public class Linea15 : EmpresaTransporte
    {
        public Linea15()
        {
            nombre = this.GetType().Name; //reflexion
        }
    }
}
